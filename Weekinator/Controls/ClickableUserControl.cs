using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskProgresser.Controls
{
    public partial class ClickableUserControl : UserControl
    {
        public ClickableUserControl()
        {
            InitializeComponent();
        }

        private void WireUpClickEvents(Control parentControl)
        {
            foreach (Control child in parentControl.Controls)
            {
                if (IsInteractiveControl(child)) continue;

                child.Click += ChildControl_Click;
                child.DoubleClick += ChildControl_DoubleClick;

                // Рекурсивно идем вглубь
                if (child.HasChildren) WireUpClickEvents(child);
            }
        }

        private void ChildControl_Click(object sender, EventArgs e) => this.OnClick(e);
        private void ChildControl_DoubleClick(object sender, EventArgs e) => this.OnDoubleClick(e);

        private bool IsInteractiveControl(Control control)
        {
            return control is ButtonBase ||
                   // Button, CheckBox, RadioButton
                   control is TextBoxBase ||
                   // TextBox, RichTextBox, MaskedTextBox
                   control is ListControl ||
                   // ListBox, ComboBox
                   control is UpDownBase ||
                   // NumericUpDown, DomainUpDown
                   control is TrackBar ||
                   control is ProgressBar ||
                   control is DateTimePicker ||
                   control is MonthCalendar ||
                   control is TreeView ||
                   control is ListView ||  
                   control is DataGridView ||
                   control is ScrollBar;
        }

        private void ClickableUserControl_Load(object sender, EventArgs e)
        {
            WireUpClickEvents(this);
        }
    }
}
