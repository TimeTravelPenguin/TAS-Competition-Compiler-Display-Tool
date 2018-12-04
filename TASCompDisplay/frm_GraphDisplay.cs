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

		public frm_GraphDisplay()
		{
			InitializeComponent();
		}

		private void GraphDisplay_Load(object sender, EventArgs e)
		{
			switch (optionMode)
			{
				case 1:
					GraphCompetitionLeaderbaord();
					break;
				case 2:
					GraphPointLeaderbaord();
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
