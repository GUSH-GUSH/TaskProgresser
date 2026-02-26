using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskProgresser
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoUpdater.Start("https://raw.githubusercontent.com/GUSH-GUSH/Weekinator/main/update.xml");
            Application.Run(new MainForm());
        }
    }
}
