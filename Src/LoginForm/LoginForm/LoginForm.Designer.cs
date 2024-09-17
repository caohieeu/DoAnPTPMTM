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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            txtPassWord = new TextBox();
            cbShow = new CheckBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(390, 568);
            Controls.Add(btnLogin);
            Controls.Add(cbShow);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(txtPassWord);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtUserName);
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private TextBox txtPassWord;
        private CheckBox cbShow;
        private Button btnLogin;
    }
}
