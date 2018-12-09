using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TASCompDisplay
{
	public partial class frm_GraphDisplay : Form
	{
		public List<Competitor> compList { get; set; }
		public List<Scores> scoreList { get; set; }
		public int optionMode { get; set; }

		NumberConverter nc = new NumberConverter();

		public frm_GraphDisplay()
		{
			InitializeComponent();
		}

		private void GraphDisplay_Load(object sender, EventArgs e)
		{
			int population = 0;
			double average = 0;
			double sd = 0;
			double min = 0;
			double max = 0;

			switch (optionMode)
			{
				case 1:
					GraphCompetitionLeaderbaord();

					#region case 1 Data
					population = compList.Count;

					// average
					foreach (var item in compList)
					{
						if (!item.DQ)
						{
							average += item.Frames;

							max = item.Frames;
						}
					}
					average /= population;

					min = compList[0].Frames;

					// min max range label
					lbl_data_min.Text = $"Min: {min} VIs ({nc.FormatTime(min)})";
					lbl_data_max.Text = $"Max: {max} VIs ({nc.FormatTime(max)})";
					lbl_data_range.Text = $"Range: {max - min} VIs ({nc.FormatTime(max - min)})";

					//standard div
					foreach (var item in compList)
						if (!item.DQ)
							sd += Math.Pow((item.Frames - average), 2);
					sd = Math.Sqrt(sd / population);

					// change label display information
					lbl_data_population.Text = $"Data population: {population}";
					lbl_data_average.Text = $"Data average: {average} VIs ({nc.FormatTime(average)})";
					lbl_data_standarddiv.Text = $"Standard deviation: {Math.Round(sd, 5)} VIs ({nc.FormatTime(sd)})";
					#endregion

					break;
				case 2:
					GraphPointLeaderbaord();

					#region case 2 Data
					population = scoreList.Count;

					// average
					foreach (var item in scoreList)
					{
						average += item.Score;
						max = item.Score;
					}
					average /= population;

					min = scoreList[0].Score;

					// min max range label
					lbl_data_min.Text = $"Min: {min} points";
					lbl_data_max.Text = $"Max: {max} points";
					lbl_data_range.Text = $"Range: {min - max} points";

					//standard div
					foreach (var item in scoreList)
						sd += Math.Pow((item.Score - average), 2);
					sd = Math.Sqrt(sd / population);

					// change label display information
					lbl_data_population.Text = $"Data population: {population}";
					lbl_data_average.Text = $"Data average: {average} points";
					lbl_data_standarddiv.Text = $"Standard deviation: {Math.Round(sd, 5)} points";
					#endregion

					break;
				default:
					break;
			}

			

		}

		public void GraphCompetitionLeaderbaord()
		{
			chartGraph.ChartAreas[0].Axes[0].Title = "Rank";
			chartGraph.ChartAreas[0].Axes[1].Title = "VIs";
			chartGraph.Series[0].ChartType = SeriesChartType.Line;
			chartGraph.Series[0].MarkerStyle = MarkerStyle.Circle;
			chartGraph.Series[0].LegendText = "Competition Leaderboard";
			chartGraph.Series[0].BorderWidth = 3;

			for (int i = 0; i < compList.Count; i++)
			{
				if (!compList[i].DQ)
					chartGraph.Series[0].Points.Add(new DataPoint(compList[i].Rank, compList[i].Frames));
			}
		}

		public void GraphPointLeaderbaord()
		{
			chartGraph.ChartAreas[0].Axes[0].Title = "Rank";
			chartGraph.ChartAreas[0].Axes[1].Title = "Points";
			chartGraph.Series[0].ChartType = SeriesChartType.Line;
			chartGraph.Series[0].MarkerStyle = MarkerStyle.Circle;
			chartGraph.Series[0].LegendText = "Points Leaderboard";
			chartGraph.Series[0].BorderWidth = 3;

			for (int i = 0; i < scoreList.Count; i++)
			{
				chartGraph.Series[0].Points.Add(new DataPoint(scoreList[i].Rank, scoreList[i].Score));
			}
		}
	}
}
