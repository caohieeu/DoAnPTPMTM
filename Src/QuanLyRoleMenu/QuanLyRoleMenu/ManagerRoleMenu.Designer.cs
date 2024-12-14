namespace QuanLyRoleMenu
{
    partial class ManagerRoleMenu
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
            label1 = new Label();
            grViewRoleMenu = new DataGridView();
            label2 = new Label();
            txtRole = new TextBox();
            label3 = new Label();
            cbbMenu = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)grViewRoleMenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 21);
            label1.Name = "label1";
            label1.Size = new Size(300, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Quyền Menu";
            // 
            // grViewRoleMenu
            // 
            grViewRoleMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grViewRoleMenu.Location = new Point(12, 218);
            grViewRoleMenu.Name = "grViewRoleMenu";
            grViewRoleMenu.RowHeadersWidth = 51;
            grViewRoleMenu.RowTemplate.Height = 29;
            grViewRoleMenu.Size = new Size(776, 277);
            grViewRoleMenu.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Quyền";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(111, 92);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(283, 27);
            txtRole.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Menu";
            // 
            // cbbMenu
            // 
            cbbMenu.FormattingEnabled = true;
            cbbMenu.Location = new Point(111, 146);
            cbbMenu.Name = "cbbMenu";
            cbbMenu.Size = new Size(283, 28);
            cbbMenu.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(435, 108);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 38);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(554, 108);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 38);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(673, 108);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 38);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // ManagerRoleMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 507);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cbbMenu);
            Controls.Add(label3);
            Controls.Add(txtRole);
            Controls.Add(label2);
            Controls.Add(grViewRoleMenu);
            Controls.Add(label1);
            Name = "ManagerRoleMenu";
            Text = "ManagerRoleMenu";
            ((System.ComponentModel.ISupportInitialize)grViewRoleMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView grViewRoleMenu;
        private Label label2;
        private TextBox txtRole;
        private Label label3;
        private ComboBox cbbMenu;
        private Button btnThem;
        private Button btnXoa;
        private Button btnLuu;
    }
}