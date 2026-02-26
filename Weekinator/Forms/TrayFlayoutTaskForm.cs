using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskProgresser.Models;

namespace TaskProgresser.Forms
{
    public partial class TrayFlayoutTaskForm : Form
    {

        #region --- SETUP ---

        public TrayFlayoutTaskForm()
        {
            InitializeComponent();
            SetDefaultPosition();
        }

        public TrayFlayoutTaskForm(TaskItem task) : this()
        {
            Task = task;
        }

        private void SetDefaultPosition() {
            var screenSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;

            Location = new Point(
                screenSize.Width - this.Size.Width,
                screenSize.Height - this.Size.Height
                );
        }

        #endregion

        #region--- Events Handlers ---

        private void TrayFlayoutTaskForm_Load(object sender, EventArgs e)
        {
            DateRangeControl.UpdateValue(DateTime.Now);
        }

        private void TrayFlayoutTaskForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region --- FIELDS & PROPERTY ---

        private TaskItem _task;
        public TaskItem Task
        {
            get => _task;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                _task = value;

                Title.Text = Task.Title;
                DateRangeControl.SetDateRange(Task.StartDate, Task.EndDate);
                DateRangeControl.Precision = (byte)Task.Precision;
            }
        }

        #endregion
    
    }
}
