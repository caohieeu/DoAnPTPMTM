namespace QuanLyRoleMenu
{
    partial class ManagerRole
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
            label1 = new Label();
            btnLuu = new Button();
            label2 = new Label();
            lblTitle = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 80);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(150, 175);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 129);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(169, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 28);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "title";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(87, 77);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(272, 27);
            txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(87, 122);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(272, 27);
            txtTen.TabIndex = 5;
            // 
            // ManagerRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 226);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Controls.Add(label1);
            Name = "ManagerRole";
            Text = "ManagerRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLuu;
        private Label label2;
        private Label lblTitle;
        private TextBox txtMa;
        private TextBox txtTen;
    }
}