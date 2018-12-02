using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASCompDisplay
{
	public class Scores
	{
		public int Rank { get; set; }
		public string Username { get; set; }
		public int Score { get; set; }

		public Scores(int rank, string username, int score)
		{
			Rank = rank;
			Username = username;
			Score = score;
		}
	}
}
