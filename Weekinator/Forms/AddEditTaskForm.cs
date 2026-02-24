using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Weekinator.Models;

namespace CourseWork.Forms
{
    public partial class AddEditTaskForm : Form
    {
        private readonly bool isEditMode = false;

        private TaskItem _task;

        public TaskItem Task
        {
            get => _task;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                _task = value;

                txtTitle.Text = Task.Title;
                txtDescription.Text = Task.Description;
                DateRangeControl.SetDateRange(Task.StartDate, Task.EndDate);
                DateRangeControl.Precision = (byte)Task.Precision;
            }
        }

        #region --- SETUP ---

        public AddEditTaskForm(TaskItem task = null)
        {
            InitializeComponent();


            if (task == null)
            {
                isEditMode = false;
                Task = new TaskItem();

                var now = DateTime.Now;
                DateRangeControl.SetDateRange(now, now.AddDays(7));
            }
            else
            {
                isEditMode = true;
                this.Task = task;
            }

            DateRangeControl.UpdateValue(DateTime.Now);
        }

        private void AddEditTaskForm_Load(object sender, EventArgs e)
        {
            ApplyVisualState();
        }

        #endregion


        #region --- VALIDATION ---

        private bool ValidateInputs()
        {
            return ValidateTitle();
        }

        private bool ValidateTitle()
        {
            bool isValid = !string.IsNullOrEmpty(txtTitle.Text);
            if (!isValid) ErrorProvider.SetError(txtTitle, "Поле має містити значення!");
            else ErrorProvider.Clear();
            return isValid;
        }

        #endregion


        #region --- FORM CLOSING ---

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Заповніть необхідні поля!");
                return;
            }

            if (isEditMode) {
                if (MessageBox.Show("Ви дійсно хочете оновити дані?", "Оновити завдання", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    != DialogResult.Yes) return;
            }

            Task.Title = txtTitle.Text;
            Task.Description = txtDescription.Text;
            Task.StartDate = DateRangeControl.DateRange.Start;
            Task.EndDate = DateRangeControl.DateRange.End;

            DialogResult = DialogResult.OK;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

        private void ApplyVisualState()
        {
            if (Task?.IsCompleted ?? false) // CHACK: Task may be not null
            {
                // --- РЕЖИМ ВИКОНАНОЇ ЗАДАЧІ ЗАДАЧИ ---
                LBL_Еfficiency.Visible = true;
                Lbl_CompletedAt.Visible = true;
                DateRangeControl.AutoUpdate = false;
                DateRangeControl.AutoUpdate = false;
                DateRangeControl.UpdateValue(Task.CompletedAt ?? DateTime.Now);
                DateRangeControl.OnValueChanged += (o, a) =>
                {
                    DateRangeControl.UpdateValue(Task.CompletedAt ?? DateTime.Now);
                    LBL_Еfficiency.Text = $"Виконано за {DateRangeControl.Precent}% відведеного часу!";
                };
                Lbl_CompletedAt.Text = $"Дата виконання: {Task.CompletedAt?.ToString("g")}";

                UpdateCompletePrecentage();
            }
            else
            {
                // --- РЕЖИМ АКТИВНОЇ ЗАДАЧІ ---
                LBL_Еfficiency.Visible = false;
                Lbl_CompletedAt.Visible = false;
            }
        }

        void UpdateCompletePrecentage() => LBL_Еfficiency.Text = $"Виконано за {Task.EfficiencyPercentage}% відведеного часу!";

    }
}
