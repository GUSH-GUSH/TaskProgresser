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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weekinator.Forms;
using Weekinator.Forms.UserControls;
using Weekinator.Models;
using Weekinator.Repositories;
using Weekinator.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Weekinator
{
    public partial class MainForm : Form
    {
        #region --- fields ---

        //private System.Windows.Forms.Timer timer;
        // Предполагаю, что у тебя есть общий список всех задач
        private List<TaskItem> _allTasks = new List<TaskItem>();

        
        #endregion

        #region --- setup ---

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            //КУРС 4.1

            DateTime start = new DateTime(2026, 02, 02, 8, 0, 0);
            DateTime end = new DateTime(2026, 02, 28, 17, 0, 0);
            DateRange dateRange = new DateRange(start, end);


            TSKCTRL_Semestr.DateRangeControl.SetDateRange(dateRange);
            TSKCTRL_Semestr.DateRangeControl.UpdateValue(DateTime.Now);



            //Бакалавриат
            DateTime start1 = new DateTime(2022, 09, 01, 8, 0, 0);
            DateTime end1 = new DateTime(2026, 06, 30, 17, 0, 0);
            DateRange dateRange1 = new DateRange(start1, end1);


            TSKCNTRL_Bakalavr.DateRangeControl.SetDateRange(dateRange1);
            TSKCNTRL_Bakalavr.DateRangeControl.UpdateValue(DateTime.Now);

            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = 500;
            //timer.Tick += (obj, eventArgs) => UpdateTimers();
            //timer.Start();

            //IconsSetup();
            */

            LoadData();

            ProgressUpdaterService.Start();
        }

        private void IconsSetup()
        {
         //   TSKCTRL_Semestr.DateRangeControl.PrecentIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;
         //   TSKCTRL_Semestr.DateRangeControl.WeekMarkIcon.MouseDoubleClick += PrecentIcon_MouseDoubleClick;

            TSKCTRL_Semestr.DateRangeControl.IconMainMenu_CloseItem.Click += IconMainMenu_CloseItem_Click;
            TSKCTRL_Semestr.DateRangeControl.IconMainMenu_OpenItem.Click += IconMainMenu_OpenItem_Click;
        }
        
        private void LoadData()
        {
            _allTasks = JsonTaskSeializer.LoadTasks();
            RenderTasks();
        }

        // Метод, который отрисовывает задачи на экране
        private void RenderTasks()
        {
            // (По-хорошему тут еще нужно вызывать .Dispose() для старых контролов, но для MVP пока оставим так)
            FlowPanel_Active.Controls.Clear();
            FlowPanel_Completed.Controls.Clear();

            foreach (var taskModel in _allTasks)
            {
                TaskControl taskControl = new TaskControl(taskModel);

                if (taskModel.IsCompleted)
                    FlowPanel_Completed.Controls.Add(taskControl);
                else
                    FlowPanel_Active.Controls.Add(taskControl);
                
                //UpdateWidth();
            }
        }

        #endregion


        #region --- timer ---

        public void UpdateTimers()
        {
            TSKCTRL_Semestr.DateRangeControl.UpdateValue(DateTime.Now);
            TSKCNTRL_Bakalavr.DateRangeControl.UpdateValue(DateTime.Now);

            Label_CurrentDateTime.Text = DateTime.Now.ToString();
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

        private void TSKCTRL_Semestr_DoubleClick(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            TrayFlayoutTaskForm _flyoutForm = new TrayFlayoutTaskForm(new Models.TaskItem() { Title = TSKCTRL_Semestr.Title,
                                                                                            StartDate = TSKCTRL_Semestr.DateRange.Start,                
                                                                                            EndDate = TSKCTRL_Semestr.DateRange.End,
            });

            int x = workingArea.Right - _flyoutForm.Width;
            int y = workingArea.Bottom - _flyoutForm.Height;

            _flyoutForm.Location = new Point(x, y);

            _flyoutForm.Show();
            _flyoutForm.Activate();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            JsonTaskSeializer.SaveTasks(new List<TaskItem>() {
                    new TaskItem {
                        Title = TSKCTRL_Semestr.Title,
                        Description = "",
                        StartDate = TSKCTRL_Semestr.Start,
                        EndDate = TSKCTRL_Semestr.End,
                    },
                    new TaskItem {
                        Title = TSKCNTRL_Bakalavr.Title,
                        Description = "",
                        StartDate = TSKCNTRL_Bakalavr.Start,
                        EndDate = TSKCNTRL_Bakalavr.End,
                    }
                });
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
    }
}
