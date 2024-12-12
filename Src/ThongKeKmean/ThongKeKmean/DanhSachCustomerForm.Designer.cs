namespace ThongKeKmean
{
    partial class DanhSachCustomerForm
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
            dgrvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgrvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 22);
            label1.Name = "label1";
            label1.Size = new Size(575, 41);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Khách Hàng Được Phân Cụm";
            // 
            // dgrvCustomer
            // 
            dgrvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvCustomer.Location = new Point(3, 112);
            dgrvCustomer.Name = "dgrvCustomer";
            dgrvCustomer.RowHeadersWidth = 51;
            dgrvCustomer.RowTemplate.Height = 29;
            dgrvCustomer.Size = new Size(1106, 440);
            dgrvCustomer.TabIndex = 1;
            // 
            // DanhSachCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 554);
            Controls.Add(dgrvCustomer);
            Controls.Add(label1);
            Name = "DanhSachCustomerForm";
            Text = "DanhSachCustomerForm";
            ((System.ComponentModel.ISupportInitialize)dgrvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgrvCustomer;
    }
}