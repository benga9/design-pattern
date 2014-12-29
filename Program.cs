using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A15_Ex02_BenGalili_039711056_AmitPaz_040305179
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
