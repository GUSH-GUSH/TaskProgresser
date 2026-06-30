namespace TaskProgresser.WinForms.Forms
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox GPBX_Header;
            System.Windows.Forms.Label LBL_CompletedTitle;
            System.Windows.Forms.Label LBL_ActiveTitle;
            System.Windows.Forms.Label LBL_TotalTitle;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LBL_Completed = new System.Windows.Forms.Label();
            this.LBL_Active = new System.Windows.Forms.Label();
            this.LBL_Total = new System.Windows.Forms.Label();
            this.LBL_ActiveChartTitle = new System.Windows.Forms.Label();
            this.LBL_CompletedChartActive = new System.Windows.Forms.Label();
            this.LBL_AvarageTitle = new System.Windows.Forms.Label();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CHRT_CompletedTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CHRT_ActiveTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.PBWP_AveragePercent = new TaskProgresser.WinForms.Controls.ProgressBarWithPrecent();
            GPBX_Header = new System.Windows.Forms.GroupBox();
            LBL_CompletedTitle = new System.Windows.Forms.Label();
            LBL_ActiveTitle = new System.Windows.Forms.Label();
            LBL_TotalTitle = new System.Windows.Forms.Label();
            GPBX_Header.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_CompletedTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_ActiveTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBX_Header
            // 
            GPBX_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            GPBX_Header.Controls.Add(this.LBL_Completed);
            GPBX_Header.Controls.Add(this.LBL_Active);
            GPBX_Header.Controls.Add(this.LBL_Total);
            GPBX_Header.Controls.Add(LBL_CompletedTitle);
            GPBX_Header.Controls.Add(LBL_ActiveTitle);
            GPBX_Header.Controls.Add(LBL_TotalTitle);
            GPBX_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            GPBX_Header.Location = new System.Drawing.Point(12, 24);
            GPBX_Header.Name = "GPBX_Header";
            GPBX_Header.Size = new System.Drawing.Size(740, 102);
            GPBX_Header.TabIndex = 0;
            GPBX_Header.TabStop = false;
            GPBX_Header.Text = "Задачі";
            // 
            // LBL_Completed
            // 
            this.LBL_Completed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LBL_Completed.AutoSize = true;
            this.LBL_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Completed.ForeColor = System.Drawing.Color.Green;
            this.LBL_Completed.Location = new System.Drawing.Point(367, 63);
            this.LBL_Completed.Name = "LBL_Completed";
            this.LBL_Completed.Size = new System.Drawing.Size(21, 24);
            this.LBL_Completed.TabIndex = 5;
            this.LBL_Completed.Text = "0";
            // 
            // LBL_Active
            // 
            this.LBL_Active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Active.AutoSize = true;
            this.LBL_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Active.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Active.Location = new System.Drawing.Point(112, 63);
            this.LBL_Active.Name = "LBL_Active";
            this.LBL_Active.Size = new System.Drawing.Size(21, 24);
            this.LBL_Active.TabIndex = 4;
            this.LBL_Active.Text = "0";
            // 
            // LBL_Total
            // 
            this.LBL_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Total.AutoSize = true;
            this.LBL_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Total.ForeColor = System.Drawing.Color.LightSlateGray;
            this.LBL_Total.Location = new System.Drawing.Point(630, 63);
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(21, 24);
            this.LBL_Total.TabIndex = 3;
            this.LBL_Total.Text = "0";
            // 
            // LBL_CompletedTitle
            // 
            LBL_CompletedTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            LBL_CompletedTitle.AutoSize = true;
            LBL_CompletedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_CompletedTitle.ForeColor = System.Drawing.Color.Green;
            LBL_CompletedTitle.Location = new System.Drawing.Point(259, 63);
            LBL_CompletedTitle.Name = "LBL_CompletedTitle";
            LBL_CompletedTitle.Size = new System.Drawing.Size(110, 24);
            LBL_CompletedTitle.TabIndex = 2;
            LBL_CompletedTitle.Text = "Виконані -";
            // 
            // LBL_ActiveTitle
            // 
            LBL_ActiveTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LBL_ActiveTitle.AutoSize = true;
            LBL_ActiveTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_ActiveTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            LBL_ActiveTitle.Location = new System.Drawing.Point(17, 63);
            LBL_ActiveTitle.Name = "LBL_ActiveTitle";
            LBL_ActiveTitle.Size = new System.Drawing.Size(105, 24);
            LBL_ActiveTitle.TabIndex = 1;
            LBL_ActiveTitle.Text = "Активні - ";
            // 
            // LBL_TotalTitle
            // 
            LBL_TotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            LBL_TotalTitle.AutoSize = true;
            LBL_TotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_TotalTitle.ForeColor = System.Drawing.Color.LightSlateGray;
            LBL_TotalTitle.Location = new System.Drawing.Point(535, 63);
            LBL_TotalTitle.Name = "LBL_TotalTitle";
            LBL_TotalTitle.Size = new System.Drawing.Size(93, 24);
            LBL_TotalTitle.TabIndex = 0;
            LBL_TotalTitle.Text = "Всього -";
            // 
            // LBL_ActiveChartTitle
            // 
            this.LBL_ActiveChartTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ActiveChartTitle.BackColor = System.Drawing.Color.White;
            this.LBL_ActiveChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_ActiveChartTitle.Location = new System.Drawing.Point(3, 0);
            this.LBL_ActiveChartTitle.Name = "LBL_ActiveChartTitle";
            this.LBL_ActiveChartTitle.Size = new System.Drawing.Size(362, 42);
            this.LBL_ActiveChartTitle.TabIndex = 3;
            this.LBL_ActiveChartTitle.Text = "Активні";
            this.LBL_ActiveChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CompletedChartActive
            // 
            this.LBL_CompletedChartActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CompletedChartActive.BackColor = System.Drawing.Color.White;
            this.LBL_CompletedChartActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_CompletedChartActive.Location = new System.Drawing.Point(371, 0);
            this.LBL_CompletedChartActive.Name = "LBL_CompletedChartActive";
            this.LBL_CompletedChartActive.Size = new System.Drawing.Size(362, 42);
            this.LBL_CompletedChartActive.TabIndex = 4;
            this.LBL_CompletedChartActive.Text = "Виконані";
            this.LBL_CompletedChartActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_AvarageTitle
            // 
            this.LBL_AvarageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_AvarageTitle.AutoSize = true;
            this.LBL_AvarageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_AvarageTitle.Location = new System.Drawing.Point(127, 161);
            this.LBL_AvarageTitle.Name = "LBL_AvarageTitle";
            this.LBL_AvarageTitle.Size = new System.Drawing.Size(510, 33);
            this.LBL_AvarageTitle.TabIndex = 6;
            this.LBL_AvarageTitle.Text = "Середній час виконання завдання";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.Controls.Add(this.CHRT_CompletedTasks, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LBL_ActiveChartTitle, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LBL_CompletedChartActive, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.CHRT_ActiveTasks, 0, 1);
            this.TableLayoutPanel.Location = new System.Drawing.Point(12, 273);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(736, 436);
            this.TableLayoutPanel.TabIndex = 7;
            // 
            // CHRT_CompletedTasks
            // 
            chartArea1.Name = "ChartArea1";
            this.CHRT_CompletedTasks.ChartAreas.Add(chartArea1);
            this.CHRT_CompletedTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.CHRT_CompletedTasks.Legends.Add(legend1);
            this.CHRT_CompletedTasks.Location = new System.Drawing.Point(371, 45);
            this.CHRT_CompletedTasks.Name = "CHRT_CompletedTasks";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHRT_CompletedTasks.Series.Add(series1);
            this.CHRT_CompletedTasks.Size = new System.Drawing.Size(362, 388);
            this.CHRT_CompletedTasks.TabIndex = 11;
            this.CHRT_CompletedTasks.TabStop = false;
            // 
            // CHRT_ActiveTasks
            // 
            chartArea2.Name = "ChartArea1";
            this.CHRT_ActiveTasks.ChartAreas.Add(chartArea2);
            this.CHRT_ActiveTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.CHRT_ActiveTasks.Legends.Add(legend2);
            this.CHRT_ActiveTasks.Location = new System.Drawing.Point(3, 45);
            this.CHRT_ActiveTasks.Name = "CHRT_ActiveTasks";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CHRT_ActiveTasks.Series.Add(series2);
            this.CHRT_ActiveTasks.Size = new System.Drawing.Size(362, 388);
            this.CHRT_ActiveTasks.TabIndex = 2;
            this.CHRT_ActiveTasks.TabStop = false;
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(670, 712);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(75, 23);
            this.BTN_Update.TabIndex = 1;
            this.BTN_Update.Text = "Оновити";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // PBWP_AveragePercent
            // 
            this.PBWP_AveragePercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBWP_AveragePercent.Location = new System.Drawing.Point(20, 199);
            this.PBWP_AveragePercent.Name = "PBWP_AveragePercent";
            this.PBWP_AveragePercent.Percent = 0D;
            this.PBWP_AveragePercent.Size = new System.Drawing.Size(728, 52);
            this.PBWP_AveragePercent.TabIndex = 5;
            this.PBWP_AveragePercent.TabStop = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 741);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.LBL_AvarageTitle);
            this.Controls.Add(this.PBWP_AveragePercent);
            this.Controls.Add(GPBX_Header);
            this.Controls.Add(this.TableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(780, 780);
            this.Name = "StatisticsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            GPBX_Header.ResumeLayout(false);
            GPBX_Header.PerformLayout();
            this.TableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_CompletedTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_ActiveTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_ActiveChartTitle;
        private System.Windows.Forms.Label LBL_CompletedChartActive;
        private Controls.ProgressBarWithPrecent PBWP_AveragePercent;
        private System.Windows.Forms.Label LBL_AvarageTitle;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Label LBL_Completed;
        private System.Windows.Forms.Label LBL_Active;
        private System.Windows.Forms.Label LBL_Total;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_CompletedTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_ActiveTasks;
    }
}