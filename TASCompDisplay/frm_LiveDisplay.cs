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
	public partial class frm_LiveDisplay : Form
	{
		public List<Competitor> compList { get; set; }
		public int listIndex { get; set; }

		public frm_LiveDisplay()
		{
			InitializeComponent();
		}

		private void frm_LiveDisplay_Load(object sender, EventArgs e)
		{
			listIndex = 0;

			try { Display(); }
			catch (Exception err)
			{
				lbl_Display.Text = "Error...";
				MessageBox.Show($"Error:\n{err}");
			}

			// initial window resize
			Reposition();
		}

		public void Display()
		{
			// spaghetti code - Fix later
			NumberConverter nc = new NumberConverter();

			List<bool> settings = new List<bool>
			{
				Properties.Settings.Default.Rank,
				Properties.Settings.Default.Username,
				Properties.Settings.Default.Frames,
				Properties.Settings.Default.Time,
				Properties.Settings.Default.Rerecords
			};

			List<string> args = new List<string> { };
			if (settings[0])
			{
				if (compList[listIndex].DQ)
					args.Add("DQ");
				else
					args.Add(nc.AddOrdinal(compList[listIndex].Rank));
			}
			if (settings[1])
				args.Add(compList[listIndex].Username);
			if (settings[2])
				args.Add(compList[listIndex].Frames.ToString());
			if (settings[3])
				args.Add(nc.FormatTime(compList[listIndex].Frames));
			if (settings[4])
				args.Add(compList[listIndex].Rerecords.ToString());

			lbl_Display.Text = string.Format(Properties.Settings.Default.Format, args.Cast<object>().ToArray());
		}

		public void Reposition() { lbl_Display.Location = new Point((Width / 2) - (lbl_Display.Width / 2), lbl_Display.Top); }

		private void btn_Next_Click(object sender, EventArgs e)
		{
			try
			{
				listIndex++;
				Display();
				Reposition();
			}
			catch { listIndex--; }
		}

		private void btn_Previous_Click(object sender, EventArgs e)
		{
			try
			{
				listIndex--;
				Display();
				Reposition();
			}
			catch { listIndex++; }
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_LiveStringSetting lss = new frm_LiveStringSetting();
			lss.ShowDialog();
		}
	}
}
