namespace QuanLyNguoiDung
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            btnAddNew = new Button();
            cbRole = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnImg = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtImage = new TextBox();
            txtPhone = new TextBox();
            label9 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(82, 140);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(263, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(452, 140);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(263, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(452, 209);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(263, 27);
            txtAddress.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(254, 38);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Người Dùng";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(370, 524);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 48);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Thên";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(82, 287);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(263, 28);
            cbRole.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(452, 288);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(263, 27);
            dtpBirthday.TabIndex = 4;
            // 
            // btnImg
            // 
            btnImg.Location = new Point(646, 359);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(69, 29);
            btnImg.TabIndex = 5;
            btnImg.Text = "Upload";
            btnImg.UseVisualStyleBackColor = true;
            btnImg.Click += btnImg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 117);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 6;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 186);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 261);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Quyền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 338);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 117);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Họ Tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 186);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 261);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(452, 361);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(263, 27);
            txtImage.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(452, 436);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(263, 27);
            txtPhone.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(452, 413);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 6;
            label9.Text = "Số điện thoại";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(497, 524);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 48);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(621, 524);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 48);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(452, 338);
            label10.Name = "label10";
            label10.Size = new Size(35, 20);
            label10.TabIndex = 9;
            label10.Text = "Ảnh";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 600);
            Controls.Add(label10);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnImg);
            Controls.Add(dtpBirthday);
            Controls.Add(cbRole);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Controls.Add(txtImage);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtUserName);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox textBox5;
        private TextBox txtAddress;
        private TextBox textBox8;
        private Label label1;
        private Button btnAddNew;
        private ComboBox cbRole;
        private DateTimePicker dtpBirthday;
        private Button btnImg;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtImage;
        private TextBox txtPhone;
        private Label label9;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label10;
    }
}