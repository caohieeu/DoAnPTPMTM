namespace QLLuongDuyet
{
    partial class QLLDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLDForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnThemLD = new ToolStripButton();
            btnSuaLD = new ToolStripButton();
            btnXoaLD = new ToolStripButton();
            panel2 = new Panel();
            toolStrip2 = new ToolStrip();
            toolStripButton6 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            dataGridView2 = new DataGridView();
            bsLD = new BindingSource(components);
            bsUSLD = new BindingSource(components);
            miniToolStrip = new ToolStrip();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUSLD).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(892, 490);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 239);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(886, 212);
            dataGridView1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThemLD, btnSuaLD, btnXoaLD });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(886, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnThemLD
            // 
            btnThemLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnThemLD.Image = (Image)resources.GetObject("btnThemLD.Image");
            btnThemLD.ImageTransparentColor = Color.Magenta;
            btnThemLD.Name = "btnThemLD";
            btnThemLD.Size = new Size(50, 24);
            btnThemLD.Text = "Thêm";
            btnThemLD.Click += btnThemLD_Click;
            // 
            // btnSuaLD
            // 
            btnSuaLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSuaLD.Image = (Image)resources.GetObject("btnSuaLD.Image");
            btnSuaLD.ImageTransparentColor = Color.Magenta;
            btnSuaLD.Name = "btnSuaLD";
            btnSuaLD.Size = new Size(38, 24);
            btnSuaLD.Text = "Sửa";
            btnSuaLD.Click += btnSuaLD_Click;
            // 
            // btnXoaLD
            // 
            btnXoaLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnXoaLD.Image = (Image)resources.GetObject("btnXoaLD.Image");
            btnXoaLD.ImageTransparentColor = Color.Magenta;
            btnXoaLD.Name = "btnXoaLD";
            btnXoaLD.Size = new Size(39, 24);
            btnXoaLD.Text = "Xóa";
            btnXoaLD.Click += btnXoaLD_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(toolStrip2);
            panel2.Controls.Add(dataGridView2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 239);
            panel2.TabIndex = 5;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton6, toolStripButton5, toolStripButton4 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(886, 27);
            toolStrip2.TabIndex = 7;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(50, 24);
            toolStripButton6.Text = "Thêm";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(38, 24);
            toolStripButton5.Text = "Sửa";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(39, 24);
            toolStripButton4.Text = "Xóa";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(883, 206);
            dataGridView2.TabIndex = 4;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(137, 1);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(886, 27);
            miniToolStrip.TabIndex = 7;
            // 
            // QLLDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 490);
            Controls.Add(tableLayoutPanel1);
            Name = "QLLDForm";
            Text = "QLLDForm";
            Load += QLLDForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLD).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUSLD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource bsLD;
        private BindingSource bsUSLD;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnThemLD;
        private ToolStripButton btnSuaLD;
        private ToolStripButton btnXoaLD;
        private Panel panel2;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private DataGridView dataGridView2;
        private ToolStrip miniToolStrip;
    }
}