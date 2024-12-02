using Microsoft.Extensions.Configuration;
using System.Reflection;
using LoginForm;
using System.Data;

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
        }

        private void MenuBar1_TabButtonClicked(DataRow dtr)
        {
            ShowForm(dtr);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			if (Core.Enviroment.UserName == string.Empty)
            {
                string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";

                LoginForm.LoginForm loginForm = new LoginForm.LoginForm(connectionString);

                loginForm.ShowDialog();
                if (loginForm.IsSuccess)
                {
                    CreateMenu(Core.Enviroment.UserName);
                }
                else
                {
                    Close();
                }

                MessageBox.Show(Core.Enviroment.UserName);
            }
            else
            {
                CreateMenu(Core.Enviroment.UserName);
            }
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
