using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDesign
{
	public partial class MyMenu : UserControl
	{
		private int width { get; set; }
		private int height { get; set; }
		public MyMenu()
		{
			InitializeComponent();
			//this.FormBorderStyle = FormBorderStyle.None;
			width = 207;
			height = 100 * 5 + 30;
			this.Size = new System.Drawing.Size(width, height);
			CreateTabs(5);
		}
		private void CreateTabs(int tabCount)
		{
			FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
			{
				Dock = DockStyle.Left,
				AutoSize = true,
				FlowDirection = FlowDirection.TopDown,
				WrapContents = false
			};
			this.Controls.Add(flowLayoutPanel);

			for (int i = 0; i < tabCount; i++)
			{
				Panel tabPanel = new Panel
				{
					Size = new System.Drawing.Size(200, 100),
					BorderStyle = BorderStyle.FixedSingle
				};

				Button tabButton = new Button
				{
					Text = $"Tab {i + 1}",
					Dock = DockStyle.Fill
				};
				tabPanel.Controls.Add(tabButton);

				flowLayoutPanel.Controls.Add(tabPanel);
			}
		}
	}
}
