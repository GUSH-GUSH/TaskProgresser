using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TaskProgresser.WinForms.Forms
{
    public partial class StatisticsForm : Form
    {
        //TODO Сделать Верхние подписи у диаграм частью диаграммы? (Опционально) Может и не надо. Так удобнее менять
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            RenderActiveTasksChart(10, 5, 3);
            RenderCompletedTasksChart(10, 8);
        }

        public void RenderActiveTasksChart(int notStarted, int inProgress, int overdue)
        {
            // Очистка
            CHRT_ActiveTasks.Series.Clear();
            CHRT_ActiveTasks.ChartAreas.Clear();
            CHRT_ActiveTasks.Legends.Clear();

            // 1. НАСТРОЙКА ОБЛАСТИ (ChartArea)
            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;

            // Убираем поля области рисования
            area.Position.Auto = false;
            area.Position.X = 0;
            area.Position.Y = 0;
            area.Position.Width = 100; // 100% ширины
            area.Position.Height = 80; // 80% высоты

            // Убираем внутренние отступы самой круговой диаграммы внутри ChartArea
            area.InnerPlotPosition.Auto = false;
            area.InnerPlotPosition.X = 0;
            area.InnerPlotPosition.Y = 0;
            area.InnerPlotPosition.Width = 100;
            area.InnerPlotPosition.Height = 100;

            CHRT_ActiveTasks.ChartAreas.Add(area);

            // 2. НАСТРОЙКА ЛЕГЕНДЫ
            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = Color.Transparent;
            legend.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            CHRT_ActiveTasks.Legends.Add(legend);

            // 3. НАСТРОЙКА РЯДА ДАННЫХ (Series)
            Series series = new Series("Tasks");
            series.ChartType = SeriesChartType.Doughnut;
            series.ChartArea = "MainArea";
            series["DoughnutRadius"] = "50";
            series["PieLabelStyle"] = "Inside";

            // Настройка шрифта подписей внутри секторов
            series.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            CHRT_ActiveTasks.Series.Add(series);

            // 4. ДОБАВЛЕНИЕ ТОЧЕК ДАННЫХ
            if (notStarted > 0)
            {
                int p1 = series.Points.AddXY("Не розпочаті", notStarted);
                series.Points[p1].Color = Color.DodgerBlue;
                series.Points[p1].Label = "#PERCENT{P0}";
                series.Points[p1].LegendText = $"Не розпочаті ({notStarted})";
            }

            if (inProgress > 0)
            {
                int p2 = series.Points.AddXY("В процесі", inProgress);
                series.Points[p2].Color = Color.Green;
                series.Points[p2].Label = "#PERCENT{P0}";
                series.Points[p2].LegendText = $"В процесі ({inProgress})";
            }

            if (overdue > 0)
            {
                int p3 = series.Points.AddXY("Протерміновані", overdue);
                series.Points[p3].Color = Color.Red;
                series.Points[p3].Label = "#PERCENT{P0}";
                series.Points[p3].LegendText = $"Протерміновані ({overdue})";
            }

            if (notStarted == 0 && inProgress == 0 && overdue == 0)
            {
                int empty = series.Points.AddXY("Немає задач", 1);
                series.Points[empty].Color = Color.WhiteSmoke;
                series.Points[empty].IsVisibleInLegend = false;
                series.Points[empty].Label = "Порожньо";
            }
        }

        public void RenderCompletedTasksChart(int completedInTime, int completedLate)
        {
            // Очистка
            CHRT_CompletedTasks.Series.Clear();
            CHRT_CompletedTasks.ChartAreas.Clear();
            CHRT_CompletedTasks.Legends.Clear();

            // 1. НАСТРОЙКА ОБЛАСТИ (ChartArea)
            ChartArea area = new ChartArea("MainArea");
            area.BackColor = Color.Transparent;

            // Убираем поля области рисования
            area.Position.Auto = false;
            area.Position.X = 0;
            area.Position.Y = 0;
            area.Position.Width = 100; // 100% ширины
            area.Position.Height = 80; // 80% высоты

            // Убираем внутренние отступы самой круговой диаграммы внутри ChartArea
            area.InnerPlotPosition.Auto = false;
            area.InnerPlotPosition.X = 0;
            area.InnerPlotPosition.Y = 0;
            area.InnerPlotPosition.Width = 100;
            area.InnerPlotPosition.Height = 100;

            CHRT_CompletedTasks.ChartAreas.Add(area);

            // 2. НАСТРОЙКА ЛЕГЕНДЫ
            Legend legend = new Legend("MainLegend");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            legend.BackColor = Color.Transparent;
            legend.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            CHRT_CompletedTasks.Legends.Add(legend);

            // 3. НАСТРОЙКА РЯДА ДАННЫХ (Series)
            Series series = new Series("Tasks");
            series.ChartType = SeriesChartType.Doughnut;
            series.ChartArea = "MainArea";
            series["DoughnutRadius"] = "50";
            series["PieLabelStyle"] = "Inside";

            // Настройка шрифта подписей внутри секторов
            series.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            CHRT_CompletedTasks.Series.Add(series);

            // 4. ДОБАВЛЕНИЕ ТОЧЕК ДАННЫХ

            if (completedInTime > 0)
            {
                int p2 = series.Points.AddXY("Виконані вчасно", completedInTime);
                series.Points[p2].Color = Color.Green;
                series.Points[p2].Label = "#PERCENT{P0}";
                series.Points[p2].LegendText = $"Виконані вчасно ({completedInTime})";
            }

            if (completedLate > 0)
            {
                int p3 = series.Points.AddXY("Виконані з запізненням", completedLate);
                series.Points[p3].Color = Color.Red;
                series.Points[p3].Label = "#PERCENT{P0}";
                series.Points[p3].LegendText = $"Виконані з запізненням ({completedLate})";
            }

            if (completedInTime == 0 && completedLate == 0)
            {
                int empty = series.Points.AddXY("Немає задач", 1);
                series.Points[empty].Color = Color.WhiteSmoke;
                series.Points[empty].IsVisibleInLegend = false;
                series.Points[empty].Label = "Порожньо";
            }
        }
    }
}
