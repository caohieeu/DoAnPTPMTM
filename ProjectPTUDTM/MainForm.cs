using Microsoft.Extensions.Configuration;
using System.Reflection;
using LoginForm;

namespace ProjectPTUDTM
{
    public partial class MainForm : Form
    {
        private string _Conn = Program._Configuration.GetConnectionString("ConnectionOfLuan") ?? "";
        private int width { get; set; }
        private int height { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
        public void CreateMenu()
        {
            menuBar1.CreateTabs(5);
            //string appdomain = AppDomain.CurrentDomain.ToString();
            //DirectoryInfo parentDirectory = Directory.GetParent(appdomain)?.Parent?.Parent?.Parent?.Parent;

            //string dllPath = parentDirectory.FullName + "\\Dll\\Debug\\net6.0-windows\\MenuBar.dll";
            //Assembly assembly = Assembly.LoadFile(dllPath);
            //Type formType = assembly.GetType("Library1.MyMenu");
            //if (formType == null)
            //{
            //    MessageBox.Show("Form type not found.");
            //    return;
            //}
            //Control formInstance = (Control)Activator.CreateInstance(formType);

            //panel1.Controls.Add(formInstance);

            //formInstance.Dock = DockStyle.Fill;
            //formInstance.Show();
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
