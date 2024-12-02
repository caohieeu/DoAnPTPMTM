using Core.DAL;
using LoginForm;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjectPTUDTM
{
    public partial class MenuBar : UserControl
    {
        public event Action<DataRow> TabButtonClicked;
        public event Action TabBtnLogout;
        public MenuBar()
        {
            InitializeComponent();
        }
        public void CreateTabs(string userId)
        {
			string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";
            MyDbContext myDbContext = new MyDbContext(connectionString);

            string sqlQuery = "SELECT m.* FROM Users u JOIN Roles r ON u.RoleId = r.id JOIN RoleMenu rm ON r.id = rm.RoleId JOIN Menu m ON rm.MenuId = m.MenuId WHERE u.id = '" + userId + "'";
            //string sqlQuery = "SELECT m.* FROM Menu m";
            DataTable result = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
			};
            flowLayoutPanel.Name = "Menus";
            this.Controls.Add(flowLayoutPanel);
            foreach (DataRow row in result.Rows)
            {
                Panel tabPanel = new Panel
                {
                    Size = new System.Drawing.Size(200, 60),
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Button tabButton = new Button
                {
                    Text = row["MenuName"].ToString(),
                    Tag = row,
                    Dock = DockStyle.Fill
                };
				tabButton.Click += TabButton_Click;
                tabPanel.Controls.Add(tabButton);
                flowLayoutPanel.Controls.Add(tabPanel);
            }
            Panel tabPanel2 = new Panel
            {
                Size = new System.Drawing.Size(200, 60),
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Bottom
            };

            Button btnLogout = new Button
            {
                Text = "Đăng xuất",
                Dock = DockStyle.Fill,
                BackColor = Color.Red,
                ForeColor = Color.White,
            };
            btnLogout.Click += BtnLogout_Click; 
            tabPanel2.Controls.Add(btnLogout);
            flowLayoutPanel.Controls.Add(tabPanel2);
        }

        private void BtnLogout_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                TabBtnLogout?.Invoke();
            }
        }

        private void TabButton_Click(object? sender, EventArgs e)
		{
            if (sender is Button clickedButton && clickedButton.Tag is DataRow dataRow)
            {
                TabButtonClicked?.Invoke(dataRow);
            }
        }
	}
}
