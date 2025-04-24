using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Entities;
using Hrm_Server.Repositories;
using Hrm_Server.Repositories.Interfaces;
using Hrm_Server.Services;
using Hrm_Server.UI.EmployeeForm;

namespace Hrm_Server.UI.AuthForm
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;
        
        public Login()
        {
            InitializeComponent();
            
            // Khởi tạo các dependency
            var dbContext = new HrmDbContext();
            IUserRepository userRepository = new UserRepository(dbContext);
            IEmployeeRepository employeeRepository = new EmployeeRepository(dbContext);
            _authService = new AuthService(userRepository, employeeRepository);
            
            // Đặt thuộc tính Region để bo góc form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
            
            // Căn giữa form
            this.CenterToScreen();
            
            // Đặt focus vào ô tài khoản
            txtUsername.Focus();
        }
        
        // Phương thức để tạo vùng bo tròn
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        
        // Vẽ panel biểu tượng với nền gradient
        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {
            // Tạo brush gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(0, panel1.Height),
                BaseDesign.GradientStart,
                BaseDesign.GradientEnd))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }
        
        // Vẽ nút với góc bo tròn
        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                GraphicsPath path = new GraphicsPath();
                int radius = BaseDesign.BorderRadius;
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
                
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.X + rect.Width - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.X + rect.Width - radius * 2, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseAllFigures();
                
                btn.Region = new Region(path);
                
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(btn.BackColor), path);
                
                // Đổ bóng nhẹ
                rect.Inflate(-1, -1);
                e.Graphics.DrawPath(new Pen(Color.FromArgb(60, 0, 0, 0), 1), path);
            }
        }
        
        // Vẽ panel cho textbox với viền
        private void TextBoxPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl != null)
            {
                // Vẽ viền cho panel
                using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
                }
            }
        }
        
        // Sự kiện khi textbox được focus
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                Panel parent = txt.Parent as Panel;
                if (parent != null)
                {
                    parent.BackColor = Color.FromArgb(240, 248, 255); // Light blue background on focus
                }
            }
        }
        
        // Sự kiện khi textbox mất focus
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                Panel parent = txt.Parent as Panel;
                if (parent != null)
                {
                    parent.BackColor = BaseDesign.WhiteColor;
                }
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            
            // Gọi AuthService để xử lý đăng nhập
            User user = _authService.Login(username, password);
            
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Lấy thông tin nhân viên tương ứng với user đăng nhập
                var employee = user.Employee;
                
                // Mở form danh sách nhân viên
                var employeeListForm = new ListEmployee(employee);
                this.Hide();
                employeeListForm.FormClosed += (s, args) => this.Close();
                employeeListForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form quên mật khẩu
            using (var forgotPasswordForm = new RememberPassword())
            {
                this.Hide();
                forgotPasswordForm.ShowDialog();
                this.Show();
            }
        }
    }
}