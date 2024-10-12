namespace QuanLyHoaDon
{
    partial class XuatHDForm
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
            grdDetailOrder = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lblIdOder = new Label();
            lblCus = new Label();
            label5 = new Label();
            label7 = new Label();
            lblOderStatus = new Label();
            label9 = new Label();
            lblPayMethod = new Label();
            lblDeliver = new Label();
            label13 = new Label();
            lblAdd = new Label();
            label15 = new Label();
            lblOderAt = new Label();
            label17 = new Label();
            btnDong = new Button();
            btnXuatHD = new Button();
            txtThanhTien = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdDetailOrder).BeginInit();
            SuspendLayout();
            // 
            // grdDetailOrder
            // 
            grdDetailOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdDetailOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDetailOrder.Location = new Point(2, 285);
            grdDetailOrder.Name = "grdDetailOrder";
            grdDetailOrder.RowHeadersWidth = 51;
            grdDetailOrder.RowTemplate.Height = 29;
            grdDetailOrder.Size = new Size(828, 310);
            grdDetailOrder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(275, 38);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn:";
            // 
            // lblIdOder
            // 
            lblIdOder.AutoSize = true;
            lblIdOder.Location = new Point(170, 90);
            lblIdOder.Name = "lblIdOder";
            lblIdOder.Size = new Size(33, 20);
            lblIdOder.TabIndex = 3;
            lblIdOder.Text = "null";
            // 
            // lblCus
            // 
            lblCus.AutoSize = true;
            lblCus.Location = new Point(170, 137);
            lblCus.Name = "lblCus";
            lblCus.Size = new Size(33, 20);
            lblCus.TabIndex = 5;
            lblCus.Text = "null";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 137);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 182);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ :";
            // 
            // lblOderStatus
            // 
            lblOderStatus.AutoSize = true;
            lblOderStatus.Location = new Point(615, 90);
            lblOderStatus.Name = "lblOderStatus";
            lblOderStatus.Size = new Size(33, 20);
            lblOderStatus.TabIndex = 9;
            lblOderStatus.Text = "null";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 90);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 8;
            label9.Text = "Trạng thái hóa đơn:";
            // 
            // lblPayMethod
            // 
            lblPayMethod.AutoSize = true;
            lblPayMethod.Location = new Point(615, 137);
            lblPayMethod.Name = "lblPayMethod";
            lblPayMethod.Size = new Size(33, 20);
            lblPayMethod.TabIndex = 11;
            lblPayMethod.Text = "null";
            // 
            // lblDeliver
            // 
            lblDeliver.AutoSize = true;
            lblDeliver.Location = new Point(615, 182);
            lblDeliver.Name = "lblDeliver";
            lblDeliver.Size = new Size(33, 20);
            lblDeliver.TabIndex = 13;
            lblDeliver.Text = "null";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(424, 182);
            label13.Name = "label13";
            label13.Size = new Size(150, 20);
            label13.TabIndex = 12;
            label13.Text = "Tình trạng giao hàng:";
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Location = new Point(170, 182);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(33, 20);
            lblAdd.TabIndex = 15;
            lblAdd.Text = "null";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(424, 137);
            label15.Name = "label15";
            label15.Size = new Size(171, 20);
            label15.TabIndex = 14;
            label15.Text = "Phương thức thanh toán:";
            // 
            // lblOderAt
            // 
            lblOderAt.AutoSize = true;
            lblOderAt.Location = new Point(170, 231);
            lblOderAt.Name = "lblOderAt";
            lblOderAt.Size = new Size(33, 20);
            lblOderAt.TabIndex = 17;
            lblOderAt.Text = "null";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(50, 231);
            label17.Name = "label17";
            label17.Size = new Size(73, 20);
            label17.TabIndex = 16;
            label17.Text = "Ngày đặt:";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(709, 618);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(110, 38);
            btnDong.TabIndex = 18;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnXuatHD
            // 
            btnXuatHD.Location = new Point(542, 618);
            btnXuatHD.Name = "btnXuatHD";
            btnXuatHD.Size = new Size(131, 38);
            btnXuatHD.TabIndex = 19;
            btnXuatHD.Text = "Xuất Hóa Đơn";
            btnXuatHD.UseVisualStyleBackColor = true;
            btnXuatHD.Click += btnXuatHD_Click;
            // 
            // txtThanhTien
            // 
            txtThanhTien.AutoSize = true;
            txtThanhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtThanhTien.ForeColor = Color.Red;
            txtThanhTien.Location = new Point(105, 619);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(48, 28);
            txtThanhTien.TabIndex = 21;
            txtThanhTien.Text = "null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 627);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 20;
            label4.Text = "Tổng tiền:";
            // 
            // XuatHDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 668);
            Controls.Add(txtThanhTien);
            Controls.Add(label4);
            Controls.Add(btnXuatHD);
            Controls.Add(btnDong);
            Controls.Add(lblOderAt);
            Controls.Add(label17);
            Controls.Add(lblAdd);
            Controls.Add(label15);
            Controls.Add(lblDeliver);
            Controls.Add(label13);
            Controls.Add(lblPayMethod);
            Controls.Add(lblOderStatus);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(lblCus);
            Controls.Add(label5);
            Controls.Add(lblIdOder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grdDetailOrder);
            Name = "XuatHDForm";
            Text = "XuatHDForm";
            Load += XuatHDForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdDetailOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdDetailOrder;
        private Label label1;
        private Label label2;
        private Label lblIdOder;
        private Label lblCus;
        private Label label5;
        private Label lblPhone;
        private Label label7;
        private Label lblOderStatus;
        private Label label9;
        private Label lblPayMethod;
        private Label label11;
        private Label lblDeliver;
        private Label label13;
        private Label lblAdd;
        private Label label15;
        private Label lblOderAt;
        private Label label17;
        private Button btnDong;
        private Button btnXuatHD;
        private Label txtThanhTien;
        private Label label4;
    }
}