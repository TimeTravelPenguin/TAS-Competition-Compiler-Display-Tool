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
	public partial class frm_About : Form
	{
		public frm_About()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://pengu.space");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://twitter.pengu.space");
		}

		private void frm_About_Load(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.Transparent;

			label1.BackColor = Color.Transparent;
			label2.BackColor = Color.Transparent;
			label3.BackColor = Color.Transparent;
			label4.BackColor = Color.Transparent;

			linkLabel1.BackColor = Color.Transparent;
			linkLabel2.BackColor = Color.Transparent;
		}
	}
}
