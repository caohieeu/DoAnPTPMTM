namespace QuanLyRoleMenu
{
    partial class QLRMForm
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
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            grViewRole = new DataGridView();
            grViewMenu = new DataGridView();
            label1 = new Label();
            btnThem = new Button();
            lblMenu = new Label();
            btnRoleMenu = new Button();
            bntSua = new Button();
            btnXoa = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grViewRole).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grViewMenu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(410, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Quản Lý Quyền Menu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.Controls.Add(grViewRole, 0, 0);
            tableLayoutPanel1.Controls.Add(grViewMenu, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 204);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1108, 427);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // grViewRole
            // 
            grViewRole.AllowUserToAddRows = false;
            grViewRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grViewRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grViewRole.Dock = DockStyle.Fill;
            grViewRole.Location = new Point(3, 3);
            grViewRole.Name = "grViewRole";
            grViewRole.RowHeadersWidth = 51;
            grViewRole.RowTemplate.Height = 29;
            grViewRole.Size = new Size(525, 421);
            grViewRole.TabIndex = 0;
            grViewRole.CellClick += grViewRole_CellClick;
            // 
            // grViewMenu
            // 
            grViewMenu.AllowUserToAddRows = false;
            grViewMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grViewMenu.Dock = DockStyle.Fill;
            grViewMenu.Location = new Point(578, 3);
            grViewMenu.Name = "grViewMenu";
            grViewMenu.RowHeadersWidth = 51;
            grViewMenu.RowTemplate.Height = 29;
            grViewMenu.Size = new Size(527, 421);
            grViewMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 123);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 4;
            label1.Text = "Bảng quyền người dùng";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 166);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 32);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(578, 123);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(101, 23);
            lblMenu.TabIndex = 8;
            lblMenu.Text = "Bảng menu";
            // 
            // btnRoleMenu
            // 
            btnRoleMenu.Location = new Point(294, 166);
            btnRoleMenu.Name = "btnRoleMenu";
            btnRoleMenu.Size = new Size(146, 32);
            btnRoleMenu.TabIndex = 9;
            btnRoleMenu.Text = "Thêm Quyền Menu";
            btnRoleMenu.UseVisualStyleBackColor = true;
            btnRoleMenu.Click += btnRoleMenu_Click;
            // 
            // bntSua
            // 
            bntSua.Location = new Point(100, 166);
            bntSua.Name = "bntSua";
            bntSua.Size = new Size(91, 32);
            bntSua.TabIndex = 10;
            bntSua.Text = "Sửa";
            bntSua.UseVisualStyleBackColor = true;
            bntSua.Click += bntSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(197, 166);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 32);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // QLRMForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 631);
            Controls.Add(btnXoa);
            Controls.Add(bntSua);
            Controls.Add(btnRoleMenu);
            Controls.Add(lblMenu);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTitle);
            Name = "QLRMForm";
            Text = "QLRMForm";
            Resize += QLRMForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grViewRole).EndInit();
            ((System.ComponentModel.ISupportInitialize)grViewMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView grViewRole;
        private DataGridView grViewMenu;
        private Label label1;
        private Button btnThem;
        private Label lblMenu;
        private Button btnRoleMenu;
        private Button bntSua;
        private Button btnXoa;
    }
}