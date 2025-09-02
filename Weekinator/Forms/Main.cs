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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace Weekinator
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SetDateRange(new DateTime(2025, 02, 03), new DateTime(2025, 06, 23));

            DateTime point = DateTime.Now;
            
            Debug.WriteLine("");

            Debug.WriteLine($"Range: {dateRange}");
            Debug.WriteLine($"Date: {point}");
            Debug.WriteLine($"Day of semester: {dateRange.GetDayOf(point)}/{dateRange.TotalDays}");
            Debug.WriteLine($"Num of week: {dateRange.GetWeekOf(point)}/{dateRange.TotalWeeks}");
            Debug.WriteLine($"Day of week: {point.DayOfWeek}");
            Debug.WriteLine($"Total precent: {Math.Round(dateRange.GetFractionOf(point) * 100, 3)}%");
            Debug.WriteLine($"Week mark: " + ((dateRange.GetWeekOf(point) % 2 == 0) ? "Znamenyk" : "Chiselnyk"));

            //fract = dateRange.GetFractionOf(point);

            //UpdatePrecentLabelText();
            //UpdatePrecentLabelLocation();
            //UpdateMainProgressBarValue();
            //int count = 0;

            dateRangeControl1.SetDateRange(dateRange);

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (obj, eventArgs) => {
                dateRangeControl1.GetFractionOf(DateTime.Now);
                Update();
                label_update();
            };
            timer.Start();*/
            comboBox1_initialize();
            comboBox2_initialize();

            UpdateIcon();


            dateRangeControl1.SetDateRange(new DateTime(2025, 02, 03), new DateTime(2025, 06, 23));
            dateRangeControl1.UpdateValue(DateTime.Now);
            
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += (obj, eventArgs) => {
                dateRangeControl1.UpdateValue(DateTime.Now);
            };
            timer.Start();
        }

        private void UpdateIcon() {
            notifyIcon1.Icon = CreateIcon(textBox1.Text, new Font((FontFamily)comboBox1.SelectedValue, (float)numericUpDown1.Value, (FontStyle)Enum.Parse(typeof(FontStyle), comboBox2.SelectedValue?.ToString() ?? "Bold")));
        }

        private Icon CreateIcon(string text, Font font) {

            Bitmap bitmap = new Bitmap(32, 32, PixelFormat.Format32bppArgb);
           
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Transparent); // Очищаем фон, делаем его прозрачным

                // Настраиваем шрифт и кисть
                //using (Font font = new Font("Segoe UI", 12, FontStyle.Bold))
                //{
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        // Рисуем текст в центре
                        SizeF size = g.MeasureString(text, font);
                        float x = 16 - size.Width / 2;
                        float y = 16 - size.Height / 2;
                        g.DrawString(text, font, brush, x, y);
                    }
                //}
            }

            // Создаём Icon из Bitmap. Это и есть решение!
            IntPtr hIcon = bitmap.GetHicon();
            Icon icon = Icon.FromHandle(hIcon);

            // Важно: нужно освободить ресурсы Bitmap после использования
            bitmap.Dispose();




            return icon;
        }

        private void label_update() {
            //label1.Text = DateTime.Now.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        private void comboBox1_initialize() {
            comboBox1.Items.Clear();

            InstalledFontCollection installedFont = new InstalledFontCollection();
            comboBox1.DataSource = installedFont.Families;
            comboBox1.DisplayMember = "Name";

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox2_initialize()
        {
            comboBox2.Items.Clear();

            comboBox2.DataSource = Enum.GetNames(typeof(FontStyle));

            comboBox2.SelectedIndex = 0;
        }

    
        /*
private JSON
*/
    }
}
