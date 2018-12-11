using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASCompDisplay
{
	public partial class frm_PlainImport : Form
	{
		public List<Competitor> compList { get; set; }
		public string defaultText { get; set; }

		public frm_PlainImport()
		{
			InitializeComponent();

			compList = new List<Competitor>();

			defaultText = txt_Input.Text;
		}

		private void btn_Submit_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < txt_Input.Lines.Length; i++)
				{
					string line = txt_Input.Lines[i];

					var var = line.Split(' ');

					var time = var[1].Split('"');
					int frames = (int)(Convert.ToDouble($"{time[0]}.{time[1]}") * 60);

					Competitor competitor = new Competitor(0, var[0], 0, frames, 0, false, "");
					compList.Add(competitor);
				}

				this.Close();
			}
			catch { MessageBox.Show("Whoops, please use the appropriate format!!!"); }
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			txt_Input.Text = defaultText;
		}
	}
}
