﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TASCompDisplay
{
	public partial class fm_Main : Form
	{
		File f = new File();

		public fm_Main()
		{
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFile();
		}

		public void OpenFile()
		{
			bool readyToLoad;
			string path;
			string contents;

			(readyToLoad, path, contents) = f.Load();
			toolStripStatusLabel_OpenedFile.Text = f.filePath;

			if (readyToLoad)
			{
				try
				{
					ResetAll();

					List<Competitor> competitionList = JsonConvert.DeserializeObject<List<Competitor>>(contents);

					WriteToDataGrid(competitionList);
				}
				catch (Exception e)
				{
					MessageBox.Show($"Error parsing file\n\n{e}", "Error reading file...");
				}
			}

			// Sort ranks
			GridSortRank();
		}

		public void WriteToDataGrid(List<Competitor> competitionList)
		{
			foreach (var item in competitionList)
			{
				DataGridViewRow row = (DataGridViewRow)dataGrid_TASData.Rows[0].Clone();

				row.Cells[0].Value = item.Rank;
				row.Cells[1].Value = item.Username;
				row.Cells[2].Value = item.StartFrame;
				row.Cells[3].Value = item.EndFrame;
				row.Cells[4].Value = item.Rerecords;
				row.Cells[5].Value = item.DQ;
				row.Cells[6].Value = item.Comments;

				dataGrid_TASData.Rows.Add(row);
			}

			// Sort by rank
			dataGrid_TASData.Sort(dataGrid_TASData.Columns[0], ListSortDirection.Ascending);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void checkBox_DQ_CheckedChanged(object sender, EventArgs e)
		{
			switch (checkBox_DQ.Checked)
			{
				case (true):
					groupBox_DQReasons.Enabled = true;
					break;
				case (false):
					groupBox_DQReasons.Enabled = false;
					break;
				default:
					groupBox_DQReasons.Enabled = false;
					break;
			}
		}

		private void chk_DQ_Other_CheckedChanged(object sender, EventArgs e)
		{
			switch (chk_DQ_Other.Checked)
			{
				case (true):
					txt_DQ_Other.Enabled = true;
					break;
				case (false):
					txt_DQ_Other.Enabled = false;
					break;
				default:
					txt_DQ_Other.Enabled = false;
					break;
			}
		}

		private void btn_AddCompetitor_Click(object sender, EventArgs e)
		{
			// todo check for dup usernames

			DataGridViewRow row = (DataGridViewRow)dataGrid_TASData.Rows[0].Clone();

			row.Cells[1].Value = txt_addUsername.Text.Trim();
			row.Cells[2].Value = txt_addStartFrame.Text.Trim();
			row.Cells[3].Value = txt_addEndFrame.Text.Trim();
			row.Cells[4].Value = txt_addRerecords.Text.Trim();

			if (checkBox_DQ.Checked)
			{
				row.Cells[5].Value = "true";
				row.Cells[6].Value = DQString();
			}

			dataGrid_TASData.Rows.Add(row);

			// CalculateRanks()
			GridSortRank();
		}

		public string DQString()
		{
			string DQ = "  ";

			if (chk_DQ_M64Early.Checked)
				DQ += ".m64 ended too early, ";

			if (chk_DQ_FailedGoal.Checked)
				DQ += "Failed to achieve task goal, ";

			if (chk_DQ_StratTalk.Checked)
				DQ += "DQ'd for strat talking, ";

			if (chk_DQ_IllegalInteraction.Checked)
				DQ += "Collected an illegal item, ";

			if (chk_DQ_Desync.Checked)
				DQ += ".m64 desync'd, ";

			if (chk_DQ_Other.Checked)
				DQ += $"Other: {txt_DQ_Other.Text.Trim()}, ";

			return DQ.Substring(0, DQ.Length - 2).Trim();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGrid_TASData.EndEdit();

			List<Competitor> CompetitionList = CompObjectCompile();

			var savedata = JsonConvert.SerializeObject(CompetitionList);

			f.Save(savedata);
		}

		public List<Competitor> CompObjectCompile()
		{
			List<Competitor> CompetitionList = new List<Competitor>();

			for (int row = 0; row < dataGrid_TASData.Rows.Count - 1; row++)
			{
				int rank = row + 1;

				int start = 0;
				try { start = Convert.ToInt32(dataGrid_TASData.Rows[row].Cells[2].Value); }
				catch { start = -1; }

				int end;
				try { end = Convert.ToInt32(dataGrid_TASData.Rows[row].Cells[3].Value); }
				catch { end = -1; }
				int rerecs;
				try { rerecs = Convert.ToInt32(dataGrid_TASData.Rows[row].Cells[4].Value); }
				catch { rerecs = -1; }

				string username = $"{dataGrid_TASData.Rows[row].Cells[1].Value}";


				// fix for unchecked values being = "" and not "false"
				bool dq = (bool)dataGrid_TASData.Rows[row].Cells[5].Value;

				//MessageBox.Show(dq.ToString());

				string comments = $"{dataGrid_TASData.Rows[row].Cells[6].Value}";

				Competitor user = new Competitor(rank, username, start, end, rerecs, dq, comments);
				CompetitionList.Add(user);
			}

			return CompetitionList;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetAll();
		}

		public void ResetAll()
		{
			// Reset all elements

			dataGrid_TASData.Rows.Clear();

			txt_addUsername.Clear();
			txt_addStartFrame.Clear();
			txt_addEndFrame.Clear();
			txt_addRerecords.Clear();

			checkBox_DQ.Checked = false;
			chk_DQ_M64Early.Checked = false;
			chk_DQ_FailedGoal.Checked = false;
			chk_DQ_StratTalk.Checked = false;
			chk_DQ_IllegalInteraction.Checked = false;
			chk_DQ_Desync.Checked = false;
			chk_DQ_Other.Checked = false;

			txt_DQ_Other.Clear();

			Refresh();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_About about = new frm_About();
			about.ShowDialog();
		}

		public void GridSortRank()
		{
			List<Competitor> compList = CompObjectCompile();
			Dictionary<string, int> timeDict = new Dictionary<string, int>();

			// sort compList 
			List<Competitor> SortedCompList = compList.OrderBy(x => x.EndFrame - x.StartFrame).ToList();

			// set rank = i
			// if a DQ'd run, set to last place
			for (int i = 0; i < SortedCompList.Count(); i++)
			{
				if (SortedCompList[i].DQ == true)
				{
					SortedCompList[i].Rank = SortedCompList.Count();
				}

				else if (SortedCompList[i].DQ == false)
				{
					SortedCompList[i].Rank = i;
				}

			}

			// check and fix ranks in instances of ties
			for (int i = 1; i < SortedCompList.Count(); i++)
			{
				int time = SortedCompList[i].EndFrame - SortedCompList[i].StartFrame;
				int prevtime = SortedCompList[i - 1].EndFrame - SortedCompList[i - 1].StartFrame;

				// check if dup. If so, set rank to rank of previous item
				// ignores DQs
				// Does this work?????? Apparently?
				if (time == prevtime && SortedCompList[i].DQ == true)
					SortedCompList[i].Rank = SortedCompList[i - 1].Rank;
			}


			dataGrid_TASData.Rows.Clear();
			WriteToDataGrid(SortedCompList);
		}

		private void rerankBoardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GridSortRank();
		}

		private void exportPlainTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var data = CompObjectCompile();

			NumberConverter numConv = new NumberConverter();

			string output = "**__Task XX Results:__**\r\n";
			string temp;

			int boldLimit = 5;
			double nonDQs = 0;

			// get number of nonDQs
			foreach (var item in data)
				if (item.DQ == false) { nonDQs++; }

			// set bold limit
			if (nonDQs < 5)
				boldLimit = (int)Math.Ceiling(nonDQs / 2);

			// Non DQs
			foreach (var item in data)
			{
				if (item.DQ == false)
				{
					temp = $"{numConv.AddOrdinal(item.Rank)}. {item.Username} {numConv.FormatTime(item.EndFrame - item.StartFrame)}";

					if (item.Rank <= boldLimit)
					{
						output += $"**{temp}**\r\n";
					}
					else
					{
						output += $"{temp}\r\n";
					}
				}
			}

			output += "\r\n";

			// DQs
			foreach (var item in data)
			{
				if (item.DQ == true)
				{
					output += $"DQ. {item.Username} {item.Comments}\r\n";
				}
			}

			// Display in new popup form
			frm_PlainTextPopup ptp = new frm_PlainTextPopup();
			ptp.displayText = output;
			ptp.ShowDialog();
		}

		private void scorePointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure you wish to score points?",
									 "Score confimation",
									 MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
				scoreLeaderboard();
			else { }
		}

		public void scoreLeaderboard()
		{
			// Ask if existing file exists
			// Read points from file
			// Add points, and add to pre-existing points if they exist
			// Save


		}
	}
}