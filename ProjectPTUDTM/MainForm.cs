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
			CreateMenu();
			if (Core.Enviroment.UserName == string.Empty)
            {
                string connectionString = Program._Configuration.GetConnectionString("DefaultConnection") ?? "";

                LoginForm.LoginForm loginForm = new LoginForm.LoginForm(connectionString);

                //loginForm.ShowDialog();
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
        public void showContent(string content)
        {
			this.panel2.Controls.Clear();

            Label contentLabel = new Label
            {
                Text = content,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
            };

            this.panel2.Controls.Add(contentLabel);
        }
    }
}
