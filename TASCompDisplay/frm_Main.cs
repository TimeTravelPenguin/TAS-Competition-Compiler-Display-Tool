using System;
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
	public partial class frm_Main : Form
	{
		File f = new File();

		public frm_Main()
		{
			InitializeComponent();
		}

		private void competitionLeaderboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveComp();
		}

		private void pointLeaderboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveScores();
		}

		public void SaveComp()
		{
			dataGrid_TASData.EndEdit();

			List<Competitor> CompetitionList = CompObjectCompile();

			var savedata = JsonConvert.SerializeObject(CompetitionList);

			f.Save_TASc(savedata);
		}

		public void SaveScores()
		{
			dataGrid_TASPoints.EndEdit();

			List<Scores> ScoreList = ScoreObjectCompile();

			var savedata = JsonConvert.SerializeObject(ScoreList);

			f.Save_TASs(savedata);
		}

		private void competitionLeaderboardToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenComp();
		}

		private void pointLeaderboardToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenPoints();
		}

		public void OpenComp()
		{
			bool readyToLoad;
			string path;
			string contents;

			(readyToLoad, path, contents) = f.Load_TASc();
			toolStripStatusLabel_OpenedFile.Text = f.filePath;

			if (readyToLoad)
			{
				try
				{
					ResetComp();

					List<Competitor> competitionList = JsonConvert.DeserializeObject<List<Competitor>>(contents);

					WriteToDataGrid(competitionList);
				}
				catch (Exception e)
				{
					MessageBox.Show($"Error parsing competition file\n\n{e}", "Error reading file...");
				}
			}

			// Sort ranks
			GridSortRank();
		}

		public void OpenPoints()
		{
			bool fileLoaded;
			string contents;

			(fileLoaded, contents) = f.Load_TASs();
			toolStripStatusLabel_OpenedFile.Text = f.filePath;

			if (fileLoaded)
			{
				try
				{
					ResetPoints();

					List<Scores> pointsList = JsonConvert.DeserializeObject<List<Scores>>(contents);

					WriteToPointGrid(pointsList);
				}
				catch (Exception e)
				{
					MessageBox.Show($"Error parsing score file\n\n{e}", "Error reading file...");
				}
			}

			// Sort ranks
			GridSortPointRank();
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
				row.Cells[4].Value = item.Frames;
				row.Cells[5].Value = item.Rerecords;
				row.Cells[6].Value = item.DQ;
				row.Cells[7].Value = item.Comments;

				dataGrid_TASData.Rows.Add(row);
			}

			// Sort by Rank
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
			List<Competitor> singleCompetitor = new List<Competitor>();

			var Username = txt_addUsername.Text.Trim();

			var Start = 0;
			try { Start = Convert.ToInt32(txt_addStartFrame.Text.Trim()); } catch { Start = -1; }

			var End = 0;
			try { End = Convert.ToInt32(txt_addEndFrame.Text.Trim()); } catch { End = -1; }

			var Rerecs = 0;
			try { Rerecs = Convert.ToInt32(txt_addRerecords.Text.Trim()); } catch { Rerecs = -1; }

			var DQ = false;
			var Comment = "";

			if (checkBox_DQ.Checked)
			{
				DQ = true;
				Comment = DQString();
			}
			else
			{
				DQ = false;
				Comment = "";
			}

			Competitor newCompetitor = new Competitor(1, Username, Start, End, Rerecs, DQ, Comment);
			singleCompetitor.Add(newCompetitor);
			WriteToDataGrid(singleCompetitor);

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
				try { rerecs = Convert.ToInt32(dataGrid_TASData.Rows[row].Cells[5].Value); }
				catch { rerecs = -1; }

				string username = $"{dataGrid_TASData.Rows[row].Cells[1].Value}";

				bool dq = (bool)dataGrid_TASData.Rows[row].Cells[6].Value;

				//MessageBox.Show(dq.ToString());

				string comments = $"{dataGrid_TASData.Rows[row].Cells[7].Value}";

				Competitor user = new Competitor(rank, username, start, end, rerecs, dq, comments);
				CompetitionList.Add(user);
			}

			return CompetitionList;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetComp();
		}

		public void ResetComp()
		{
			dataGrid_TASData.Rows.Clear();
			dataGrid_TASPoints.Rows.Clear();

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

		public void ResetPoints()
		{
			dataGrid_TASPoints.Rows.Clear();

			Refresh();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_About about = new frm_About();
			about.ShowDialog();
		}

		public void GridSortRank()
		{
			Dictionary<string, int> timeDict = new Dictionary<string, int>();

			// sort compList 
			//List<Competitor> SortedCompList = compList.OrderBy(x => x.Frames).ToList();
			
			// Sort by Frames
			dataGrid_TASData.Sort(dataGrid_TASData.Columns[4], ListSortDirection.Ascending);

			List<Competitor> compList = CompObjectCompile();

			// set rank = i
			// if a DQ'd run, set to last place
			int Rank = 1;
			for (int i = 0; i < compList.Count(); i++)
			{
				if (compList[i].DQ == true)
				{
					compList[i].Rank = compList.Count();
				}

				else if (compList[i].DQ == false)
				{
					compList[i].Rank = Rank++;
				}

			}

			// check and fix ranks in instances of ties
			for (int i = 1; i < compList.Count(); i++)
			{
				int time = compList[i].Frames;
				int prevtime = compList[i - 1].Frames;

				// check if dup. If so, set rank to rank of previous item
				// ignores DQs
				if (time == prevtime && compList[i].DQ == false)
					compList[i].Rank = compList[i - 1].Rank;
			}


			dataGrid_TASData.Rows.Clear();
			WriteToDataGrid(compList);
		}

		private void rerankBoardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReRank();
		}

		public void ReRank()
		{
			dataGrid_TASData.EndEdit();
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
			// TODO:
			// Ask if existing file exists
			// Read points from file
			// Add points, and add to pre-existing points if they exist
			// Save

			// add loaded scores to listed scores, then sort
			GridSortPointRank();
		}

		public double ScoreCalc(int place, int total)
		{
			double score = ((30 / Math.Pow(total, 5)) * Math.Pow((total - place + 1), 5)) + (10 * ((total - place + 1) / total)) + 10;
			return score;
		}

		public List<Scores> ScoreObjectCompile()
		{
			List<Scores> ScoreList = new List<Scores>();

			// Sort by points
			try
			{
				dataGrid_TASPoints.Sort(dataGrid_TASData.Columns[2], ListSortDirection.Ascending);

				for (int row = 0; row < dataGrid_TASPoints.Rows.Count - 1; row++)
				{
					int rank = row + 1;

					string username = $"{dataGrid_TASPoints.Rows[row].Cells[1].Value}";

					double score = 0;
					try { score = Convert.ToDouble(dataGrid_TASPoints.Rows[row].Cells[2].Value); }
					catch { score = -1; }

					Scores user = new Scores(rank, username, score);
					ScoreList.Add(user);
				}
			}
			catch { }

			return ScoreList;
		}

		public void WriteToPointGrid(List<Scores> scoresList)
		{
			foreach (var item in scoresList)
			{
				DataGridViewRow row = (DataGridViewRow)dataGrid_TASPoints.Rows[0].Clone();

				row.Cells[0].Value = item.Rank;
				row.Cells[1].Value = item.Username;
				row.Cells[2].Value = item.Score;

				dataGrid_TASPoints.Rows.Add(row);
			}

			// Sort by rank
			dataGrid_TASPoints.Sort(dataGrid_TASPoints.Columns[0], ListSortDirection.Ascending);
		}

		public void GridSortPointRank()
		{
			List<Scores> scoreList = ScoreObjectCompile();

			// sort compList 
			List<Scores> SortedScoreList = scoreList.OrderBy(x => x.Score).ToList();

			// set rank = i
			for (int i = 0; i < SortedScoreList.Count(); i++)
			{
				SortedScoreList[i].Rank = i;
			}

			// check and fix ranks in instances of ties
			for (int i = 1; i < scoreList.Count(); i++)
			{
				double score = SortedScoreList[i].Score;
				double prevScore = SortedScoreList[i - 1].Score;

				// check if dup. If so, set rank to rank of previous item
				if (score == prevScore)
					SortedScoreList[i].Rank = SortedScoreList[i - 1].Rank;
			}

			dataGrid_TASData.Rows.Clear();
			WriteToPointGrid(SortedScoreList);
		}

		private void dataGrid_TASData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ReRank();
		}
	}
}
