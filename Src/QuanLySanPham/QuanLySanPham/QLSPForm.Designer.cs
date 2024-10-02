namespace QuanLySanPham
{
    partial class QLSPForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSPForm));
            grdSP = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnThem = new ToolStripButton();
            btnSua = new ToolStripButton();
            btnXoa = new ToolStripButton();
            bdSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)grdSP).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            SuspendLayout();
            // 
            // grdSP
            // 
            grdSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSP.Location = new Point(0, 37);
            grdSP.Name = "grdSP";
            grdSP.RowHeadersWidth = 51;
            grdSP.RowTemplate.Height = 29;
            grdSP.Size = new Size(1120, 414);
            grdSP.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThem, btnSua, btnXoa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1120, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            btnThem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageTransparentColor = Color.Magenta;
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(50, 24);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(38, 24);
            btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(39, 24);
            btnXoa.Text = "Xóa";
            // 
            // QLSPForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 450);
            Controls.Add(toolStrip1);
            Controls.Add(grdSP);
            Name = "QLSPForm";
            Text = "QLSP";
            Load += QLSPForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdSP).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSP;
        private ToolStrip toolStrip1;
        private BindingSource bdSource;
        private ToolStripButton btnThem;
        private ToolStripButton btnSua;
        private ToolStripButton btnXoa;
    }
}