namespace LoginForm
{
    partial class LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserName = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtPassWord = new TextBox();
            cbShow = new CheckBox();
            btnLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Silver;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.ControlText;
            txtUserName.Location = new Point(43, 253);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(315, 35);
            txtUserName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(43, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 4);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 218);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 3;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 327);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 7;
            label2.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(43, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 4);
            panel2.TabIndex = 6;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.Silver;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.ForeColor = SystemColors.ControlText;
            txtPassWord.Location = new Point(43, 362);
            txtPassWord.Multiline = true;
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(315, 35);
            txtPassWord.TabIndex = 5;
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.Location = new Point(43, 430);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(148, 24);
            cbShow.TabIndex = 9;
            cbShow.Text = "Hiển thị mật khẩu";
            cbShow.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Location = new Point(122, 513);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 51);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(87, 87);
            label3.Name = "label3";
            label3.Size = new Size(217, 39);
            label3.TabIndex = 11;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(390, 642);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(cbShow);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(txtPassWord);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtUserName);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox txtPassWord;
        private CheckBox cbShow;
        private Button btnLogin;
        private Label label3;
    }
}
