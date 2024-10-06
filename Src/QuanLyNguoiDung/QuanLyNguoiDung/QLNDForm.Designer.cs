namespace QuanLyNguoiDung
{
    partial class QLNDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNDForm));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            editBtn = new ToolStripButton();
            btnDelete = new ToolStripButton();
            bsGrid = new BindingSource(components);
            panel1 = new Panel();
            grdUser = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUser).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, editBtn, btnDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
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
            btnAdd.Click += BtnAdd_Click;
            // 
            // editBtn
            // 
            editBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.ImageTransparentColor = Color.Magenta;
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(38, 24);
            editBtn.Text = "Sửa";
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(39, 24);
            btnDelete.Text = "Xóa";
            // 
            // panel1
            // 
            panel1.Controls.Add(grdUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 423);
            panel1.TabIndex = 1;
            // 
            // grdUser
            // 
            grdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUser.Dock = DockStyle.Fill;
            grdUser.Location = new Point(0, 0);
            grdUser.Name = "grdUser";
            grdUser.RowHeadersWidth = 51;
            grdUser.RowTemplate.Height = 29;
            grdUser.Size = new Size(800, 423);
            grdUser.TabIndex = 0;
            // 
            // QLNDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "QLNDForm";
            Text = "QLNDForm";
            Load += QLNDForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsGrid).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton editBtn;
        private ToolStripButton btnDelete;
        private BindingSource bsGrid;
        private Panel panel1;
        private DataGridView grdUser;
    }
}