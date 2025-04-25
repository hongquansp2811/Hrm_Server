using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories;
using Hrm_Server.Repositories.Interfaces;
using Hrm_Server.Services;

namespace Hrm_Server.UI.EmployeeForm
{
    public partial class ListEmployee : Form
    {
        private readonly IEmployeeService _employeeService;
        private List<Employee> _employees;
        private Employee _currentUser;
        
        public ListEmployee(Employee currentUser = null)
        {
            InitializeComponent();
            
            // Khởi tạo services
            var dbContext = new HrmDbContext();
            IEmployeeRepository employeeRepository = new EmployeeRepository(dbContext);
            IDepartmentRepository departmentRepository = new DepartmentRepository(dbContext);
            IPositionRepository positionRepository = new PositionRepository(dbContext);
            ISalaryGradeRepository salaryGradeRepository = new SalaryGradeRepository(dbContext);
            IEmployeeTypeRepository employeeTypeRepository = new EmployeeTypeRepository(dbContext);
            
            _employeeService = new EmployeeService(
                employeeRepository, 
                departmentRepository, 
                positionRepository,
                salaryGradeRepository,
                employeeTypeRepository);
                
            _currentUser = currentUser;
            
            // Đăng ký sự kiện
            this.Load += ListEmployee_Load;
            btnSearch.Click += BtnSearch_Click;
            btnReset.Click += BtnReset_Click;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
        }
        
        private void ListEmployee_Load(object sender, EventArgs e)
        {
            // Thiết lập form
            SetupDataGridView();
            
            // Load dữ liệu
            LoadEmployees();
            
            // Load phòng ban vào combobox
            LoadDepartments();
        }
        
        private void SetupDataGridView()
        {
            // Thiết lập thuộc tính của DataGridView
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.ReadOnly = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            
            // Xóa các cột cũ nếu có
            dgvEmployees.Columns.Clear();
            
            // Thêm các cột
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeId",
                HeaderText = "ID",
                DataPropertyName = "EmployeeId",
                Width = 50,
                Visible = false
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EmployeeCode",
                HeaderText = "Mã NV",
                DataPropertyName = "EmployeeCode",
                Width = 80
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "Họ và tên",
                DataPropertyName = "FullName",
                Width = 180
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Gender",
                HeaderText = "Giới tính",
                DataPropertyName = "Gender",
                Width = 80
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateOfBirth",
                HeaderText = "Ngày sinh",
                DataPropertyName = "DateOfBirth",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                HeaderText = "Điện thoại",
                DataPropertyName = "PhoneNumber",
                Width = 110
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Department",
                HeaderText = "Phòng ban",
                DataPropertyName = "Department.DepartmentName",
                Width = 150
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Position",
                HeaderText = "Chức vụ",
                DataPropertyName = "Position.PositionName",
                Width = 120
            });
            
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "JoinDate",
                HeaderText = "Ngày vào làm",
                DataPropertyName = "JoinDate",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
        }
        
        private void LoadEmployees()
        {
            try
            {
                _employees = _employeeService.GetAllEmployees().ToList();
                dgvEmployees.DataSource = _employees;
                
                // Hiển thị số lượng nhân viên
                lblTotalEmployees.Text = $"Tổng số: {_employees.Count} nhân viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách nhân viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadDepartments()
        {
            try
            {
                // Thêm tùy chọn "Tất cả phòng ban"
                var departments = new List<Department>
                {
                    new Department { DepartmentId = 0, DepartmentName = "Tất cả phòng ban" }
                };
                
                // Thêm danh sách phòng ban từ service
                departments.AddRange(_employeeService.GetAllDepartments());
                
                // Gán dữ liệu cho ComboBox
                cmbDepartment.DataSource = departments;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentId";
                
                // Mặc định chọn "Tất cả phòng ban"
                cmbDepartment.SelectedValue = 0;
                
                // Đăng ký sự kiện thay đổi phòng ban
                cmbDepartment.SelectedIndexChanged += CmbDepartment_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phòng ban: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ áp dụng bộ lọc nếu không phải "Tất cả phòng ban"
            int departmentId = (int)cmbDepartment.SelectedValue;
            
            if (departmentId == 0)
            {
                // Hiển thị tất cả nhân viên
                dgvEmployees.DataSource = _employees;
            }
            else
            {
                // Lọc theo phòng ban
                dgvEmployees.DataSource = _employees.Where(emp => emp.DepartmentId == departmentId).ToList();
            }
            
            // Cập nhật số lượng nhân viên hiển thị
            lblTotalEmployees.Text = $"Tổng số: {((List<Employee>)dgvEmployees.DataSource).Count} nhân viên";
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            
            try
            {
                // Tìm kiếm nhân viên
                var searchResults = _employeeService.SearchEmployees(searchTerm);
                
                // Hiển thị kết quả
                dgvEmployees.DataSource = searchResults.ToList();
                
                // Cập nhật số lượng
                lblTotalEmployees.Text = $"Tổng số: {((List<Employee>)dgvEmployees.DataSource).Count} nhân viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Đặt lại tìm kiếm và bộ lọc
            txtSearch.Clear();
            cmbDepartment.SelectedValue = 0;
            
            // Tải lại dữ liệu
            LoadEmployees();
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }
        
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có nhân viên nào được chọn không
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xem chi tiết.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Lấy ID của nhân viên được chọn
            int employeeId = (int)dgvEmployees.CurrentRow.Cells["EmployeeId"].Value;
            
            // Mở form xem thông tin chi tiết nhân viên
            var employeeForm = new EmployeeForm(employeeId);
            employeeForm.ShowDialog();
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có nhân viên nào được chọn không
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            // Lấy thông tin nhân viên được chọn
            int employeeId = (int)dgvEmployees.CurrentRow.Cells["EmployeeId"].Value;
            string employeeName = dgvEmployees.CurrentRow.Cells["FullName"].Value.ToString();
            
            // Xác nhận xóa
            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên '{employeeName}'?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Xóa nhân viên
                    _employeeService.DeleteEmployee(employeeId);
                    
                    // Thông báo thành công
                    MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Tải lại danh sách nhân viên
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void DgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ xử lý khi click vào dòng dữ liệu (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy ID của nhân viên được chọn
                int employeeId = (int)dgvEmployees.Rows[e.RowIndex].Cells["EmployeeId"].Value;
                
                // Mở form xem thông tin chi tiết nhân viên
                var employeeForm = new EmployeeForm(employeeId);
                employeeForm.ShowDialog();
            }
        }
    }
}