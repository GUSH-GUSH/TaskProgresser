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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label LBL_TotalTitle;
            System.Windows.Forms.Label LBL_ActiveTitle;
            System.Windows.Forms.Label LBL_CompletedTitle;
            System.Windows.Forms.Label LBL_Completed;
            System.Windows.Forms.Label LBL_Active;
            System.Windows.Forms.Label LBL_Total;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CHRT_ActiveTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CHRT_CompletedTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBL_ActiveChartTitle = new System.Windows.Forms.Label();
            this.LBL_CompletedChartActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PBWP_AveragePercent = new TaskProgresser.WinForms.Controls.ProgressBarWithPrecent();
            groupBox1 = new System.Windows.Forms.GroupBox();
            LBL_TotalTitle = new System.Windows.Forms.Label();
            LBL_ActiveTitle = new System.Windows.Forms.Label();
            LBL_CompletedTitle = new System.Windows.Forms.Label();
            LBL_Completed = new System.Windows.Forms.Label();
            LBL_Active = new System.Windows.Forms.Label();
            LBL_Total = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_ActiveTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_CompletedTasks)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(LBL_Completed);
            groupBox1.Controls.Add(LBL_Active);
            groupBox1.Controls.Add(LBL_Total);
            groupBox1.Controls.Add(LBL_CompletedTitle);
            groupBox1.Controls.Add(LBL_ActiveTitle);
            groupBox1.Controls.Add(LBL_TotalTitle);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupBox1.Location = new System.Drawing.Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(740, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задачі";
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
            // LBL_Completed
            // 
            LBL_Completed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            LBL_Completed.AutoSize = true;
            LBL_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_Completed.ForeColor = System.Drawing.Color.Green;
            LBL_Completed.Location = new System.Drawing.Point(367, 63);
            LBL_Completed.Name = "LBL_Completed";
            LBL_Completed.Size = new System.Drawing.Size(21, 24);
            LBL_Completed.TabIndex = 5;
            LBL_Completed.Text = "0";
            // 
            // LBL_Active
            // 
            LBL_Active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LBL_Active.AutoSize = true;
            LBL_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_Active.ForeColor = System.Drawing.SystemColors.HotTrack;
            LBL_Active.Location = new System.Drawing.Point(112, 63);
            LBL_Active.Name = "LBL_Active";
            LBL_Active.Size = new System.Drawing.Size(21, 24);
            LBL_Active.TabIndex = 4;
            LBL_Active.Text = "0";
            // 
            // LBL_Total
            // 
            LBL_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            LBL_Total.AutoSize = true;
            LBL_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LBL_Total.ForeColor = System.Drawing.Color.LightSlateGray;
            LBL_Total.Location = new System.Drawing.Point(630, 63);
            LBL_Total.Name = "LBL_Total";
            LBL_Total.Size = new System.Drawing.Size(21, 24);
            LBL_Total.TabIndex = 3;
            LBL_Total.Text = "0";
            // 
            // CHRT_ActiveTasks
            // 
            chartArea1.Name = "ChartArea1";
            this.CHRT_ActiveTasks.ChartAreas.Add(chartArea1);
            this.CHRT_ActiveTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.CHRT_ActiveTasks.Legends.Add(legend1);
            this.CHRT_ActiveTasks.Location = new System.Drawing.Point(371, 45);
            this.CHRT_ActiveTasks.Name = "CHRT_ActiveTasks";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CHRT_ActiveTasks.Series.Add(series1);
            this.CHRT_ActiveTasks.Size = new System.Drawing.Size(362, 388);
            this.CHRT_ActiveTasks.TabIndex = 1;
            // 
            // CHRT_CompletedTasks
            // 
            chartArea2.Name = "ChartArea1";
            this.CHRT_CompletedTasks.ChartAreas.Add(chartArea2);
            this.CHRT_CompletedTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.CHRT_CompletedTasks.Legends.Add(legend2);
            this.CHRT_CompletedTasks.Location = new System.Drawing.Point(3, 45);
            this.CHRT_CompletedTasks.Name = "CHRT_CompletedTasks";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.CHRT_CompletedTasks.Series.Add(series2);
            this.CHRT_CompletedTasks.Size = new System.Drawing.Size(362, 388);
            this.CHRT_CompletedTasks.TabIndex = 2;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Середній час виконання завдання";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_ActiveChartTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CompletedChartActive, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CHRT_ActiveTasks, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CHRT_CompletedTasks, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 273);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 436);
            this.tableLayoutPanel1.TabIndex = 7;
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
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBWP_AveragePercent);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(780, 780);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_ActiveTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_CompletedTasks)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_ActiveTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_CompletedTasks;
        private System.Windows.Forms.Label LBL_ActiveChartTitle;
        private System.Windows.Forms.Label LBL_CompletedChartActive;
        private Controls.ProgressBarWithPrecent PBWP_AveragePercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}