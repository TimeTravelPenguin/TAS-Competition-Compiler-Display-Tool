using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASCompDisplay
{
	class File
	{
		public string fileName { get; set; }
		public string filePath { get; set; }

		public (bool, string) Load()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "TAS Comp File (*.TASc)|*.TASc";
			ofd.ShowDialog();

			try
			{
				fileName = ofd.FileName;
				filePath = Path.GetFullPath(fileName);
				string extension = Path.GetExtension(filePath);

				if (extension == ".txt" || extension == ".TASc") { return (true, filePath); }
				else
				{
					fileName = "";
					filePath = "";
					MessageBox.Show("Please open a valid .TASc file", "Error opening file...");
					return (false, filePath);
				}
			}
			catch { fileName = "No File Loaded..."; }
			return (false, filePath);
		}

		public void Save(string savedata)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "TAS Comp File (*.TASc)|*.TASc";
			sfd.DefaultExt = "TASc";
			sfd.AddExtension = true;
			sfd.ShowDialog();

			string path = Path.GetFullPath(sfd.FileName);

			System.IO.File.WriteAllText(path, savedata);
		}
	}
}
