using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using QuanLyRoleMenu.DAO;
using QuanLyRoleMenu.Model;

namespace QuanLyRoleMenu
{
    public partial class QLRMForm : Form
    {
        private readonly string _connectionString;
        private List<Menu> menus = new List<Menu>();
        private List<Role> roles = new List<Role>();
        public QLRMForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            loadDataRole();
            loadDataMenu();
        }

        private void QLRMForm_Resize(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblMenu.Left = this.ClientSize.Width * 52 / 100;
        }
        private void loadDataRole()
        {
            RoleDao roleDao = new RoleDao(_connectionString);
            var dataTable = roleDao.GetData();

            roles.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Role role = new Role
                {
                    Id = row["Id"].ToString(),
                    Name = row["Name"].ToString()
                };
                roles.Add(role);
            }

            grViewRole.DataSource = new BindingList<Role>(roles);
            if (grViewRole.Columns.Count > 0)
            {
                grViewRole.Columns["Id"].HeaderText = "Mã quyền";
                grViewRole.Columns["Name"].HeaderText = "Tên quyền";
            }
        }
        private void loadDataMenu()
        {
            MenuDao menuDao = new MenuDao(_connectionString);
            var dataTable = menuDao.GetData();

            menus.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Menu menu = new Menu
                {
                    MenuId = row["MenuId"].ToString(),
                    AssemblyName = row["AssemblyName"].ToString(),
                    NameSpace = row["NameSpace"].ToString(),
                    MenuName = row["MenuName"].ToString()
                };
                menus.Add(menu);
            }

            grViewMenu.DataSource = new BindingList<Menu>(menus);
            if (grViewMenu.Columns.Count > 0)
            {
                grViewMenu.Columns["MenuId"].HeaderText = "Mã menu";
                grViewMenu.Columns["AssemblyName"].HeaderText = "AssemblyName";
                grViewMenu.Columns["NameSpace"].HeaderText = "NameSpace";
                grViewMenu.Columns["MenuName"].HeaderText = "Tên menu";
            }
        }
        private void loadDataMenuByRole(string roleId)
        {
            menus.Clear();
            grViewMenu.DataSource = null;
            MenuDao menuDao = new MenuDao(_connectionString);
            var dataTable = menuDao.GetMenuByRoleId(roleId);
            foreach (DataRow row in dataTable.Rows)
            {
                Menu menu = new Menu
                {
                    MenuId = row["MenuId"].ToString(),
                    AssemblyName = row["AssemblyName"].ToString(),
                    NameSpace = row["NameSpace"].ToString(),
                    MenuName = row["MenuName"].ToString()
                };
                menus.Add(menu);
            }
            grViewMenu.DataSource = new BindingList<Menu>(menus);
        }


        private void grViewRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedRoleId = grViewRole.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                loadDataMenuByRole(selectedRoleId);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new ManagerRole(_connectionString, 0, null);
            frm.ShowDialog();
            if (frm.IsSave)
            {
                loadDataRole();
            }
        }
        private void bntSua_Click(object sender, EventArgs e)
        {
            
           try
            {
                if (grViewRole.SelectedRows.Count > 0)
                {
                    string selectedRoleId = grViewRole.SelectedRows[0].Cells["Id"].Value.ToString();
                    string selectedRoleName = grViewRole.SelectedRows[0].Cells["Name"].Value.ToString();
                    Role role = new Role(selectedRoleId, selectedRoleName);
                    var frm = new ManagerRole(_connectionString, 1, role);
                    frm.ShowDialog();
                    if (frm.IsSave)
                    {
                        loadDataRole();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một role để sửa.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm quyền");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (grViewRole.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Xác nhận xóa", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string selectedRoleId = grViewRole.SelectedRows[0].Cells["Id"].Value.ToString();
                        RoleDao roleDao = new RoleDao(_connectionString);
                        roleDao.DeleteRole(selectedRoleId);
                        loadDataRole();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một role để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }


        private void btnRoleMenu_Click(object sender, EventArgs e)
        {
            
           if (grViewRole.SelectedRows.Count > 0)
            {
                string selectedRoleId = grViewRole.SelectedRows[0].Cells["Id"].Value.ToString();
                var frm = new ManagerRoleMenu(_connectionString, selectedRoleId);
                frm.ShowDialog();
                if (frm.IsSave)
                {
                    loadDataMenuByRole(selectedRoleId);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một role để sửa.");
            }
        }
    }
}
