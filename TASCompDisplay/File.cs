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
		public string contents { get; set; }

		public (bool, string, string) Load_TASc()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "TAS Comp File (*.TASc)|*.TASc";
			ofd.ShowDialog();

			try
			{
				fileName = ofd.FileName;
				filePath = Path.GetFullPath(fileName);
				string extension = Path.GetExtension(filePath);

				if (extension == ".txt" || extension == ".TASc")
				{
					// base64 decode
					contents = Base64Decode(System.IO.File.ReadAllText(filePath));
					return (true, filePath, contents);
				}
				else
				{
					fileName = "";
					filePath = "";
					MessageBox.Show("Please open a valid .TASc file", "Error opening file...");
					return (false, filePath, "");
				}
			}
			catch { fileName = "No File Loaded..."; }
			return (false, filePath, "");
		}

		public void Save_TASc(string savedata)
		{
			// base64 encode
			savedata = Base64Encode(savedata);

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "TAS Comp File (*.TASc)|*.TASc";
			sfd.DefaultExt = "TASc";
			sfd.AddExtension = true;
			sfd.ShowDialog();
			try
			{
				string path = Path.GetFullPath(sfd.FileName);

				System.IO.File.WriteAllText(path, savedata);
			}
			catch (Exception) { }
		}

		public (bool, string) Load_TASs()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "TAS Score File (*.TASs)|*.TASs";
			ofd.ShowDialog();

			try
			{
				fileName = ofd.FileName;
				filePath = Path.GetFullPath(fileName);
				string extension = Path.GetExtension(filePath);

				if (extension == ".txt" || extension == ".TASs")
				{
					// base64 decode
					contents = Base64Decode(System.IO.File.ReadAllText(filePath));
					return (true, contents);
				}
				else
				{
					fileName = "";
					MessageBox.Show("Please open a valid .TASs file", "Error opening file...");
					return (false, "");
				}
			}
			catch { fileName = "No File Loaded..."; }
			return (false, "");
		}

		public void Save_TASs(string savedata)
		{
			// base64 encode
			savedata = Base64Encode(savedata);

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "TAS Score File (*.TASs)|*.TASs";
			sfd.DefaultExt = "TASs";
			sfd.AddExtension = true;
			sfd.ShowDialog();
			try
			{
				string path = Path.GetFullPath(sfd.FileName);

				System.IO.File.WriteAllText(path, savedata);
			}
			catch (Exception) { }
		}

		public static string Base64Encode(string plainText)
		{
			var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(plainTextBytes);
		}

		public static string Base64Decode(string base64EncodedData)
		{
			var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(base64EncodedBytes);
		}
	}
}
