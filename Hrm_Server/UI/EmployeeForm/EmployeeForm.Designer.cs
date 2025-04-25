using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hrm_Server.UI.EmployeeForm
{
    partial class EmployeeForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBoxWorkInfo = new System.Windows.Forms.GroupBox();
            this.lblSalaryGrade = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtSalaryGrade = new System.Windows.Forms.TextBox();
            this.txtJoinDate = new System.Windows.Forms.TextBox();
            this.txtEmployeeType = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.groupBoxOtherInfo = new System.Windows.Forms.GroupBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.lblInsuranceNumber = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtInsuranceNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupBoxBasicInfo.SuspendLayout();
            this.groupBoxContactInfo.SuspendLayout();
            this.groupBoxWorkInfo.SuspendLayout();
            this.groupBoxOtherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CHI TIẾT NHÂN VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.lblIdentityNumber);
            this.groupBoxBasicInfo.Controls.Add(this.lblGender);
            this.groupBoxBasicInfo.Controls.Add(this.lblDateOfBirth);
            this.groupBoxBasicInfo.Controls.Add(this.lblFullName);
            this.groupBoxBasicInfo.Controls.Add(this.lblEmployeeCode);
            this.groupBoxBasicInfo.Controls.Add(this.txtIdentityNumber);
            this.groupBoxBasicInfo.Controls.Add(this.txtGender);
            this.groupBoxBasicInfo.Controls.Add(this.txtDateOfBirth);
            this.groupBoxBasicInfo.Controls.Add(this.txtFullName);
            this.groupBoxBasicInfo.Controls.Add(this.txtEmployeeCode);
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(12, 65);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(370, 190);
            this.groupBoxBasicInfo.TabIndex = 1;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "Thông tin cơ bản";
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Location = new System.Drawing.Point(20, 150);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(86, 17);
            this.lblIdentityNumber.TabIndex = 9;
            this.lblIdentityNumber.Text = "CMND/CCCD:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 120);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 17);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(20, 90);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(72, 17);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Ngày sinh:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 60);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 17);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Họ và tên:";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(20, 30);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(52, 17);
            this.lblEmployeeCode.TabIndex = 5;
            this.lblEmployeeCode.Text = "Mã NV:";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityNumber.Location = new System.Drawing.Point(120, 147);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.ReadOnly = true;
            this.txtIdentityNumber.Size = new System.Drawing.Size(220, 25);
            this.txtIdentityNumber.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(120, 117);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(100, 25);
            this.txtGender.TabIndex = 3;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOfBirth.Location = new System.Drawing.Point(120, 87);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(150, 25);
            this.txtDateOfBirth.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(120, 57);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(220, 25);
            this.txtFullName.TabIndex = 1;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeCode.Location = new System.Drawing.Point(120, 27);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.ReadOnly = true;
            this.txtEmployeeCode.Size = new System.Drawing.Size(150, 25);
            this.txtEmployeeCode.TabIndex = 0;
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.lblAddress);
            this.groupBoxContactInfo.Controls.Add(this.lblEmail);
            this.groupBoxContactInfo.Controls.Add(this.lblPhoneNumber);
            this.groupBoxContactInfo.Controls.Add(this.txtAddress);
            this.groupBoxContactInfo.Controls.Add(this.txtEmail);
            this.groupBoxContactInfo.Controls.Add(this.txtPhoneNumber);
            this.groupBoxContactInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxContactInfo.Location = new System.Drawing.Point(402, 65);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo";
            this.groupBoxContactInfo.Size = new System.Drawing.Size(370, 190);
            this.groupBoxContactInfo.TabIndex = 2;
            this.groupBoxContactInfo.TabStop = false;
            this.groupBoxContactInfo.Text = "Thông tin liên hệ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 90);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 30);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(87, 17);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(120, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(230, 80);
            this.txtAddress.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(120, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(230, 25);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 27);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 25);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // groupBoxWorkInfo
            // 
            this.groupBoxWorkInfo.Controls.Add(this.lblSalaryGrade);
            this.groupBoxWorkInfo.Controls.Add(this.lblJoinDate);
            this.groupBoxWorkInfo.Controls.Add(this.lblEmployeeType);
            this.groupBoxWorkInfo.Controls.Add(this.lblPosition);
            this.groupBoxWorkInfo.Controls.Add(this.lblDepartment);
            this.groupBoxWorkInfo.Controls.Add(this.txtSalaryGrade);
            this.groupBoxWorkInfo.Controls.Add(this.txtJoinDate);
            this.groupBoxWorkInfo.Controls.Add(this.txtEmployeeType);
            this.groupBoxWorkInfo.Controls.Add(this.txtPosition);
            this.groupBoxWorkInfo.Controls.Add(this.txtDepartment);
            this.groupBoxWorkInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWorkInfo.Location = new System.Drawing.Point(12, 270);
            this.groupBoxWorkInfo.Name = "groupBoxWorkInfo";
            this.groupBoxWorkInfo.Size = new System.Drawing.Size(370, 190);
            this.groupBoxWorkInfo.TabIndex = 3;
            this.groupBoxWorkInfo.TabStop = false;
            this.groupBoxWorkInfo.Text = "Thông tin công việc";
            // 
            // lblSalaryGrade
            // 
            this.lblSalaryGrade.AutoSize = true;
            this.lblSalaryGrade.Location = new System.Drawing.Point(20, 150);
            this.lblSalaryGrade.Name = "lblSalaryGrade";
            this.lblSalaryGrade.Size = new System.Drawing.Size(73, 17);
            this.lblSalaryGrade.TabIndex = 9;
            this.lblSalaryGrade.Text = "Bậc lương:";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(20, 120);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(93, 17);
            this.lblJoinDate.TabIndex = 8;
            this.lblJoinDate.Text = "Ngày vào làm:";
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Location = new System.Drawing.Point(20, 90);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(61, 17);
            this.lblEmployeeType.TabIndex = 7;
            this.lblEmployeeType.Text = "Loại NV:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(20, 60);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 30);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(75, 17);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Phòng ban:";
            // 
            // txtSalaryGrade
            // 
            this.txtSalaryGrade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryGrade.Location = new System.Drawing.Point(120, 147);
            this.txtSalaryGrade.Name = "txtSalaryGrade";
            this.txtSalaryGrade.ReadOnly = true;
            this.txtSalaryGrade.Size = new System.Drawing.Size(220, 25);
            this.txtSalaryGrade.TabIndex = 4;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinDate.Location = new System.Drawing.Point(120, 117);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.ReadOnly = true;
            this.txtJoinDate.Size = new System.Drawing.Size(150, 25);
            this.txtJoinDate.TabIndex = 3;
            // 
            // txtEmployeeType
            // 
            this.txtEmployeeType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeType.Location = new System.Drawing.Point(120, 87);
            this.txtEmployeeType.Name = "txtEmployeeType";
            this.txtEmployeeType.ReadOnly = true;
            this.txtEmployeeType.Size = new System.Drawing.Size(220, 25);
            this.txtEmployeeType.TabIndex = 2;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(120, 57);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(220, 25);
            this.txtPosition.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(120, 27);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(220, 25);
            this.txtDepartment.TabIndex = 0;
            // 
            // groupBoxOtherInfo
            // 
            this.groupBoxOtherInfo.Controls.Add(this.lblBankName);
            this.groupBoxOtherInfo.Controls.Add(this.lblBankAccount);
            this.groupBoxOtherInfo.Controls.Add(this.lblTaxCode);
            this.groupBoxOtherInfo.Controls.Add(this.lblInsuranceNumber);
            this.groupBoxOtherInfo.Controls.Add(this.txtBankName);
            this.groupBoxOtherInfo.Controls.Add(this.txtBankAccount);
            this.groupBoxOtherInfo.Controls.Add(this.txtTaxCode);
            this.groupBoxOtherInfo.Controls.Add(this.txtInsuranceNumber);
            this.groupBoxOtherInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOtherInfo.Location = new System.Drawing.Point(402, 270);
            this.groupBoxOtherInfo.Name = "groupBoxOtherInfo";
            this.groupBoxOtherInfo.Size = new System.Drawing.Size(370, 190);
            this.groupBoxOtherInfo.TabIndex = 4;
            this.groupBoxOtherInfo.TabStop = false;
            this.groupBoxOtherInfo.Text = "Thông tin khác";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(20, 120);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(56, 17);
            this.lblBankName.TabIndex = 7;
            this.lblBankName.Text = "Tên NH:";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(20, 90);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(52, 17);
            this.lblBankAccount.TabIndex = 6;
            this.lblBankAccount.Text = "TK NH:";
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Location = new System.Drawing.Point(20, 60);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(79, 17);
            this.lblTaxCode.TabIndex = 5;
            this.lblTaxCode.Text = "Mã số thuế:";
            // 
            // lblInsuranceNumber
            // 
            this.lblInsuranceNumber.AutoSize = true;
            this.lblInsuranceNumber.Location = new System.Drawing.Point(20, 30);
            this.lblInsuranceNumber.Name = "lblInsuranceNumber";
            this.lblInsuranceNumber.Size = new System.Drawing.Size(74, 17);
            this.lblInsuranceNumber.TabIndex = 4;
            this.lblInsuranceNumber.Text = "Số BHXH:";
            // 
            // txtBankName
            // 
            this.txtBankName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.Location = new System.Drawing.Point(120, 117);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(220, 25);
            this.txtBankName.TabIndex = 3;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAccount.Location = new System.Drawing.Point(120, 87);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.ReadOnly = true;
            this.txtBankAccount.Size = new System.Drawing.Size(220, 25);
            this.txtBankAccount.TabIndex = 2;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxCode.Location = new System.Drawing.Point(120, 57);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.ReadOnly = true;
            this.txtTaxCode.Size = new System.Drawing.Size(220, 25);
            this.txtTaxCode.TabIndex = 1;
            // 
            // txtInsuranceNumber
            // 
            this.txtInsuranceNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsuranceNumber.Location = new System.Drawing.Point(120, 27);
            this.txtInsuranceNumber.Name = "txtInsuranceNumber";
            this.txtInsuranceNumber.ReadOnly = true;
            this.txtInsuranceNumber.Size = new System.Drawing.Size(220, 25);
            this.txtInsuranceNumber.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(351, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 530);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxOtherInfo);
            this.Controls.Add(this.groupBoxWorkInfo);
            this.Controls.Add(this.groupBoxContactInfo);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết nhân viên";
            this.panelHeader.ResumeLayout(false);
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxBasicInfo.PerformLayout();
            this.groupBoxContactInfo.ResumeLayout(false);
            this.groupBoxContactInfo.PerformLayout();
            this.groupBoxWorkInfo.ResumeLayout(false);
            this.groupBoxWorkInfo.PerformLayout();
            this.groupBoxOtherInfo.ResumeLayout(false);
            this.groupBoxOtherInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private GroupBox groupBoxBasicInfo;
        private TextBox txtEmployeeCode;
        private TextBox txtFullName;
        private TextBox txtDateOfBirth;
        private TextBox txtGender;
        private TextBox txtIdentityNumber;
        private GroupBox groupBoxContactInfo;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private GroupBox groupBoxWorkInfo;
        private TextBox txtDepartment;
        private TextBox txtPosition;
        private TextBox txtEmployeeType;
        private TextBox txtJoinDate;
        private TextBox txtSalaryGrade;
        private GroupBox groupBoxOtherInfo;
        private TextBox txtInsuranceNumber;
        private TextBox txtTaxCode;
        private TextBox txtBankAccount;
        private TextBox txtBankName;
        private Button btnClose;
        private Label lblEmployeeCode;
        private Label lblFullName;
        private Label lblDateOfBirth;
        private Label lblGender;
        private Label lblIdentityNumber;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblDepartment;
        private Label lblPosition;
        private Label lblEmployeeType;
        private Label lblJoinDate;
        private Label lblSalaryGrade;
        private Label lblInsuranceNumber;
        private Label lblTaxCode;
        private Label lblBankAccount;
        private Label lblBankName;
    }
}