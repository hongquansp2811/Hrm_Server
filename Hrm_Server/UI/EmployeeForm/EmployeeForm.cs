using System;
using System.Drawing;
using System.Windows.Forms;
using Hrm_Server.Entities;
using Hrm_Server.Services;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Repositories;
using Hrm_Server.Repositories.Interfaces;

namespace Hrm_Server.UI.EmployeeForm
{
    public partial class EmployeeForm : Form
    {
        private Employee _employee;
        private readonly IEmployeeService _employeeService;

        public EmployeeForm(int employeeId)
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

            // Lấy thông tin nhân viên từ ID
            _employee = _employeeService.GetEmployeeById(employeeId);

            // Đăng ký sự kiện
            this.Load += EmployeeForm_Load;
            btnClose.Click += BtnClose_Click;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            if (_employee != null)
            {
                LoadEmployeeInfo();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadEmployeeInfo()
        {
            // Thông tin cơ bản
            txtEmployeeCode.Text = _employee.EmployeeCode ?? "";
            txtFullName.Text = _employee.FullName ?? "";
            txtDateOfBirth.Text = _employee.DateOfBirth.ToString("dd/MM/yyyy") ?? "";
            txtGender.Text = _employee.Gender ?? "";
            txtIdentityNumber.Text = _employee.IdentityNumber ?? "";

            // Thông tin liên hệ
            txtPhoneNumber.Text = _employee.PhoneNumber ?? "";
            txtEmail.Text = _employee.Email ?? "";
            txtAddress.Text = _employee.TemporaryAddress ?? _employee.PermanentAddress ?? "";

            // Thông tin công việc
            txtDepartment.Text = _employee.Department?.DepartmentName ?? "";
            txtPosition.Text = _employee.Position?.PositionName ?? "";
            txtEmployeeType.Text = _employee.EmployeeType?.TypeName ?? "";
            txtJoinDate.Text = _employee.JoinDate.ToString("dd/MM/yyyy") ?? "";

            // Thông tin bậc lương
            if (_employee.SalaryGrade != null)
            {
                txtSalaryGrade.Text = _employee.SalaryGrade.GradeName;
                decimal baseSalary = _employee.SalaryGrade.BasicSalary;
                decimal coefficient = _employee.SalaryGrade.Coefficient;
                decimal currentSalary = baseSalary * coefficient;

                // Thêm thông tin lương vào GroupBox công việc
                Label lblSalary = new Label
                {
                    Text = "Mức lương:",
                    Font = new Font("Segoe UI", 9.75f),
                    AutoSize = true,
                    Location = new Point(23, 89)
                };

                TextBox txtSalary = new TextBox
                {
                    Font = new Font("Segoe UI", 9.75f),
                    ReadOnly = true,
                    Location = new Point(132, 89),
                    Size = new Size(180, 25),
                    Text = string.Format("{0:N0} VNĐ", currentSalary)
                };

                groupBoxWorkInfo.Controls.Add(lblSalary);
                groupBoxWorkInfo.Controls.Add(txtSalary);

                // Điều chỉnh kích thước
                groupBoxWorkInfo.Height += 40;
                groupBoxOtherInfo.Location = new Point(groupBoxOtherInfo.Location.X, groupBoxOtherInfo.Location.Y + 40);
                btnClose.Location = new Point(btnClose.Location.X, btnClose.Location.Y + 40);
                this.Height += 40;
            }

            // Thông tin khác
            txtInsuranceNumber.Text = _employee.InsuranceNumber ?? "";
            txtTaxCode.Text = _employee.TaxCode ?? "";
            txtBankAccount.Text = _employee.BankAccount ?? "";
            txtBankName.Text = _employee.BankName ?? "";

            // Thông tin bằng cấp
            if (_employee.Education != null && !string.IsNullOrEmpty(_employee.Education.EducationName))
            {
                Label lblEducation = new Label
                {
                    Text = "Học vấn:",
                    Font = new Font("Segoe UI", 9.75f),
                    AutoSize = true,
                    Location = new Point(428, 89)
                };

                TextBox txtEducation = new TextBox
                {
                    Font = new Font("Segoe UI", 9.75f),
                    ReadOnly = true,
                    Location = new Point(502, 89),
                    Size = new Size(180, 25),
                    Text = _employee.Education.EducationName
                };

                groupBoxOtherInfo.Controls.Add(lblEducation);
                groupBoxOtherInfo.Controls.Add(txtEducation);

                // Điều chỉnh kích thước
                groupBoxOtherInfo.Height += 40;
                btnClose.Location = new Point(btnClose.Location.X, btnClose.Location.Y + 40);
                this.Height += 40;
            }

            // Cập nhật tiêu đề form
            this.Text = $"Chi tiết nhân viên: {_employee.FullName ?? "Không xác định"}";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}