using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskProgresser.WinForms.Forms
{
    public partial class WaitingForm : Form
    {
        public override string Text { get => Label?.Text; set => Label.Text = value; }

        //protected c-tor for implements singleton pattern
        protected WaitingForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Проверяем, передали ли нам форму-владельца
            if (this.Owner != null)
            {
                // Математика центрирования:
                int x = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2;
                int y = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2;

                // Устанавливаем нашу новую позицию
                this.Location = new Point(x, y);
            }
        }

        private void WaitingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
        }

        // static method and fields to show the waiting form

        static public readonly string DEFAULT_MESSAGE = $"Триває оновлення данних!";
        static public readonly string DEFAULT_TIME_MESSAGE = "Це може зайняти близько 30 секунд!";

        static private WaitingForm _waitingForm = new WaitingForm();

        static public void ShowWaitingForm(Form owner, bool blockOwner = true) { ShowWaitingFormWithDefaultTimeMessage(owner, DEFAULT_MESSAGE, blockOwner); }

        static public void ShowWaitingForm(Form owner, string text, bool blockOwner = true)
        {
            if(blockOwner) _waitingForm.BlockOwnerForm();
            _waitingForm.Owner = owner;
            _waitingForm.Text = text;
            _waitingForm.Show();
            _waitingForm.BringToFront();
        }
        
        static public void ShowWaitingFormWithDefaultTimeMessage(Form owner, string text, bool blockOwner = true)
        {
            ShowWaitingForm(owner, $"{text}\n{DEFAULT_TIME_MESSAGE}");
        }

        static public void CloseWaitingForm()
        {
            _waitingForm.Hide();
            _waitingForm.UnblockOwnerForm();
            _waitingForm.Owner = null;
            _waitingForm.Text = null;
        }

        private void BlockOwnerForm()
        {
            var owner = _waitingForm.Owner;
            if(owner == null) return;
            owner.Enabled = false;
            owner.Cursor = Cursors.WaitCursor;
        }

        private void UnblockOwnerForm()
        {
            var owner = _waitingForm.Owner;
            if(owner == null) return;
            owner.Enabled = true;
            owner.Cursor = Cursors.Default;
            owner.BringToFront();
        }

    }
}
