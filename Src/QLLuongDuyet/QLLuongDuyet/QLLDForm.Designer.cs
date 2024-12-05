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
            bsLD = new BindingSource(components);
            bsUSLD = new BindingSource(components);
            miniToolStrip = new ToolStrip();
            bsRLD = new BindingSource(components);
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnThemLD = new ToolStripButton();
            btnSuaLD = new ToolStripButton();
            btnXoaLD = new ToolStripButton();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            toolStrip2 = new ToolStrip();
            toolStripButton6 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            groupBox4 = new GroupBox();
            panel3 = new Panel();
            dataGridView3 = new DataGridView();
            toolStrip3 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bsLD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUSLD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRLD).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            toolStrip2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            toolStrip3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(886, 239);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Browse stream list";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 213);
            panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(880, 186);
            dataGridView1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnThemLD, btnSuaLD, btnXoaLD });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(880, 27);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnThemLD
            // 
            btnThemLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnThemLD.Image = (Image)resources.GetObject("btnThemLD.Image");
            btnThemLD.ImageTransparentColor = Color.Magenta;
            btnThemLD.Name = "btnThemLD";
            btnThemLD.Size = new Size(41, 24);
            btnThemLD.Text = "Add";
            btnThemLD.Click += btnThemLD_Click;
            // 
            // btnSuaLD
            // 
            btnSuaLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSuaLD.Image = (Image)resources.GetObject("btnSuaLD.Image");
            btnSuaLD.ImageTransparentColor = Color.Magenta;
            btnSuaLD.Name = "btnSuaLD";
            btnSuaLD.Size = new Size(62, 24);
            btnSuaLD.Text = "Update";
            btnSuaLD.Click += btnSuaLD_Click;
            // 
            // btnXoaLD
            // 
            btnXoaLD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnXoaLD.Image = (Image)resources.GetObject("btnXoaLD.Image");
            btnXoaLD.ImageTransparentColor = Color.Magenta;
            btnXoaLD.Name = "btnXoaLD";
            btnXoaLD.Size = new Size(57, 24);
            btnXoaLD.Text = "Delete";
            btnXoaLD.Click += btnXoaLD_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 239);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(886, 239);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(437, 233);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "User list";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(toolStrip2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 207);
            panel4.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 27);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(431, 180);
            dataGridView2.TabIndex = 4;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton6, toolStripButton5, toolStripButton4 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(431, 27);
            toolStrip2.TabIndex = 8;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(41, 24);
            toolStripButton6.Text = "Add";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(62, 24);
            toolStripButton5.Text = "Update";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(57, 24);
            toolStripButton4.Text = "Delete";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel3);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(446, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(437, 233);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Role list";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView3);
            panel3.Controls.Add(toolStrip3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 207);
            panel3.TabIndex = 6;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 27);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(431, 180);
            dataGridView3.TabIndex = 10;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(431, 27);
            toolStrip3.TabIndex = 9;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(41, 24);
            toolStripButton1.Text = "Add";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(62, 24);
            toolStripButton2.Text = "Update";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(57, 24);
            toolStripButton3.Text = "Delete";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(892, 490);
            tableLayoutPanel1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)bsLD).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUSLD).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRLD).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bsLD;
        private BindingSource bsUSLD;
        private ToolStrip miniToolStrip;
        private BindingSource bsRLD;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnThemLD;
        private ToolStripButton btnSuaLD;
        private ToolStripButton btnXoaLD;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private Panel panel4;
        private DataGridView dataGridView2;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private GroupBox groupBox4;
        private Panel panel3;
        private DataGridView dataGridView3;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}