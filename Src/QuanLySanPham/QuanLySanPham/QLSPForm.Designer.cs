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
            bdSource = new BindingSource(components);
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblHeaderl = new Label();
            label2 = new Label();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnThem = new ToolStripButton();
            btnXoa = new ToolStripButton();
            btnSua = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdSP
            // 
            grdSP.AllowUserToAddRows = false;
            grdSP.AllowUserToDeleteRows = false;
            grdSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSP.Location = new Point(-3, 30);
            grdSP.Name = "grdSP";
            grdSP.RowHeadersWidth = 51;
            grdSP.RowTemplate.Height = 29;
            grdSP.Size = new Size(1006, 298);
            grdSP.TabIndex = 0;
            grdSP.CellDoubleClick += grdSP_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(165, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(704, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(875, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblHeaderl
            // 
            lblHeaderl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderl.AutoSize = true;
            lblHeaderl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeaderl.Location = new Point(234, 9);
            lblHeaderl.Name = "lblHeaderl";
            lblHeaderl.Size = new Size(352, 46);
            lblHeaderl.TabIndex = 5;
            lblHeaderl.Text = "Danh Sách Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 64);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 6;
            label2.Text = "Tìm Sản Phẩm";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(grdSP);
            panel1.Location = new Point(1, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 332);
            panel1.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThem, btnXoa, btnSua });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1006, 27);
            toolStrip1.TabIndex = 5;
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
            btnThem.Click += btnThem_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(39, 24);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageTransparentColor = Color.Magenta;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(38, 24);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // QLSPForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 451);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lblHeaderl);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "QLSPForm";
            Text = "QLSP";
            Load += QLSPForm_Load;
            Resize += QLSPForm_Resize;
            ((System.ComponentModel.ISupportInitialize)grdSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSP;
        private BindingSource bdSource;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblHeaderl;
        private Label label2;
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnThem;
        private ToolStripButton btnXoa;
        private ToolStripButton btnSua;
    }
}