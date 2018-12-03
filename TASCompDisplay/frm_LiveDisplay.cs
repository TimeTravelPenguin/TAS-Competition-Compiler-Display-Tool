using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		ExportLiveDisplay eld = new ExportLiveDisplay();
		NumberConverter nc = new NumberConverter();

		public frm_LiveDisplay()
		{
			InitializeComponent();
		}

		private void frm_LiveDisplay_Load(object sender, EventArgs e)
		{
			// set initial checkbox value
			chk_EnableNextRun.Checked = Properties.Settings.Default.nextRun;

			NextRunView();

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

		public void SaveToFile(string data)
		{
			eld.SaveFile(data);
		}

		public void Display()
		{
			InformationUpdate();

			// spaghetti code - Fix later
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

			string output = string.Format(Properties.Settings.Default.Format, args.Cast<object>().ToArray());
			lbl_Display.Text = output;

			try
			{
				// Check output dir
				SaveToFile(output);
			}
			catch
			{
				MessageBox.Show("There was an error outputting the file. Please set an output location!", "Error...");
			}
		}

		public void InformationUpdate()
		{
			// Current run information
			lbl_Rank.Text = compList[listIndex].Rank.ToString();
			lbl_Name.Text = compList[listIndex].Username;
			lbl_VIs.Text = compList[listIndex].Frames.ToString();

			try { lbl_Delta.Text = $"{compList[listIndex].Frames - compList[listIndex - 1].Frames}"; }
			catch { lbl_Delta.Text = "0"; }

			lbl_Time.Text = nc.FormatTime(compList[listIndex].Frames);

			// Next run information
			string oefString = "EOF";

			try { lbl_NextRank.Text = compList[listIndex + 1].Rank.ToString(); }
			catch { lbl_NextRank.Text = oefString; }

			try { lbl_NextName.Text = compList[listIndex + 1].Username; }
			catch { lbl_NextName.Text = oefString; }

			try { lbl_NextVIs.Text = compList[listIndex + 1].Frames.ToString(); }
			catch { lbl_NextVIs.Text = oefString; }

			try { lbl_NextDelta.Text = $"{compList[listIndex + 1].Frames - compList[listIndex].Frames}"; }
			catch { lbl_NextDelta.Text = oefString; ; }

			try { lbl_NextTime.Text = nc.FormatTime(compList[listIndex + 1].Frames); }
			catch { lbl_NextTime.Text = oefString; }
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

		private void changeOutputDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.dir = "";
			Properties.Settings.Default.Save();

			eld.SaveFile(lbl_Display.Text);
		}

		private void chk_EnableNextRun_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.nextRun = chk_EnableNextRun.Checked;
			Properties.Settings.Default.Save();

			NextRunView();
		}

		public void NextRunView()
		{
			bool enabled = Properties.Settings.Default.nextRun;
			if (enabled)
			{
				gb_CurrentRun.Location = new Point(12, gb_CurrentRun.Top);

				gb_NextRun.Visible = true;
				gb_NextRun.Size = new Size(205, 156);
				gb_NextRun.Location = new Point(222, gb_NextRun.Top);
			}
			else
			{
				var xpos = Width / 2 - gb_CurrentRun.Width / 2;
				gb_CurrentRun.Location = new Point(xpos, gb_CurrentRun.Top);
				gb_NextRun.Visible = false;
			}
		}
	}
}
