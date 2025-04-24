using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Hrm_Server.DbContextHrm;
using Hrm_Server.Repositories;
using Hrm_Server.Repositories.Interfaces;
using Hrm_Server.Services;

namespace Hrm_Server.UI.AuthForm
{
    public partial class RememberPassword : Form
    {
        private readonly IAuthService _authService;
        private string _currentUsername = string.Empty;
        
        public RememberPassword()
        {
            InitializeComponent();
            
            // Khởi tạo các dependency
            var dbContext = new HrmDbContext();
            IUserRepository userRepository = new UserRepository(dbContext);
            IEmployeeRepository employeeRepository = new EmployeeRepository(dbContext);
            _authService = new AuthService(userRepository, employeeRepository);
            
            // Khởi tạo hiển thị mặc định
            pnlVerify.Visible = true;
            pnlNewPassword.Visible = false;
            
            // Đặt thuộc tính Region để bo góc form
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
            
            // Cập nhật giao diện DateTimePicker
            StyleDateTimePicker();
            
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
        
        // Cập nhật giao diện DateTimePicker
        private void StyleDateTimePicker()
        {
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
            dtpDateOfBirth.Font = BaseDesign.RegularFont;
            dtpDateOfBirth.CalendarTitleBackColor = BaseDesign.PrimaryColor;
            dtpDateOfBirth.CalendarTitleForeColor = BaseDesign.WhiteColor;
            
            // Đặt màu sắc và viền
            dtpDateOfBirth.BackColor = BaseDesign.WhiteColor;
            dtpDateOfBirth.ForeColor = BaseDesign.DarkGrayColor;
        }
        
        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ form
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string phoneNumber = txtPhoneNumber.Text.Trim();
            
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }
            
            // Gọi AuthService để xác minh thông tin
            bool isVerified = _authService.VerifyPersonalInfo(username, fullName, dateOfBirth, phoneNumber);
            
            if (isVerified)
            {
                // Lưu username hiện tại để sử dụng khi đặt lại mật khẩu
                _currentUsername = username;
                
                // Chuyển sang giao diện đặt lại mật khẩu
                pnlVerify.Visible = false;
                pnlNewPassword.Visible = true;
                
                // Focus vào trường mật khẩu mới
                txtNewPassword.Focus();
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác hoặc không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mật khẩu mới
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }
            
            // Kiểm tra mật khẩu nhập lại có khớp không
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp với mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }
            
            // Kiểm tra mật khẩu có đủ mạnh không
            if (newPassword.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }
            
            // Gọi AuthService để đặt lại mật khẩu
            bool isSuccess = _authService.ResetPassword(_currentUsername, newPassword);
            
            if (isSuccess)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại! Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Nếu đang ở giao diện đặt lại mật khẩu, quay lại giao diện xác minh
            if (pnlNewPassword.Visible)
            {
                pnlNewPassword.Visible = false;
                pnlVerify.Visible = true;
                
                // Xóa mật khẩu đã nhập
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else
            {
                // Nếu đang ở giao diện xác minh, đóng form
                this.Close();
            }
        }
    }
}