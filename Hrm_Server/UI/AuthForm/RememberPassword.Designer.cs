using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Hrm_Server.UI;

namespace Hrm_Server.UI.AuthForm
{
    partial class RememberPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNewPassword = new System.Windows.Forms.Panel();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.btnBackToVerify = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblEnterNewPassword = new System.Windows.Forms.Label();
            this.pnlVerify = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblForgotPasswordHeading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlNewPassword.SuspendLayout();
            this.pnlVerify.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = BaseDesign.PrimaryColor;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(70, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = BaseDesign.HeadingFont;
            this.lblAppName.ForeColor = BaseDesign.WhiteColor;
            this.lblAppName.Location = new System.Drawing.Point(21, 230);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(219, 30);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // panel2
            // 
            this.panel2.BackColor = BaseDesign.WhiteColor;
            this.panel2.Controls.Add(this.pnlNewPassword);
            this.panel2.Controls.Add(this.pnlVerify);
            this.panel2.Controls.Add(this.lblForgotPasswordHeading);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 450);
            this.panel2.TabIndex = 1;
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.Controls.Add(this.btnSavePassword);
            this.pnlNewPassword.Controls.Add(this.btnBackToVerify);
            this.pnlNewPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlNewPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlNewPassword.Controls.Add(this.txtNewPassword);
            this.pnlNewPassword.Controls.Add(this.lblNewPassword);
            this.pnlNewPassword.Controls.Add(this.lblEnterNewPassword);
            this.pnlNewPassword.Location = new System.Drawing.Point(17, 70);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(295, 350);
            this.pnlNewPassword.TabIndex = 7;
            this.pnlNewPassword.Visible = false;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = BaseDesign.PrimaryColor;
            this.btnSavePassword.FlatAppearance.BorderSize = 0;
            this.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePassword.Font = BaseDesign.RegularFont;
            this.btnSavePassword.ForeColor = BaseDesign.WhiteColor;
            this.btnSavePassword.Location = new System.Drawing.Point(155, 223);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(100, 30);
            this.btnSavePassword.TabIndex = 3;
            this.btnSavePassword.Text = "Lưu";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnBackToVerify
            // 
            this.btnBackToVerify.BackColor = BaseDesign.LightGrayColor;
            this.btnBackToVerify.FlatAppearance.BorderSize = 0;
            this.btnBackToVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToVerify.Font = BaseDesign.RegularFont;
            this.btnBackToVerify.ForeColor = BaseDesign.DarkGrayColor;
            this.btnBackToVerify.Location = new System.Drawing.Point(37, 223);
            this.btnBackToVerify.Name = "btnBackToVerify";
            this.btnBackToVerify.Size = new System.Drawing.Size(100, 30);
            this.btnBackToVerify.TabIndex = 4;
            this.btnBackToVerify.Text = "Trở lại";
            this.btnBackToVerify.UseVisualStyleBackColor = false;
            this.btnBackToVerify.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = BaseDesign.RegularFont;
            this.txtConfirmPassword.Location = new System.Drawing.Point(37, 175);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(218, 23);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = BaseDesign.RegularFont;
            this.lblConfirmPassword.Location = new System.Drawing.Point(37, 157);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(114, 15);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = BaseDesign.RegularFont;
            this.txtNewPassword.Location = new System.Drawing.Point(37, 123);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(218, 23);
            this.txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = BaseDesign.RegularFont;
            this.lblNewPassword.Location = new System.Drawing.Point(37, 105);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(85, 15);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblEnterNewPassword
            // 
            this.lblEnterNewPassword.AutoSize = true;
            this.lblEnterNewPassword.Font = BaseDesign.TitleFont;
            this.lblEnterNewPassword.ForeColor = BaseDesign.DarkGrayColor;
            this.lblEnterNewPassword.Location = new System.Drawing.Point(69, 44);
            this.lblEnterNewPassword.Name = "lblEnterNewPassword";
            this.lblEnterNewPassword.Size = new System.Drawing.Size(159, 21);
            this.lblEnterNewPassword.TabIndex = 0;
            this.lblEnterNewPassword.Text = "Nhập mật khẩu mới";
            // 
            // pnlVerify
            // 
            this.pnlVerify.Controls.Add(this.btnBack);
            this.pnlVerify.Controls.Add(this.btnVerify);
            this.pnlVerify.Controls.Add(this.dtpDateOfBirth);
            this.pnlVerify.Controls.Add(this.txtPhoneNumber);
            this.pnlVerify.Controls.Add(this.lblPhoneNumber);
            this.pnlVerify.Controls.Add(this.lblDateOfBirth);
            this.pnlVerify.Controls.Add(this.txtFullName);
            this.pnlVerify.Controls.Add(this.lblFullName);
            this.pnlVerify.Controls.Add(this.txtUsername);
            this.pnlVerify.Controls.Add(this.lblUsername);
            this.pnlVerify.Location = new System.Drawing.Point(17, 70);
            this.pnlVerify.Name = "pnlVerify";
            this.pnlVerify.Size = new System.Drawing.Size(295, 350);
            this.pnlVerify.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = BaseDesign.LightGrayColor;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = BaseDesign.RegularFont;
            this.btnBack.ForeColor = BaseDesign.DarkGrayColor;
            this.btnBack.Location = new System.Drawing.Point(37, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = BaseDesign.PrimaryColor;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = BaseDesign.RegularFont;
            this.btnVerify.ForeColor = BaseDesign.WhiteColor;
            this.btnVerify.Location = new System.Drawing.Point(155, 280);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 30);
            this.btnVerify.TabIndex = 5;
            this.btnVerify.Text = "Tiếp tục";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = BaseDesign.RegularFont;
            this.dtpDateOfBirth.Font = BaseDesign.RegularFont;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(37, 175);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(218, 23);
            this.dtpDateOfBirth.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = BaseDesign.RegularFont;
            this.txtPhoneNumber.Location = new System.Drawing.Point(37, 227);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(218, 23);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = BaseDesign.RegularFont;
            this.lblPhoneNumber.Location = new System.Drawing.Point(37, 209);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 15);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = BaseDesign.RegularFont;
            this.lblDateOfBirth.Location = new System.Drawing.Point(37, 157);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(62, 15);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Ngày sinh";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = BaseDesign.RegularFont;
            this.txtFullName.Location = new System.Drawing.Point(37, 123);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(218, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = BaseDesign.RegularFont;
            this.lblFullName.Location = new System.Drawing.Point(37, 105);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(58, 15);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ và tên";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = BaseDesign.RegularFont;
            this.txtUsername.Location = new System.Drawing.Point(37, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = BaseDesign.RegularFont;
            this.lblUsername.Location = new System.Drawing.Point(37, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblForgotPasswordHeading
            // 
            this.lblForgotPasswordHeading.AutoSize = true;
            this.lblForgotPasswordHeading.Font = BaseDesign.HeadingFont;
            this.lblForgotPasswordHeading.ForeColor = BaseDesign.DarkGrayColor;
            this.lblForgotPasswordHeading.Location = new System.Drawing.Point(55, 25);
            this.lblForgotPasswordHeading.Name = "lblForgotPasswordHeading";
            this.lblForgotPasswordHeading.Size = new System.Drawing.Size(218, 30);
            this.lblForgotPasswordHeading.TabIndex = 0;
            this.lblForgotPasswordHeading.Text = "QUÊN MẬT KHẨU";
            // 
            // RememberPassword
            // 
            this.AcceptButton = this.btnVerify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = BaseDesign.RegularFont;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RememberPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên mật khẩu - Hệ thống quản lý nhân sự";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            this.pnlVerify.ResumeLayout(false);
            this.pnlVerify.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEnterNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.Button btnBackToVerify;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlVerify;
        private System.Windows.Forms.Panel pnlNewPassword;
        private System.Windows.Forms.Label lblForgotPasswordHeading;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}