namespace QuanLyHoaDon
{
    partial class QLHDForm
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
            grdHoaDon = new DataGridView();
            txtTim = new TextBox();
            label1 = new Label();
            lblHeader = new Label();
            btnTim = new Button();
            ((System.ComponentModel.ISupportInitialize)grdHoaDon).BeginInit();
            SuspendLayout();
            // 
            // grdHoaDon
            // 
            grdHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdHoaDon.Location = new Point(1, 174);
            grdHoaDon.Name = "grdHoaDon";
            grdHoaDon.RowHeadersWidth = 51;
            grdHoaDon.RowTemplate.Height = 29;
            grdHoaDon.Size = new Size(1089, 398);
            grdHoaDon.TabIndex = 0;
            grdHoaDon.CellDoubleClick += grdHoaDon_CellDoubleClick;
            // 
            // txtTim
            // 
            txtTim.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTim.Location = new Point(400, 112);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(382, 27);
            txtTim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 115);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(400, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(336, 46);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Danh Sách Hóa Đơn";
            lblHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.Location = new Point(688, 110);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // QLHDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 573);
            Controls.Add(btnTim);
            Controls.Add(lblHeader);
            Controls.Add(label1);
            Controls.Add(txtTim);
            Controls.Add(grdHoaDon);
            Name = "QLHDForm";
            Text = "QLHDForm";
            Load += QLHDForm_Load;
            Resize += QLHDForm_Resize;
            ((System.ComponentModel.ISupportInitialize)grdHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdHoaDon;
        private TextBox txtTim;
        private Label label1;
        private Label lblHeader;
        private Button btnTim;
    }
}