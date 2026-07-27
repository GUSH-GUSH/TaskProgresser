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
using TaskProgresser.Core.DTOs;
using TaskProgresser.WinForms.Repositories.ApiClients;

namespace TaskProgresser.WinForms.Forms
{
    public partial class StatisticsForm : Form
    {
        private StatisticsApiClient _statisticsApiClient;
        private bool IsLoading { get => !this.Enabled; }

        #region --- Setup ---

        public StatisticsForm()
        {
            InitializeComponent();
            _statisticsApiClient = new StatisticsApiClient();
            BaseApiClient.OnUnathorized += HandleUnauthorized;
        }

        private async void StatisticsForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await UpdateStatistics();
            this.Enabled = true;
        }

        #endregion --- Setup  ---

        #region --- Visual ---

        public void SetAvarageCompletedPercent(double percent)
        {
            PBWP_AveragePercent.Percent = percent;
        }

        public void SetHeader(int active, int completed, int total) {
            LBL_Active.Text = active.ToString();
            LBL_Completed.Text = completed.ToString();
            LBL_Total.Text = total.ToString();
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

            if (notStarted == 0 && inProgress == 0 && overdue == 0)
            {
                int empty = series.Points.AddXY("Немає задач", 1);
                series.Points[empty].Color = Color.WhiteSmoke;
                series.Points[empty].IsVisibleInLegend = false;
                series.Points[empty].Label = " ";
            }
            else { 
                int p1 = series.Points.AddXY("Не розпочаті", notStarted);
                series.Points[p1].Color = Color.DodgerBlue;
                series.Points[p1].Label = notStarted !=0 ? "#PERCENT{P0}" : " ";
                series.Points[p1].LegendText = $"Не розпочаті ({notStarted})";

                int p2 = series.Points.AddXY("В процесі", inProgress);
                series.Points[p2].Color = Color.Green;
                series.Points[p2].Label = inProgress != 0 ? "#PERCENT{P0}" : " ";
                series.Points[p2].LegendText = $"В процесі ({inProgress})";

                int p3 = series.Points.AddXY("Протерміновані", overdue);
                series.Points[p3].Color = Color.OrangeRed;
                series.Points[p3].Label = overdue != 0 ? "#PERCENT{P0}" : " ";
                series.Points[p3].LegendText = $"Протерміновані ({overdue})";
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

            if (completedInTime == 0 && completedLate == 0)
            {
                int empty = series.Points.AddXY("Немає задач", 1);
                series.Points[empty].Color = Color.WhiteSmoke;
                series.Points[empty].IsVisibleInLegend = false;
                series.Points[empty].Label = " ";
            } else { 
                int p2 = series.Points.AddXY("Виконані вчасно", completedInTime);
                series.Points[p2].Color = Color.DarkBlue;
                series.Points[p2].Label = completedInTime != 0 ? "#PERCENT{P0}" : " ";
                series.Points[p2].LegendText = $"Виконані вчасно ({completedInTime})";

                int p3 = series.Points.AddXY("Виконані з запізненням", completedLate);
                series.Points[p3].Color = Color.Red;
                series.Points[p3].Label = completedLate != 0 ? "#PERCENT{P0}" : " ";
                series.Points[p3].LegendText = $"Виконані з запізненням ({completedLate})";
            }
        }

        #endregion --- Visual ---

        private async void HandleUnauthorized(string message)
        {
            // Важно: так как событие может прилететь из асинхронного потока (HttpClient),
            // нам нужно безопасно переключиться на главный UI-поток через Invoke
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => { HandleUnauthorized(message); }));
                return;
            }

            Close();
        }

        public async Task<TaskStatisticsDto> LoadStatistics()
        {
            try { return await _statisticsApiClient.GetStatistics(); }
            catch (Exception ex) { return new TaskStatisticsDto(); }
        }

        public void RenderStatistics(TaskStatisticsDto statistics)
        {
            SetHeader(statistics.ActiveTasks, statistics.CompletedTasks, statistics.TotalTasks);
            SetAvarageCompletedPercent(statistics.AverageCompletionPercent);
            RenderActiveTasksChart(statistics.NotStarted, statistics.InProgress, statistics.Overdue);
            RenderCompletedTasksChart(statistics.CompletedInTime, statistics.CompletedLate);
        }

        public async Task UpdateStatistics()
        {
            Invoke(new Action<Form, bool>(WaitingForm.ShowWaitingForm), this, true);
            var statistics = await LoadStatistics();
            Invoke(new Action<TaskStatisticsDto>(RenderStatistics), statistics);
            Invoke(new Action(WaitingForm.CloseWaitingForm));
        }

        private async void BTN_Update_Click(object sender, EventArgs e)
        {
            await UpdateStatistics();
        }

        private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BaseApiClient.OnUnathorized -= HandleUnauthorized;
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsLoading) e.Cancel = true;
        }
    }
}
