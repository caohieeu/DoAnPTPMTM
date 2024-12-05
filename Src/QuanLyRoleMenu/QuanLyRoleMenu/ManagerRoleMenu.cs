using QuanLyRoleMenu.DAO;
using QuanLyRoleMenu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRoleMenu
{
    public partial class ManagerRoleMenu : Form
    {
        public bool IsSave { set; get; }
        public string conn;
        public string roleId;
        RoleMenu roleMenu = new RoleMenu();
        List<RoleMenu> roleMenus = new List<RoleMenu>();
        RoleMenuDao roleMenuDao;
        MenuDao menuDao;
        public ManagerRoleMenu(string con, string roleId)
        {
            InitializeComponent();
            this.conn = con;
            this.roleId = roleId;
            txtRole.Text = roleId;
            txtRole.Enabled = false;
            loadComboboxMenu();
            loadRoleMenuByRole(roleId);
        }
        private void loadRoleMenuByRole(string roleID)
        {
            roleMenus.Clear();
            grViewRoleMenu.DataSource = null;

            roleMenuDao = new RoleMenuDao(conn);
            var dataTable = roleMenuDao.GetRoleMenuByRoleId(roleID);

            foreach (DataRow row in dataTable.Rows)
            {
                RoleMenu roleMenu = new RoleMenu
                {
                    RoleId = row["RoleId"].ToString(),
                    MenuId = row["MenuId"].ToString(),
                };
                roleMenus.Add(roleMenu);
            }
            grViewRoleMenu.DataSource = new BindingList<RoleMenu>(roleMenus);
        }
        private void loadComboboxMenu()
        {
            MenuDao menuDao = new MenuDao(conn);
            var dataTable = menuDao.GetData();

            DataRow emptyRow = dataTable.NewRow();
            emptyRow["MenuId"] = ""; 
            emptyRow["MenuName"] = "Please select";
            dataTable.Rows.InsertAt(emptyRow, 0);

            cbbMenu.DataSource = dataTable;
            cbbMenu.DisplayMember = "MenuName";
            cbbMenu.ValueMember = "MenuId";

            cbbMenu.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            roleMenuDao = new RoleMenuDao(conn);
            string roleID = txtRole.Text;
            string menuId = cbbMenu.SelectedValue?.ToString();
            foreach(RoleMenu rm  in roleMenus) {
                if(rm.MenuId == menuId && rm.RoleId == roleID)
                {
                    MessageBox.Show("Menu này đã có trong quyền hãy thêm Menu khác");
                    return;
                }
            }
            if (string.IsNullOrEmpty(roleID) || string.IsNullOrEmpty(menuId))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin Role và Menu.");
                return;
            }

            roleMenu = new RoleMenu(roleID, menuId);
            bool isInserted = roleMenuDao.InsertRoleMenu(roleMenu);

            if (isInserted)
            {
                MessageBox.Show("Thêm RoleMenu thành công!");
                loadRoleMenuByRole(roleID);
            }
            else
            {
                MessageBox.Show("Thêm RoleMenu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grViewRoleMenu.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Xác nhận xóa", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string selectedRoleId = grViewRoleMenu.SelectedRows[0].Cells["RoleId"].Value.ToString();
                    string selectedMenuId = grViewRoleMenu.SelectedRows[0].Cells["MenuId"].Value.ToString();
                    roleMenuDao = new RoleMenuDao(conn);
                    roleMenuDao.DeleteRoleMenu(selectedRoleId, selectedMenuId);
                    loadRoleMenuByRole(txtRole.Text);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một RoleMenu để xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            IsSave = true;
            Close();
        }
    }
}
