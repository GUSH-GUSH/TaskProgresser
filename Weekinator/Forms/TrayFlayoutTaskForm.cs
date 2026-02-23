using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weekinator.Models;

namespace Weekinator.Forms
{
    public partial class TrayFlayoutTaskForm : Form
    {

        #region --- SETUP ---

        public TrayFlayoutTaskForm()
        {
            InitializeComponent();
        }

        public TrayFlayoutTaskForm(TaskItem task) : this()
        {
            Task = task;
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
            }
        }

        #endregion

    
    }
}
