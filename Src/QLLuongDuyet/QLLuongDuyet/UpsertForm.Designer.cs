namespace QLLuongDuyet
{
    partial class UpsertForm
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
            txtTenLuongDuyet = new TextBox();
            label1 = new Label();
            btnLuu = new Button();
            btnHuy = new Button();
            label2 = new Label();
            txtThuTu = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtThuTu).BeginInit();
            SuspendLayout();
            // 
            // txtTenLuongDuyet
            // 
            txtTenLuongDuyet.Location = new Point(146, 46);
            txtTenLuongDuyet.Name = "txtTenLuongDuyet";
            txtTenLuongDuyet.Size = new Size(251, 27);
            txtTenLuongDuyet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên luồng duyệt";
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.Location = new Point(323, 137);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 29);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.Location = new Point(243, 137);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(74, 29);
            btnHuy.TabIndex = 3;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Thứ tự";
            // 
            // txtThuTu
            // 
            txtThuTu.Location = new Point(146, 84);
            txtThuTu.Name = "txtThuTu";
            txtThuTu.Size = new Size(78, 27);
            txtThuTu.TabIndex = 6;
            // 
            // UpsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 178);
            Controls.Add(txtThuTu);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(label1);
            Controls.Add(txtTenLuongDuyet);
            Name = "UpsertForm";
            Text = "UpsertForm";
            Load += UpsertForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtThuTu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenLuongDuyet;
        private Label label1;
        private Button btnLuu;
        private Button btnHuy;
        private Label label2;
        private NumericUpDown txtThuTu;
    }
}