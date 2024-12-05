namespace QLLuongDuyet
{
    partial class RLDUpsertForm
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
            btnHuy = new Button();
            btnLuu = new Button();
            txtRole = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHuy.Location = new Point(244, 61);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(74, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.Location = new Point(324, 61);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtRole
            // 
            txtRole.FormattingEnabled = true;
            txtRole.Location = new Point(164, 12);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(229, 28);
            txtRole.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Role";
            // 
            // RLDUpsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 102);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(txtRole);
            Controls.Add(label1);
            Name = "RLDUpsertForm";
            Text = "RLDUpsertForm";
            Load += RLDUpsertForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Button btnLuu;
        private ComboBox txtRole;
        private Label label1;
    }
}