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
            toolStrip1 = new ToolStrip();
            btnThem = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)grdSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdSP
            // 
            grdSP.AllowUserToAddRows = false;
            grdSP.AllowUserToDeleteRows = false;
            grdSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSP.Location = new Point(1, 160);
            grdSP.Name = "grdSP";
            grdSP.RowHeadersWidth = 51;
            grdSP.RowTemplate.Height = 29;
            grdSP.Size = new Size(1107, 470);
            grdSP.TabIndex = 0;
            grdSP.CellDoubleClick += grdSP_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(357, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(663, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThem });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1108, 27);
            toolStrip1.TabIndex = 4;
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
            // QLSPForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 631);
            Controls.Add(toolStrip1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(grdSP);
            Name = "QLSPForm";
            Text = "QLSP";
            Load += QLSPForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
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
        private ToolStrip toolStrip1;
        private ToolStripButton btnThem;
    }
}