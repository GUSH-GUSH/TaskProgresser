using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weekinator.Services;

namespace Weekinator.Forms.DebugForms
{
    public partial class TextIconTestForm : Form
    {
        public readonly Size IconSize = new Size(32, 32);

        public TextIconTestForm()
        {
            InitializeComponent();
        }

        private void TextIconTestForm_Load(object sender, EventArgs e)
        {
            fontFamily_ComboBox_initialize();
            fontStyle_ComboBox_initialize();

            UpdateIcon();
        }

        private void UpdateIcon()
        {
            NotifyIcon.Icon = IconGenerator.GetIcon(
                                iconText_TextBox.Text,
                                new Font(
                                        (FontFamily)fontFamily_ComboBox.SelectedValue,
                                        (float)fontSize_NumericUpDown.Value,
                                        (FontStyle)Enum.Parse(
                                            typeof(FontStyle),
                                            fontStyle_ComboBox.SelectedValue?.ToString() ?? "Regular"
                                        )
                                ),
                                IconSize
                            );
        }

        private void fontFamily_ComboBox_initialize()
        {
            fontFamily_ComboBox.Items.Clear();

            InstalledFontCollection installedFont = new InstalledFontCollection();
            fontFamily_ComboBox.DataSource = installedFont.Families;
            fontFamily_ComboBox.DisplayMember = "Name";

            fontFamily_ComboBox.SelectedIndex = 0;
        }

        private void fontStyle_ComboBox_initialize()
        {
            fontStyle_ComboBox.Items.Clear();
            fontStyle_ComboBox.DataSource = Enum.GetNames(typeof(FontStyle));
            fontStyle_ComboBox.SelectedIndex = 0;
        }


        private void fontSize_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void iconText_TextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void fontFamily_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void fontStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }
    }
}
