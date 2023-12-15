using System;
using System.Windows.Forms;
using VLU231_71SEOO30074_03.src.GUI;

namespace VLU231_71SEOO30074_03
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
