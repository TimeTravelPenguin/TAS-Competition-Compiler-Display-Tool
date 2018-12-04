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
	// TODO
	// Add indicator to show that the datagrid has been altered and not yet been reranked

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
					ResetCompGrid();

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
					ResetPointGrid();

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
				//int rank = row + 1;
				int rank = -1;
				try { rank = Convert.ToInt32(dataGrid_TASData.Rows[row].Cells[0].Value); }
				catch { rank = -1; }

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

				bool dq;
				try { dq = (bool)dataGrid_TASData.Rows[row].Cells[6].Value; }
				catch { dq = false; }

				//MessageBox.Show(dq.ToString());

				string comments = $"{dataGrid_TASData.Rows[row].Cells[7].Value}";

				Competitor user = new Competitor(rank, username, start, end, rerecs, dq, comments);
				CompetitionList.Add(user);
			}

			return CompetitionList;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetAll();
		}

		public void ResetCompGrid()
		{
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

		public void ResetPointGrid()
		{
			dataGrid_TASPoints.Rows.Clear();

			Refresh();
		}

		public void ResetAll()
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

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_About about = new frm_About();
			about.ShowDialog();
		}

		public void GridSortRank()
		{
			Dictionary<string, int> timeDict = new Dictionary<string, int>();

			// Sort by Frames
			dataGrid_TASData.Sort(dataGrid_TASData.Columns[4], ListSortDirection.Ascending);

			List<Competitor> compList = CompObjectCompile();

			// if a DQ'd run, set to last place
			// Set rank for SORTED list
			int Rank = 1;
			foreach (var item in compList)
			{
				if (item.DQ == true)
				{
					item.Rank = compList.Count();
				}
				else if (item.DQ == false)
				{
					item.Rank = Rank++;
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
			tab_DataGrids.SelectTab(0);
		}

		public void ReRank()
		{
			dataGrid_TASData.EndEdit();
			GridSortRank();
		}

		private void scorePointsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ReRank();

				var confirmResult = MessageBox.Show("Are you sure you wish to score points?",
										 "Score confimation",
										 MessageBoxButtons.YesNo);

				if (confirmResult == DialogResult.Yes)
				{
					scoreLeaderboard();
					tab_DataGrids.SelectTab(1);
				}
				else { }
			}
			catch (Exception err)
			{
				MessageBox.Show($"There was an error\n{err}", "Error...");
			}
		}

		public void scoreLeaderboard()
		{
			// TODO:
			// Ask if existing file exists
			// Read points from file
			// Add points, and add to pre-existing points if they exist
			// Save

			// add loaded scores to listed scores, then sort
			addPoints();

			GridSortPointRank();
		}

		public void addPoints()
		{
			List<Competitor> leaderboard = CompObjectCompile();
			List<Scores> pointsboard = ScoreObjectCompile();

			// check if name is on leaderboard, then add points based on rank.
			// otherwise, add new name to pointsboard

			bool LeaderInPoints = false;
			foreach (var leaderUsername in leaderboard)
			{
				LeaderInPoints = false;

				for (int i = 0; i < pointsboard.Count; i++)
				{
					// if user previously has points && !dq
					if (leaderUsername.Username == pointsboard[i].Username && !leaderUsername.DQ)
					{
						pointsboard[i].Score += ScoreCalc(leaderUsername.Rank, leaderboard.Count);
						LeaderInPoints = true;
					}
					// if user previously has points && dq
					else if (leaderUsername.Username == pointsboard[i].Username && leaderUsername.DQ)
					{
						pointsboard[i].Score += 0;
						LeaderInPoints = true;
					}
				}
				// if new user && !dq
				if (!LeaderInPoints && !leaderUsername.DQ)
				{
					Scores name = new Scores(leaderUsername.Rank, leaderUsername.Username, ScoreCalc(leaderUsername.Rank, leaderboard.Count));
					pointsboard.Add(name);
				}
				// if new user && dq
				else if (!LeaderInPoints && leaderUsername.DQ)
				{
					Scores name = new Scores(leaderUsername.Rank, leaderUsername.Username, 0);
					pointsboard.Add(name);
				}
			}

			dataGrid_TASPoints.Rows.Clear();
			WriteToPointGrid(pointsboard);
		}

		public double ScoreCalc(int place, int total)
		{
			double x = place;
			double a = total;
			double score = (30 / Math.Pow(a, 5)) * Math.Pow((a - x + 1), 5) + ((10 * (a - x + 1) / a)) + 10;
			return Math.Round(score, 1);
		}

		public List<Scores> ScoreObjectCompile()
		{
			List<Scores> ScoreList = new List<Scores>();

			// Sort by points
			try
			{
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
			catch { MessageBox.Show("There was an error with your data", "Error..."); }

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
			dataGrid_TASPoints.Sort(dataGrid_TASPoints.Columns[2], ListSortDirection.Descending);
			List<Scores> scoreList = ScoreObjectCompile();

			// set rank = i
			for (int i = 0; i < scoreList.Count(); i++)
			{
				scoreList[i].Rank = i + 1;
			}

			// check and fix ranks in instances of ties
			for (int i = 1; i < scoreList.Count(); i++)
			{
				double score = scoreList[i].Score;
				double prevScore = scoreList[i - 1].Score;

				// check if dup. If so, set rank to rank of previous item
				if (score == prevScore)
					scoreList[i].Rank = scoreList[i - 1].Rank;
			}

			dataGrid_TASPoints.Rows.Clear();
			WriteToPointGrid(scoreList);
		}

		private void competitionLeaderboardToolStripMenuItem2_Click(object sender, EventArgs e)
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
			if (nonDQs < boldLimit)
				boldLimit = (int)Math.Ceiling(nonDQs / 2);

			// Non DQs
			foreach (var item in data)
			{
				if (item.DQ == false)
				{
					temp = $"{numConv.AddOrdinal(item.Rank)}. {item.Username} {numConv.FormatTime(item.Frames)}";

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

			PopUpDisplay(output);
		}

		private void pointLeaderboardToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var data = ScoreObjectCompile();

			NumberConverter numConv = new NumberConverter();

			string output = "**__Score After Task XX:__**\r\n";
			string temp;

			int boldLimit = 3;
			double total = data.Count;

			// set bold limit
			if (total < boldLimit)
				boldLimit = (int)Math.Ceiling(total / 2);

			// Output
			foreach (var item in data)
			{
				temp = $"{numConv.AddOrdinal(item.Rank)}. {item.Username}: {item.Score}";

				if (item.Rank <= boldLimit)
				{
					output += $"**{temp}**\r\n";
				}
				else
				{
					output += $"{temp}\r\n";
				}
			}

			PopUpDisplay(output);
		}

		public void PopUpDisplay(string output)
		{
			// Display in new popup form
			frm_PlainTextPopup ptp = new frm_PlainTextPopup();
			ptp.displayText = output;
			ptp.ShowDialog();
		}

		private void liveDisplayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReRank();

			// DQcount is used so that DQ's are added from slowest to fastest
			int DQcount = 0;
			var compList = CompObjectCompile();
			for (int i = 0; i < compList.Count; i++)
			{
				if (compList[i].DQ)
				{
					var item = compList[i];
					compList.Remove(compList[i]);
					compList.Insert(DQcount++, item);
					//i--;
				}
			}

			if (compList.Count > 0)
			{
				frm_LiveDisplay ld = new frm_LiveDisplay();
				ld.compList = compList;
				ld.compList.Reverse();
				ld.ShowDialog();
			}
			else
			{
				MessageBox.Show("Please ensure you have at least one competitor in the competition leaderboard", "Not enough competitors");
			}
		}
	}
}
