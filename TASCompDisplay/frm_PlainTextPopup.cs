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
	public partial class frm_PlainTextPopup : Form
	{
		public string displayText { get; set; }

		public frm_PlainTextPopup()
		{
			InitializeComponent();
		}

		private void PlainTextPopup_Load(object sender, EventArgs e)
		{
			RefreshDisplay();
		}

		public void RefreshDisplay()
		{
			txt_Display.Text = displayText;
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			RefreshDisplay();
		}

		private void btn_Copy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(displayText);
		}
	}
}
