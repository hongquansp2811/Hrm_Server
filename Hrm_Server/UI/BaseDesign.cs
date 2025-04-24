using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hrm_Server.UI
{
    public static class BaseDesign
    {
        // Màu sắc chủ đạo - sử dụng màu từ formMain.cs
        public static Color PrimaryColor = Color.FromArgb(0, 122, 204);    // Màu xanh dương đẹp mắt
        public static Color SecondaryColor = Color.FromArgb(46, 204, 113);  // Màu xanh lá cây
        public static Color DangerColor = Color.FromArgb(231, 76, 60);      // Màu đỏ
        public static Color WarningColor = Color.FromArgb(241, 196, 15);    // Màu vàng
        public static Color InfoColor = Color.FromArgb(52, 152, 219);       // Màu xanh da trời
        public static Color LightGrayColor = Color.FromArgb(240, 240, 240); // Màu xám nhẹ (từ formMain.cs)
        public static Color DarkGrayColor = Color.FromArgb(51, 51, 51);     // Màu xám đậm
        public static Color WhiteColor = Color.FromArgb(255, 255, 255);     // Màu trắng
        public static Color HeaderColor = Color.FromArgb(0, 122, 204);      // Màu tiêu đề (từ formMain.cs)
        
        // Gradient Colors
        public static Color GradientStart = Color.FromArgb(0, 122, 204);
        public static Color GradientEnd = Color.FromArgb(0, 80, 150);
        
        // Font chữ
        public static Font HeadingFont = new Font("Segoe UI", 16, FontStyle.Bold);
        public static Font TitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static Font SubtitleFont = new Font("Segoe UI", 9.75F, FontStyle.Bold); // Font tiêu đề nhỏ (từ formMain.cs)
        public static Font RegularFont = new Font("Segoe UI", 9, FontStyle.Regular);
        public static Font SmallFont = new Font("Segoe UI", 8, FontStyle.Regular);
        
        // Border Radius
        public static int BorderRadius = 0; // Không bo góc để phù hợp với giao diện Windows Forms tiêu chuẩn
        
        // Tạo TextBox tiêu chuẩn
        public static TextBox CreateTextBox(string name, string placeholder = "", bool isPassword = false)
        {
            TextBox textBox = new TextBox
            {
                Name = name,
                Font = RegularFont,
                Size = new Size(250, 23),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(2, 2, 2, 2)
            };
            
            if (isPassword)
            {
                textBox.PasswordChar = '•';
            }
            
            if (!string.IsNullOrEmpty(placeholder))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
                
                textBox.Enter += (sender, e) =>
                {
                    if (textBox.Text == placeholder)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                        if (isPassword)
                        {
                            textBox.PasswordChar = '•';
                        }
                    }
                };
                
                textBox.Leave += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = placeholder;
                        textBox.ForeColor = Color.Gray;
                        if (isPassword)
                        {
                            textBox.PasswordChar = '\0';
                        }
                    }
                };
                
                if (isPassword)
                {
                    textBox.PasswordChar = '\0';
                }
            }
            
            return textBox;
        }
        
        // Tạo Button tiêu chuẩn
        public static Button CreateButton(string name, string text, Color backColor, Color foreColor)
        {
            Button button = new Button
            {
                Name = name,
                Text = text,
                Font = RegularFont,
                BackColor = backColor,
                ForeColor = foreColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 30),
                Cursor = Cursors.Hand
            };
            
            button.FlatAppearance.BorderSize = 0;
            
            // Hiệu ứng hover
            button.MouseEnter += (sender, e) => {
                button.BackColor = ChangeColorBrightness(backColor, -0.1f);
            };
            
            button.MouseLeave += (sender, e) => {
                button.BackColor = backColor;
            };
            
            return button;
        }
        
        // Tạo Label tiêu đề
        public static Label CreateHeading(string text)
        {
            Label label = new Label
            {
                Text = text,
                Font = HeadingFont,
                ForeColor = DarkGrayColor,
                AutoSize = true
            };
            
            return label;
        }
        
        // Tạo Label thông thường
        public static Label CreateLabel(string text, Font font = null)
        {
            Label label = new Label
            {
                Text = text,
                Font = font ?? RegularFont,
                ForeColor = DarkGrayColor,
                AutoSize = true
            };
            
            return label;
        }
        
        // Tạo LinkLabel
        public static LinkLabel CreateLinkLabel(string text, Font font = null)
        {
            LinkLabel linkLabel = new LinkLabel
            {
                Text = text,
                Font = font ?? RegularFont,
                LinkColor = PrimaryColor,
                ActiveLinkColor = InfoColor,
                AutoSize = true
            };
            
            return linkLabel;
        }
        
        // Tạo DateTimePicker
        public static DateTimePicker CreateDateTimePicker(string name)
        {
            DateTimePicker dateTimePicker = new DateTimePicker
            {
                Name = name,
                Font = RegularFont,
                Size = new Size(250, 23),
                Format = DateTimePickerFormat.Short,
                CalendarForeColor = DarkGrayColor,
                CalendarTitleBackColor = PrimaryColor,
                CalendarTitleForeColor = Color.White
            };
            
            return dateTimePicker;
        }
        
        // Tạo Panel
        public static Panel CreatePanel(int width, int height)
        {
            Panel panel = new Panel
            {
                Size = new Size(width, height),
                BorderStyle = BorderStyle.None,
                BackColor = Color.White
            };
            
            return panel;
        }
        
        // Định dạng DataGridView theo style trong formMain.cs
        public static void FormatDataGridView(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = LightGrayColor;
            dgv.DefaultCellStyle.SelectionBackColor = PrimaryColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.Font = SubtitleFont;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 30;
            dgv.EnableHeadersVisualStyles = false;
        }
        
        // Hiển thị thông báo lỗi
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        // Hiển thị thông báo thành công
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        // Hiển thị thông báo xác nhận
        public static DialogResult ShowConfirm(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        
        // Hàm hỗ trợ thay đổi độ sáng của màu
        private static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = color.R;
            float green = color.G;
            float blue = color.B;
            
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            
            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }
    }
}