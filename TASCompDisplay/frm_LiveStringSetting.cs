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
	public partial class frm_LiveStringSetting : Form
	{
		public frm_LiveStringSetting()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmResult = MessageBox.Show("Are there equal {variables} in the text field as there are varible check boxes checked?\nIf not, the program will likely crash?",
											 "Have you checked your settings?",
											 MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
					SetVars();
				else { }
			}
			catch { }
		}

		private void frm_LiveStringSetting_Load(object sender, EventArgs e)
		{
			LoadVars();
		}

		public void SetVars()
		{
			Properties.Settings.Default.Rank = chk_Rank.Checked;
			Properties.Settings.Default.Username = chk_Username.Checked;
			Properties.Settings.Default.Frames = chk_Frames.Checked;
			Properties.Settings.Default.Time = chk_Time.Checked;
			Properties.Settings.Default.Rerecords = chk_Rerecords.Checked;
			Properties.Settings.Default.Format = txt_Format.Text;
		}

		public void LoadVars()
		{
			chk_Rank.Checked = Properties.Settings.Default.Rank;
			chk_Username.Checked = Properties.Settings.Default.Username;
			chk_Frames.Checked = Properties.Settings.Default.Frames;
			chk_Time.Checked = Properties.Settings.Default.Time;
			chk_Rerecords.Checked = Properties.Settings.Default.Rerecords;
			txt_Format.Text = Properties.Settings.Default.Format;
		}

		private void brn_Refresh_Click(object sender, EventArgs e)
		{
			LoadVars();
		}

		private void btn_Help_Click(object sender, EventArgs e)
		{
			string msg = "Tick the checkbox of each variable you wish to display.\n" +
				"Each CHECKED checkbox from left to right represents {0} onwards.\n" +
				"So having only three checkboxes check means from left to right is:\n{0}, {1}, {2}.\n" +
				"If you wish to have the rightmost variable displayed FIRST, you can do so by:\n{2}, {0}, {1} (from the previous example).";
			MessageBox.Show(msg, "Help");
		}

		private void btn_default_Click(object sender, EventArgs e)
		{
			try
			{
				var confirmResult = MessageBox.Show("Reset defaults?",
											 "Reset settings?",
											 MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{
					Properties.Settings.Default.Rank = true;
					Properties.Settings.Default.Username = true;
					Properties.Settings.Default.Frames = true;
					Properties.Settings.Default.Time = true;
					Properties.Settings.Default.Rerecords = true;
					Properties.Settings.Default.Format = "{0} {1} ({2})";
				}
				else { }
			}
			catch { }
		}
	}
}
