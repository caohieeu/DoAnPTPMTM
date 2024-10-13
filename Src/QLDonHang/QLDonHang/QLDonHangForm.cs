using QLLuongDuyet.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDonHang
{
    public partial class QLDonHangForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;
        private DataTable childTable;
        public QLDonHangForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            dataGridViewOrder.DataSource = bsOrder;
            dataGridViewOrderDetail.DataSource = bsOrderDetail;
        }
        public void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);

            DataSet dts = myDao.GetDonHang();
            masterTable = dts.Tables[0];
            childTable = dts.Tables[1];

            DataColumn[] cols = new DataColumn[] { masterTable.Columns["Id"] };
            DataColumn[] cols2 = new DataColumn[] { childTable.Columns["OrderId"] };
            DataRelation dataRelation = new DataRelation("Odr", cols, cols2, false);

            dts.Relations.Add(dataRelation);

            bsOrder.DataSource = dts;
            bsOrder.DataMember = masterTable.TableName;

            bsOrderDetail.DataSource = bsOrder;
            bsOrderDetail.DataMember = "Odr";
        }
        private void QLDonHangForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void dataGridViewOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dHStatusForm = new DHStatusForm(((DataRowView)bsOrder.Current)["Id"].ToString(), null, _connectionString, ((DataRowView)bsOrder.Current)["OrderStatus"].ToString());
            dHStatusForm.ShowDialog();
            if(dHStatusForm.isSave)
            {
                LoadData();
            }
        }
    }
}
