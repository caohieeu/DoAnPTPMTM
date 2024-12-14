namespace QuanLyNhapHang
{
    partial class QuanLyNhapHangForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhapHangForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            gridMaster = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            editBtn = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            gridChild = new DataGridView();
            bsMaster = new BindingSource(components);
            bsDetail = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMaster).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDetail).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(804, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 219);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(gridMaster);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 193);
            panel1.TabIndex = 1;
            // 
            // gridMaster
            // 
            gridMaster.AllowUserToAddRows = false;
            gridMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMaster.Dock = DockStyle.Fill;
            gridMaster.Location = new Point(0, 27);
            gridMaster.Name = "gridMaster";
            gridMaster.RowHeadersWidth = 51;
            gridMaster.RowTemplate.Height = 29;
            gridMaster.Size = new Size(792, 166);
            gridMaster.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, editBtn, toolStripButton1, btnUpdate });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(792, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 24);
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // editBtn
            // 
            editBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.ImageTransparentColor = Color.Magenta;
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(38, 24);
            editBtn.Text = "Sửa";
            editBtn.Click += editBtn_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(39, 24);
            toolStripButton1.Text = "Xóa";
            // 
            // btnUpdate
            // 
            btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 24);
            btnUpdate.Text = "Xuất hàng";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(798, 219);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết nhập hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(gridChild);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 193);
            panel2.TabIndex = 2;
            // 
            // gridChild
            // 
            gridChild.AllowUserToAddRows = false;
            gridChild.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridChild.Dock = DockStyle.Fill;
            gridChild.Location = new Point(0, 0);
            gridChild.Name = "gridChild";
            gridChild.RowHeadersWidth = 51;
            gridChild.RowTemplate.Height = 29;
            gridChild.Size = new Size(792, 193);
            gridChild.TabIndex = 2;
            // 
            // QuanLyNhapHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "QuanLyNhapHangForm";
            Text = "QuanLyNhapHangForm";
            Load += QuanLyNhapHangForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridMaster).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView gridMaster;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton editBtn;
        private ToolStripButton btnUpdate;
        private GroupBox groupBox2;
        private Panel panel2;
        private DataGridView gridChild;
        private BindingSource bsMaster;
        private BindingSource bsDetail;
        private ToolStripButton toolStripButton1;
    }
}