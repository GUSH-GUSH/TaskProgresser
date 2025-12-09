using DateTimeToolKit.Models.DateRange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Weekinator.Services;

namespace Weekinator
{
    public partial class MainForm : Form
    {
        #region --- fields ---

        private System.Windows.Forms.Timer timer;

        #endregion


        #region --- setup ---

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //КУРС 4.1

            DateTime start = new DateTime(2025, 09, 01, 8, 0, 0);
            DateTime end = new DateTime(2025, 12, 19, 17, 0, 0);
            DateRange dateRange = new DateRange(start, end);


            DateRangeControl.SetDateRange(dateRange);
            DateRangeControl.UpdateValue(DateTime.Now);


            IconsSetup();

            //Бакалавриат
            DateTime start1 = new DateTime(2022, 09, 01, 8, 0, 0);
            DateTime end1 = new DateTime(2026, 06, 30, 17, 0, 0);
            DateRange dateRange1 = new DateRange(start1, end1);


            TSKCNTRL_Bakalavr.DateRangeControl.SetDateRange(dateRange1);
            TSKCNTRL_Bakalavr.DateRangeControl.UpdateValue(DateTime.Now);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += (obj, eventArgs) => UpdateTimers();
            timer.Start();

            TSKCNTRL_Bakalavr.Size = new Size(518, 150);
        }

        private void IconsSetup()
        {
            DateRangeControl.PrecentIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;
            DateRangeControl.WeekMarkIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;

            DateRangeControl.IconMainMenu_CloseItem.Click += IconMainMenu_CloseItem_Click;
            DateRangeControl.IconMainMenu_OpenItem.Click += IconMainMenu_OpenItem_Click;
        }

        #endregion


        #region --- timer ---

        public void UpdateTimers()
        {
            DateRangeControl.UpdateValue(DateTime.Now);
            TSKCNTRL_Bakalavr.DateRangeControl.UpdateValue(DateTime.Now);

            CurrentDateTime_Label.Text = DateTime.Now.ToString();
        }

        #endregion


        #region --- events ---

        #region --- events_icons ---

        private void PrecentIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible == true)
            {
                this.Hide();
                //WeekMark_Icon.ShowBalloonTip(5000, "Weekinator активен!", "Приложение работает в фоновом режиме!", ToolTipIcon.None);
            }
            else this.Show();
        }

        private void IconMainMenu_CloseItem_Click(object sender, EventArgs e) => Application.Exit();
        private void IconMainMenu_OpenItem_Click(object sender, EventArgs e) => Show();

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason == CloseReason.UserClosing;
            this.Visible = false;
        }

        private void openTestIconForm_Button_Click(object sender, EventArgs e)
        {
            new Forms.DebugForms.TextIconTestForm().Show(this);
        }

        #endregion

    }
}
