namespace ThongKeKmean
{
    partial class ThongKeForm
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
            pnlChart = new Panel();
            label1 = new Label();
            btnPhanCum = new Button();
            btnDanhSach = new Button();
            txtCum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtCum).BeginInit();
            SuspendLayout();
            // 
            // pnlChart
            // 
            pnlChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChart.Location = new Point(2, 12);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(652, 512);
            pnlChart.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(684, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Số nhóm: ";
            // 
            // btnPhanCum
            // 
            btnPhanCum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPhanCum.Location = new Point(684, 84);
            btnPhanCum.Name = "btnPhanCum";
            btnPhanCum.Size = new Size(128, 37);
            btnPhanCum.TabIndex = 3;
            btnPhanCum.Text = "Phân cụm";
            btnPhanCum.UseVisualStyleBackColor = true;
            btnPhanCum.Click += btnPhanCum_Click;
            // 
            // btnDanhSach
            // 
            btnDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDanhSach.Location = new Point(684, 147);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.Size = new Size(128, 61);
            btnDanhSach.TabIndex = 4;
            btnDanhSach.Text = "Danh sách khách hàng";
            btnDanhSach.UseVisualStyleBackColor = true;
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // txtCum
            // 
            txtCum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtCum.Location = new Point(684, 35);
            txtCum.Name = "txtCum";
            txtCum.Size = new Size(128, 27);
            txtCum.TabIndex = 5;
            // 
            // ThongKeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 536);
            Controls.Add(txtCum);
            Controls.Add(btnDanhSach);
            Controls.Add(btnPhanCum);
            Controls.Add(label1);
            Controls.Add(pnlChart);
            Name = "ThongKeForm";
            Text = "ThongKeForm";
            ((System.ComponentModel.ISupportInitialize)txtCum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChart;
        private Label label1;
        private Button btnPhanCum;
        private Button btnDanhSach;
        private NumericUpDown txtCum;
    }
}