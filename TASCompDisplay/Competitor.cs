using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASCompDisplay
{
	public class Competitor
	{
		public int Rank { get; set; }
		public string Username { get; set; }
		public int StartFrame { get; set; }
		public int EndFrame { get; set; }
		public int Rerecords { get; set; }
		public string DQ { get; set; }
		public string Comments { get; set; }

		public Competitor(int rank, string username, int startframe, int endframe, int rerecords, string dq, string comments)
		{
			Rank = rank;
			Username = username;
			StartFrame = startframe;
			EndFrame = endframe;
			Rerecords = rerecords;
			DQ = dq;
			Comments = comments;
		}
	}
}
