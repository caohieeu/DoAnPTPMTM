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
            grdSP = new DataGridView();
            bdSource = new BindingSource(components);
            txtId = new TextBox();
            comboBoxCategoryID = new ComboBox();
            dateTimePickerNgayTao = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtUrl = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxBrandID = new ComboBox();
            label8 = new Label();
            txtStock = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dateTimePickerNgayBan = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            ((System.ComponentModel.ISupportInitialize)grdSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            SuspendLayout();
            // 
            // grdSP
            // 
            grdSP.AllowUserToAddRows = false;
            grdSP.AllowUserToDeleteRows = false;
            grdSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSP.Location = new Point(1, 315);
            grdSP.Name = "grdSP";
            grdSP.RowHeadersWidth = 51;
            grdSP.RowTemplate.Height = 29;
            grdSP.Size = new Size(932, 315);
            grdSP.TabIndex = 0;
            grdSP.CellClick += grdSP_CellClick;
            grdSP.CellContentClick += grdSP_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 27);
            txtId.TabIndex = 1;
            // 
            // comboBoxCategoryID
            // 
            comboBoxCategoryID.FormattingEnabled = true;
            comboBoxCategoryID.Location = new Point(127, 152);
            comboBoxCategoryID.Name = "comboBoxCategoryID";
            comboBoxCategoryID.Size = new Size(179, 28);
            comboBoxCategoryID.TabIndex = 2;
            // 
            // dateTimePickerNgayTao
            // 
            dateTimePickerNgayTao.Location = new Point(127, 214);
            dateTimePickerNgayTao.Name = "dateTimePickerNgayTao";
            dateTimePickerNgayTao.Size = new Size(181, 27);
            dateTimePickerNgayTao.TabIndex = 3;
            dateTimePickerNgayTao.Value = new DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 38);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(418, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 27);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 38);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(718, 35);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(179, 27);
            txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 97);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 10;
            label4.Text = "Giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(127, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(179, 27);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 97);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 12;
            label5.Text = "Url";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(418, 97);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(179, 27);
            txtUrl.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 156);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "CategoryID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 155);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 15;
            label7.Text = "BrandId";
            // 
            // comboBoxBrandID
            // 
            comboBoxBrandID.FormattingEnabled = true;
            comboBoxBrandID.Location = new Point(418, 153);
            comboBoxBrandID.Name = "comboBoxBrandID";
            comboBoxBrandID.Size = new Size(179, 28);
            comboBoxBrandID.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(631, 97);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 17;
            label8.Text = "Số lượng";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(718, 97);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(179, 27);
            txtStock.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 219);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 18;
            label9.Text = "Ngày tạo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(337, 219);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 20;
            label10.Text = "Ngày bán";
            // 
            // dateTimePickerNgayBan
            // 
            dateTimePickerNgayBan.Location = new Point(416, 214);
            dateTimePickerNgayBan.Name = "dateTimePickerNgayBan";
            dateTimePickerNgayBan.Size = new Size(181, 27);
            dateTimePickerNgayBan.TabIndex = 19;
            dateTimePickerNgayBan.Value = new DateTime(2024, 10, 25, 23, 59, 59, 0);
            // 
            // btnThem
            // 
            btnThem.Location = new Point(748, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 42);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(748, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 42);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(748, 194);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 42);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // QLSPForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 631);
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
            Controls.Add(grdSP);
            Name = "QLSPForm";
            Text = "QLSP";
            Load += QLSPForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdSP;
        private BindingSource bdSource;
        private TextBox txtId;
        private ComboBox comboBoxCategoryID;
        private DateTimePicker dateTimePickerNgayTao;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtUrl;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxBrandID;
        private Label label8;
        private TextBox txtStock;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePickerNgayBan;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}