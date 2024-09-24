using Microsoft.Extensions.Configuration;
using System.Reflection;
using LoginForm;

namespace ProjectPTUDTM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            string appdomain = AppDomain.CurrentDomain.ToString();
            DirectoryInfo parentDirectory = Directory.GetParent(appdomain)?.Parent?.Parent?.Parent?.Parent;

            //string dllPath = parentDirectory.FullName + "\\Dll\\Debug\\net6.0-windows\\MenuBar.dll";
            //Assembly assembly = Assembly.LoadFile(dllPath);
            //Type formType = assembly.GetType("QuanLyNguoiDung.QLNDForm");
            //if (formType == null)
            //{
            //    MessageBox.Show("Form type not found.");
            //    return;
            //}

            //string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";

            //object[] parameters = { connectionString };
            //Control formInstance = (Control)Activator.CreateInstance(formType, parameters);

            //panel1.Controls.Add(formInstance);

            //formInstance.Dock = DockStyle.Fill;
            //formInstance.Show();
        }
        public void CreateMenu()
        {
            menuBar1.CreateTabs(5);
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
                    CreateMenu();
                }
            }
            else
            {
                CreateMenu();
            }
        }
    }
}
