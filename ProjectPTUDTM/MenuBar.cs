using Core.DAL;
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

namespace ProjectPTUDTM
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }
        public void CreateTabs(int tabCount)
        {
			string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";
            MyDbContext myDbContext = new MyDbContext(connectionString);

            string sqlQuery = "SELECT * FROM Menu";
            DataTable result = myDbContext.ExecuteQuery(sqlQuery, CommandType.Text);

			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
			};
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
                    Text = row["AssemblyName"].ToString(),
                    Dock = DockStyle.Fill
                };
				tabButton.Click += TabButton_Click;
                tabPanel.Controls.Add(tabButton);

                flowLayoutPanel.Controls.Add(tabPanel);
            }
        }

		private void TabButton_Click(object? sender, EventArgs e)
		{
			var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
			if (mainForm != null)
			{
				mainForm.showContent("Trang quản lý người dùng");
			}
		}
	}
}
