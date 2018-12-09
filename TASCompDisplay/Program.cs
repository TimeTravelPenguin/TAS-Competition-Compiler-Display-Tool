using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TASCompDisplay
{
	static class Program
	{
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        static PrivateFontCollection Fonts = new PrivateFontCollection();
        public static Font SuperMario256;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
            uint dummy = 0;
            byte[] fontData = Properties.Resources.SuperMario256;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            Fonts.AddMemoryFont(fontPtr, Properties.Resources.SuperMario256.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.SuperMario256.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
            SuperMario256 = new Font(Fonts.Families[0], 16.0F);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_Main());
		}
	}
}
