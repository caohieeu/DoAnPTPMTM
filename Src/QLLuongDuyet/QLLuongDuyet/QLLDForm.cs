using QLLuongDuyet.DAO;
using QLLuongDuyet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLuongDuyet
{
    public partial class QLLDForm : Form
    {
        private readonly string _connectionString;
        private DataTable masterTable;
        private DataTable childTable;
        private DataTable childTable2;
        public QLLDForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            dataGridView1.DataSource = bsLD;
            dataGridView2.DataSource = bsUSLD;
            dataGridView3.DataSource = bsRLD;
        }
        private void LoadData()
        {
            MyDao myDao = new MyDao(_connectionString);

            DataSet dts = myDao.GetLuongDuyet();
            masterTable = dts.Tables[0];

            childTable = dts.Tables[1];

            childTable2 = dts.Tables[2];

            DataColumn[] cols = new DataColumn[] { masterTable.Columns["tenluongduyet"] };

            DataColumn[] cols2 = new DataColumn[] { childTable.Columns["LuongDuyetId"] };
            DataColumn[] cols3 = new DataColumn[] { childTable2.Columns["LuongDuyetId"] };


            DataRelation dataRelation = new DataRelation("LD", cols, cols2, false);
            DataRelation dataRelation2 = new DataRelation("LD2", cols, cols3, false);

            dts.Relations.Add(dataRelation);
            dts.Relations.Add(dataRelation2);

            bsLD.DataSource = dts;
            bsLD.DataMember = masterTable.TableName;

            bsUSLD.DataSource = bsLD;
            bsUSLD.DataMember = "LD";

            bsRLD.DataSource = bsLD;
            bsRLD.DataMember = "LD2";
        }
        private void QLLDForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void btnThemLD_Click(object sender, EventArgs e)
        {
            var frm = new LDUpsertForm(_connectionString, 0);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void btnSuaLD_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;

            var frm = new LDUpsertForm(_connectionString, 1, (DataRowView)bsLD.Current);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void btnXoaLD_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;
            MessageBox.Show("pending");
            //if (MessageBox.Show("Xác nhận xóa", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    MyDao myDao = new MyDao(_connectionString);
            //    myDao.DeleteLuongDuyet(masterTable.Rows[bsLD.Position]["Id"].ToString());
            //    LoadData();
            //}
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;

            var frm = new USDLUpsertForm(_connectionString, 0, ((DataRowView)bsLD.Current)["tenluongduyet"].ToString(), null);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null || bsUSLD.Current == null) return;

            var frm = new USDLUpsertForm(_connectionString, 1, ((DataRowView)bsLD.Current)["tenluongduyet"].ToString(), (DataRowView)bsUSLD.Current);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null) return;

            var frm = new RLDUpsertForm(_connectionString, 0, ((DataRowView)bsLD.Current)["tenluongduyet"].ToString(), null);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (bsLD.Current == null || bsRLD.Current == null) return;

            var frm = new RLDUpsertForm(_connectionString, 1, ((DataRowView)bsLD.Current)["tenluongduyet"].ToString(), (DataRowView)bsRLD.Current);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                LoadData();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
