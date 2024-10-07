namespace QuanLySanPham
{
    partial class ManageForm
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
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label10 = new Label();
            dateTimePickerNgayBan = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            comboBoxBrandID = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtUrl = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            dateTimePickerNgayTao = new DateTimePicker();
            comboBoxCategoryID = new ComboBox();
            txtId = new TextBox();
            label11 = new Label();
            btnUpload = new Button();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Location = new Point(637, 513);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 42);
            btnSua.TabIndex = 47;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(777, 513);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 42);
            btnXoa.TabIndex = 46;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(494, 513);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 42);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(521, 446);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 44;
            label10.Text = "Ngày bán";
            // 
            // dateTimePickerNgayBan
            // 
            dateTimePickerNgayBan.Location = new Point(615, 446);
            dateTimePickerNgayBan.Name = "dateTimePickerNgayBan";
            dateTimePickerNgayBan.Size = new Size(258, 27);
            dateTimePickerNgayBan.TabIndex = 43;
            dateTimePickerNgayBan.Value = new DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 441);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 42;
            label9.Text = "Ngày tạo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 285);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 41;
            label8.Text = "Số lượng";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(615, 285);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(258, 27);
            txtStock.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 364);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 39;
            label7.Text = "BrandId";
            // 
            // comboBoxBrandID
            // 
            comboBoxBrandID.FormattingEnabled = true;
            comboBoxBrandID.Location = new Point(615, 361);
            comboBoxBrandID.Name = "comboBoxBrandID";
            comboBoxBrandID.Size = new Size(258, 28);
            comboBoxBrandID.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 364);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 37;
            label6.Text = "CategoryID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 282);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 36;
            label5.Text = "Url";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(158, 282);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(254, 27);
            txtUrl.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 212);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 34;
            label4.Text = "Giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(154, 205);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(258, 27);
            txtPrice.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 212);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 32;
            label3.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(615, 205);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(258, 27);
            txtDescription.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 133);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 30;
            label2.Text = "Tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(615, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 130);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 28;
            label1.Text = "Id";
            // 
            // dateTimePickerNgayTao
            // 
            dateTimePickerNgayTao.Location = new Point(154, 441);
            dateTimePickerNgayTao.Name = "dateTimePickerNgayTao";
            dateTimePickerNgayTao.Size = new Size(258, 27);
            dateTimePickerNgayTao.TabIndex = 27;
            dateTimePickerNgayTao.Value = new DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // comboBoxCategoryID
            // 
            comboBoxCategoryID.FormattingEnabled = true;
            comboBoxCategoryID.Location = new Point(156, 356);
            comboBoxCategoryID.Name = "comboBoxCategoryID";
            comboBoxCategoryID.Size = new Size(256, 28);
            comboBoxCategoryID.TabIndex = 26;
            // 
            // txtId
            // 
            txtId.Location = new Point(156, 130);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 27);
            txtId.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(343, 39);
            label11.Name = "label11";
            label11.Size = new Size(262, 38);
            label11.TabIndex = 48;
            label11.Text = "Quản Lý Sản Phẩm";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(343, 282);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(69, 28);
            btnUpload.TabIndex = 49;
            btnUpload.Text = "File";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 587);
            Controls.Add(btnUpload);
            Controls.Add(label11);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label10);
            Controls.Add(dateTimePickerNgayBan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtStock);
            Controls.Add(label7);
            Controls.Add(comboBoxBrandID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUrl);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dateTimePickerNgayTao);
            Controls.Add(comboBoxCategoryID);
            Controls.Add(txtId);
            Name = "ManageForm";
            Text = "ManageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label10;
        private DateTimePicker dateTimePickerNgayBan;
        private Label label9;
        private Label label8;
        private TextBox txtStock;
        private Label label7;
        private ComboBox comboBoxBrandID;
        private Label label6;
        private Label label5;
        private TextBox txtUrl;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private DateTimePicker dateTimePickerNgayTao;
        private ComboBox comboBoxCategoryID;
        private TextBox txtId;
        private Label label11;
        private Button btnUpload;
    }
}