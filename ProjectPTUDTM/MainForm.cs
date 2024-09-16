using Library1;

namespace ProjectPTUDTM
{
	public partial class MainForm : Form
	{
		private int width {  get; set; }
		private int height { get; set; }
		public MainForm()
		{
			InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;

			if(Core.Enviroment.UserName == string.Empty)
			{
				LoginForm.LoginForm loginForm = new LoginForm.LoginForm();

				loginForm.WindowState = FormWindowState.Maximized;
				
				this.Hide();

				loginForm.ShowDialog();
				if(loginForm.IsSuccess)
				{
					this.Show();
					CreateMenu();

                }
				CreateMenu();
            }
		}
		public void CreateMenu()
		{
			MyMenu myMenu = new MyMenu();
			panel1.Controls.Add(myMenu);

			myMenu.Dock = DockStyle.Fill;
			myMenu.Show();
		}
	}
}
