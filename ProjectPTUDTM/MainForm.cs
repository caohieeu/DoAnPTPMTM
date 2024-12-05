using Microsoft.Extensions.Configuration;
using System.Reflection;
using LoginForm;
using System.Data;
using Core;

namespace ProjectPTUDTM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public void CreateMenu(string username)
        {
            menuBar1.CreateTabs(username);
            menuBar1.TabButtonClicked += MenuBar1_TabButtonClicked;
            menuBar1.TabBtnLogout += MenuBar1_TabBtnLogout;
        }

        private void MenuBar1_TabBtnLogout()
        {
            Enviroment.clearObject();

            var menu = menuBar1.Controls["Menus"];
            menu.Controls.Clear();
            menuBar1.Controls.Remove(menu);

            InitLoad();
        }

        private void MenuBar1_TabButtonClicked(DataRow dtr)
        {
            ShowForm(dtr);
        }
        private void InitLoad()
        {
            if (Core.Enviroment.UserName == string.Empty)
            {
                string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";

                LoginForm.LoginForm loginForm = new LoginForm.LoginForm(connectionString);

                loginForm.ShowDialog();
                if (loginForm.IsSuccess)
                {
                    CreateMenu(Core.Enviroment.UserID);
                }
                else
                {
                    Close();
                }
            }
            else
            {
                CreateMenu(Core.Enviroment.UserID);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitLoad();
        }
        public void ShowForm(DataRow dtr)
        {
			this.panel2.Controls.Clear();

            string appdomain = AppDomain.CurrentDomain.ToString();
            DirectoryInfo parentDirectory = Directory.GetParent(appdomain)?.Parent?.Parent?.Parent?.Parent;

            string dllPath = parentDirectory.FullName + $"\\Dll\\Debug\\net6.0-windows\\{dtr["AssemblyName"]}.dll";
            Assembly assembly = Assembly.LoadFile(dllPath);
            Type formType = assembly.GetType($"{dtr["NameSpace"]}");
            if (formType == null)
            {
                MessageBox.Show("Form type not found.");
                return; 
            }

            string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";

            object[] parameters = { connectionString };
            Form formInstance = (Form)Activator.CreateInstance(formType, parameters);
            formInstance.TopLevel = false;

            panel2.Controls.Add(formInstance);

            formInstance.Dock = DockStyle.Fill;
            formInstance.Show();
        }
    }
}
