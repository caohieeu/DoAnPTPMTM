namespace QLDonHang
{
    partial class DHStatusForm
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
            cbStatus = new ComboBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(155, 40);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(223, 28);
            cbStatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Status";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(300, 98);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(207, 98);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // DHStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 141);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(cbStatus);
            Name = "DHStatusForm";
            Text = "DHStatusForm";
            Load += DHStatusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}