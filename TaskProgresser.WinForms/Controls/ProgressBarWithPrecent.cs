using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskProgresser.WinForms.Controls
{
    public partial class ProgressBarWithPrecent : UserControl
    {
        private double _percent;

        public double Percent
        {
            get => _percent;
            set
            {
                if (value < 0) return;
                _percent = value;
                UpdateVisual();
            }
        }

        private double Fract => Percent / 100.0;

        public ProgressBarWithPrecent()
        {
            InitializeComponent();
        }

        private void UpdateVisual()
        {
            MainProgressBar.Value = Math.Min(
                (int)(Fract * MainProgressBar.Maximum),
                MainProgressBar.Maximum
            );
            PrecentLabel.Text = $"{Percent:F2}%";

            if (Percent > 100) PrecentLabel.ForeColor = Color.Red;
            else PrecentLabel.ForeColor = Color.Green;

            UpdatePrecentLabelLocation();
        }

        private void UpdatePrecentLabelLocation()
        {
            PrecentLabel.Location = new Point(
                x: (int)(MainProgressBar.Location.X - PrecentLabel.Size.Width / 2 + MainProgressBar.Size.Width * Math.Min(Fract, 1.0)),
                y: PrecentLabel.Location.Y
            );
        }
    }
}
