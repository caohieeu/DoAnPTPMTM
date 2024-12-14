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
            btnThem = new Button();
            label8 = new Label();
            label7 = new Label();
            comboBoxBrandID = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtUrl = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label11 = new Label();
            btnUpload = new Button();
            comboBoxCategoryID = new ComboBox();
            ptrBoxProduct = new PictureBox();
            label9 = new Label();
            cbbProviderId = new ComboBox();
            txtDescription = new RichTextBox();
            txtStock = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptrBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSua.Location = new Point(664, 512);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 45);
            btnSua.TabIndex = 47;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.Location = new Point(331, 512);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 45);
            btnThem.TabIndex = 45;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 110);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 41;
            label8.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(404, 154);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 39;
            label7.Text = "Thương hiệu";
            // 
            // comboBoxBrandID
            // 
            comboBoxBrandID.FormattingEnabled = true;
            comboBoxBrandID.Location = new Point(513, 150);
            comboBoxBrandID.Name = "comboBoxBrandID";
            comboBoxBrandID.Size = new Size(258, 28);
            comboBoxBrandID.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 194);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 37;
            label6.Text = "Loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 150);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 36;
            label5.Text = "Ảnh";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(125, 147);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(254, 27);
            txtUrl.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 106);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 34;
            label4.Text = "Giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(125, 103);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(258, 27);
            txtPrice.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 299);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 32;
            label3.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 62);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 30;
            label2.Text = "Tên";
            // 
            // txtName
            // 
            txtName.Location = new Point(513, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 27);
            txtName.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 62);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 28;
            label1.Text = "Mã sản phẩm";
            // 
            // txtId
            // 
            txtId.Location = new Point(125, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(256, 27);
            txtId.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(262, 9);
            label11.Name = "label11";
            label11.Size = new Size(262, 38);
            label11.TabIndex = 48;
            label11.Text = "Quản Lý Sản Phẩm";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(312, 147);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(69, 28);
            btnUpload.TabIndex = 49;
            btnUpload.Text = "File";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // comboBoxCategoryID
            // 
            comboBoxCategoryID.FormattingEnabled = true;
            comboBoxCategoryID.Location = new Point(125, 191);
            comboBoxCategoryID.Name = "comboBoxCategoryID";
            comboBoxCategoryID.Size = new Size(256, 28);
            comboBoxCategoryID.TabIndex = 26;
            // 
            // ptrBoxProduct
            // 
            ptrBoxProduct.Location = new Point(404, 194);
            ptrBoxProduct.Name = "ptrBoxProduct";
            ptrBoxProduct.Size = new Size(367, 297);
            ptrBoxProduct.TabIndex = 50;
            ptrBoxProduct.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 243);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 52;
            label9.Text = "Nhà cung cấp";
            // 
            // cbbProviderId
            // 
            cbbProviderId.FormattingEnabled = true;
            cbbProviderId.Location = new Point(125, 240);
            cbbProviderId.Name = "cbbProviderId";
            cbbProviderId.Size = new Size(256, 28);
            cbbProviderId.TabIndex = 51;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(119, 299);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(260, 192);
            txtDescription.TabIndex = 53;
            txtDescription.Text = "";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(513, 108);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(258, 27);
            txtStock.TabIndex = 54;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(12, 512);
            button1.Name = "button1";
            button1.Size = new Size(161, 45);
            button1.TabIndex = 55;
            button1.Text = "Lịch sử xuất hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 569);
            Controls.Add(button1);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(label9);
            Controls.Add(cbbProviderId);
            Controls.Add(ptrBoxProduct);
            Controls.Add(btnUpload);
            Controls.Add(label11);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxBrandID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUrl);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(comboBoxCategoryID);
            Controls.Add(txtId);
            Name = "ManageForm";
            Text = "ManageForm";
            Load += ManageForm_Load;
            ((System.ComponentModel.ISupportInitialize)ptrBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSua;
        private Button btnThem;
        private Label label8;
        private Label label7;
        private ComboBox comboBoxBrandID;
        private Label label6;
        private Label label5;
        private TextBox txtUrl;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtId;
        private Label label11;
        private Button btnUpload;
        private ComboBox comboBoxCategoryID;
        private PictureBox ptrBoxProduct;
        private Label label9;
        private ComboBox cbbProviderId;
        private RichTextBox txtDescription;
        private NumericUpDown txtStock;
        private Button button1;
    }
}