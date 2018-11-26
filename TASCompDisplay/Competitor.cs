using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASCompDisplay
{
	class Competitor
	{
		public string Username { get; set; }
		public string StartFrame { get; set; }
		public string EndFrame { get; set; }
		public string Rerecords { get; set; }
		public string DQ { get; set; }
		public string Comments { get; set; }

		public Competitor(string username, string startframe, string endframe, string rerecords, string dq, string comments)
		{
			Username = username;
			StartFrame = startframe;
			EndFrame = endframe;
			Rerecords = rerecords;
			DQ = dq;
			Comments = comments;
		}
	}
}
