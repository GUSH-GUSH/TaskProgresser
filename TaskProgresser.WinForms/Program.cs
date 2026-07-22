using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TaskProgresser.WinForms.Services;

namespace TaskProgresser.WinForms
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

            //InitializeAutoUpdater();

            // Делаем обновление обязательным
            InitializeAutoUpdater();
            while (!Update())
                if (MessageBox.Show("Програма не оновилася. Стара версія більше не підтримується!\nЧи бажаєте ви закрити програму?", "Неможливо іти далі!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    return;
            try { Application.Run(new MainForm()); }
            catch (Exception ex){ MessageBox.Show(text:ex.Message, caption:"Критична помилка!"); Application.Exit(); }
        }

        //FIX: Move autoupdate logic to a separate class
        private static Version newVersion;

        private static void InitializeAutoUpdater() {
            AutoUpdater.Mandatory = true;
            AutoUpdater.Synchronous = true;

            AutoUpdater.CheckForUpdateEvent += (UpdateInfoEventArgs args) =>
            {
                newVersion = new Version(args.CurrentVersion.ToString());
                if (args.Error == null && newVersion > VersionGetter.Version) AutoUpdater.ShowUpdateForm(args);
            };
        }

        private static bool Update()
        {

            string cacheBuster = DateTime.Now.Ticks.ToString();
            string updateUrl = $"https://raw.githubusercontent.com/GUSH-GUSH/TaskProgresser/refs/heads/main/update.xml?t={cacheBuster}";

            AutoUpdater.Start(updateUrl);
            return VersionGetter.Version >= newVersion;
        }
    }
}   
