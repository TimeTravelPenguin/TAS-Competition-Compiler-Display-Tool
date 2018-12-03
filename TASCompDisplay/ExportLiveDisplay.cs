using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASCompDisplay
{
	class ExportLiveDisplay
	{
		// Check if file exists in settings directory
		// on each < or > successful click, update the file contents

		public void SaveFile(string data)
		{
			string dir = Properties.Settings.Default.dir;

			if (System.IO.File.Exists(dir))
			{
				System.IO.File.WriteAllText(dir, data);
			}
			else
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Text File (*.txt)|*.txt";
				sfd.DefaultExt = "txt";
				sfd.AddExtension = true;
				sfd.ShowDialog();
				try
				{
					Properties.Settings.Default.dir = Path.GetFullPath(sfd.FileName);
					System.IO.File.WriteAllText(Properties.Settings.Default.dir, data);
					Properties.Settings.Default.Save();
				}
				catch (Exception) { }
			}

			
		}
	}
}
