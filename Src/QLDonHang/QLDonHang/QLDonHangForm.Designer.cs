namespace QLDonHang
{
    partial class QLDonHangForm
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridViewOrderDetail = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewOrder = new DataGridView();
            bsOrder = new BindingSource(components);
            bsOrderDetail = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 545);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOrderDetail);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 393);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(893, 149);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // dataGridViewOrderDetail
            // 
            dataGridViewOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetail.Dock = DockStyle.Fill;
            dataGridViewOrderDetail.Location = new Point(3, 23);
            dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            dataGridViewOrderDetail.RowHeadersWidth = 51;
            dataGridViewOrderDetail.RowTemplate.Height = 29;
            dataGridViewOrderDetail.Size = new Size(887, 123);
            dataGridViewOrderDetail.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOrder);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(893, 370);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Dock = DockStyle.Fill;
            dataGridViewOrder.Location = new Point(3, 23);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.RowTemplate.Height = 29;
            dataGridViewOrder.Size = new Size(887, 344);
            dataGridViewOrder.TabIndex = 0;
            dataGridViewOrder.CellDoubleClick += dataGridViewOrder_CellDoubleClick;
            // 
            // QLDonHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 545);
            Controls.Add(groupBox1);
            Name = "QLDonHangForm";
            Text = "QLDonHang";
            Load += QLDonHangForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetail).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOrderDetail;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOrder;
        private BindingSource bsOrder;
        private BindingSource bsOrderDetail;
    }
}