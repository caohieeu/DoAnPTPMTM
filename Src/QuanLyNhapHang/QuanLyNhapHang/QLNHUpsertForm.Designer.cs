namespace QuanLyNhapHang
{
    partial class QLNHUpsertForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lbltong = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNccId = new ComboBox();
            label1 = new Label();
            txtTong = new TextBox();
            txtTongSp = new TextBox();
            txtTongShip = new TextBox();
            txtdiachi = new TextBox();
            txtsdt = new TextBox();
            txtNccName = new TextBox();
            panel2 = new Panel();
            detailGrid = new DataGridView();
            panel3 = new Panel();
            BtnCancel = new Button();
            BtnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detailGrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.55556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(958, 471);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbltong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNccId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTong);
            panel1.Controls.Add(txtTongSp);
            panel1.Controls.Add(txtTongShip);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(txtsdt);
            panel1.Controls.Add(txtNccName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 116);
            panel1.TabIndex = 0;
            // 
            // lbltong
            // 
            lbltong.AutoSize = true;
            lbltong.Location = new Point(640, 74);
            lbltong.Name = "lbltong";
            lbltong.Size = new Size(72, 20);
            lbltong.TabIndex = 13;
            lbltong.Text = "Tổng tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(640, 43);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 12;
            label5.Text = "Tổng tiền sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 12);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 11;
            label4.Text = "Tổng tiền ship";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 9;
            label2.Text = "SĐT";
            // 
            // txtNccId
            // 
            txtNccId.FormattingEnabled = true;
            txtNccId.Location = new Point(123, 8);
            txtNccId.Name = "txtNccId";
            txtNccId.Size = new Size(125, 28);
            txtNccId.TabIndex = 8;
            txtNccId.SelectedValueChanged += txtNccId_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 7;
            label1.Text = "Nhà cung cấp";
            // 
            // txtTong
            // 
            txtTong.Location = new Point(795, 71);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(125, 27);
            txtTong.TabIndex = 6;
            // 
            // txtTongSp
            // 
            txtTongSp.Location = new Point(795, 40);
            txtTongSp.Name = "txtTongSp";
            txtTongSp.Size = new Size(125, 27);
            txtTongSp.TabIndex = 5;
            // 
            // txtTongShip
            // 
            txtTongShip.Location = new Point(795, 9);
            txtTongShip.Name = "txtTongShip";
            txtTongShip.Size = new Size(125, 27);
            txtTongShip.TabIndex = 4;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(123, 71);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.ReadOnly = true;
            txtdiachi.Size = new Size(408, 27);
            txtdiachi.TabIndex = 3;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(123, 40);
            txtsdt.Name = "txtsdt";
            txtsdt.ReadOnly = true;
            txtsdt.Size = new Size(408, 27);
            txtsdt.TabIndex = 2;
            // 
            // txtNccName
            // 
            txtNccName.Location = new Point(254, 9);
            txtNccName.Name = "txtNccName";
            txtNccName.ReadOnly = true;
            txtNccName.RightToLeft = RightToLeft.No;
            txtNccName.Size = new Size(277, 27);
            txtNccName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(detailGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 302);
            panel2.TabIndex = 1;
            // 
            // detailGrid
            // 
            detailGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detailGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailGrid.Dock = DockStyle.Fill;
            detailGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            detailGrid.Location = new Point(0, 0);
            detailGrid.Name = "detailGrid";
            detailGrid.RowHeadersWidth = 51;
            detailGrid.RowTemplate.Height = 29;
            detailGrid.Size = new Size(952, 302);
            detailGrid.TabIndex = 0;
            detailGrid.CellValidated += detailGrid_CellValidated;
            detailGrid.DefaultValuesNeeded += detailGrid_DefaultValuesNeeded;
            detailGrid.UserDeletedRow += detailGrid_UserDeletedRow;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnCancel);
            panel3.Controls.Add(BtnSave);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 433);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 35);
            panel3.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancel.Location = new Point(749, 6);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "Hủy";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSave.Location = new Point(849, 6);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Lưu";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // QLNHUpsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 471);
            Controls.Add(tableLayoutPanel1);
            Name = "QLNHUpsertForm";
            Text = "QLNHUpsertForm";
            Load += QLNHUpsertForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)detailGrid).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox txtNccName;
        private TextBox txtsdt;
        private TextBox txtdiachi;
        private TextBox txtTongSp;
        private TextBox txtTongShip;
        private TextBox txtTong;
        private Label label1;
        private Label lbltong;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox txtNccId;
        private Panel panel2;
        private DataGridView detailGrid;
        private Panel panel3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}