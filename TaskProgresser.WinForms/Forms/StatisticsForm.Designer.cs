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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CHRT_ActiveTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CHRT_CompletedTasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBL_ActiveChartTitle = new System.Windows.Forms.Label();
            this.LBL_CompletedChartActive = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            groupBox1.Size = new System.Drawing.Size(754, 102);
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
            LBL_TotalTitle.Location = new System.Drawing.Point(549, 63);
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
            LBL_CompletedTitle.Location = new System.Drawing.Point(266, 63);
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
            LBL_Completed.Location = new System.Drawing.Point(374, 63);
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
            LBL_Total.Location = new System.Drawing.Point(644, 63);
            LBL_Total.Name = "LBL_Total";
            LBL_Total.Size = new System.Drawing.Size(21, 24);
            LBL_Total.TabIndex = 3;
            LBL_Total.Text = "0";
            // 
            // CHRT_ActiveTasks
            // 
            chartArea11.Name = "ChartArea1";
            this.CHRT_ActiveTasks.ChartAreas.Add(chartArea11);
            legend11.Alignment = System.Drawing.StringAlignment.Center;
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend11.Name = "Legend1";
            this.CHRT_ActiveTasks.Legends.Add(legend11);
            this.CHRT_ActiveTasks.Location = new System.Drawing.Point(20, 248);
            this.CHRT_ActiveTasks.Name = "CHRT_ActiveTasks";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.CHRT_ActiveTasks.Series.Add(series11);
            this.CHRT_ActiveTasks.Size = new System.Drawing.Size(368, 393);
            this.CHRT_ActiveTasks.TabIndex = 1;
            // 
            // CHRT_CompletedTasks
            // 
            chartArea12.Name = "ChartArea1";
            this.CHRT_CompletedTasks.ChartAreas.Add(chartArea12);
            legend12.Alignment = System.Drawing.StringAlignment.Center;
            legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend12.Name = "Legend1";
            this.CHRT_CompletedTasks.Legends.Add(legend12);
            this.CHRT_CompletedTasks.Location = new System.Drawing.Point(394, 248);
            this.CHRT_CompletedTasks.Name = "CHRT_CompletedTasks";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.CHRT_CompletedTasks.Series.Add(series12);
            this.CHRT_CompletedTasks.Size = new System.Drawing.Size(368, 393);
            this.CHRT_CompletedTasks.TabIndex = 2;
            // 
            // LBL_ActiveChartTitle
            // 
            this.LBL_ActiveChartTitle.BackColor = System.Drawing.Color.White;
            this.LBL_ActiveChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_ActiveChartTitle.Location = new System.Drawing.Point(20, 206);
            this.LBL_ActiveChartTitle.Name = "LBL_ActiveChartTitle";
            this.LBL_ActiveChartTitle.Size = new System.Drawing.Size(368, 42);
            this.LBL_ActiveChartTitle.TabIndex = 3;
            this.LBL_ActiveChartTitle.Text = "Активні";
            this.LBL_ActiveChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CompletedChartActive
            // 
            this.LBL_CompletedChartActive.BackColor = System.Drawing.Color.White;
            this.LBL_CompletedChartActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_CompletedChartActive.Location = new System.Drawing.Point(394, 206);
            this.LBL_CompletedChartActive.Name = "LBL_CompletedChartActive";
            this.LBL_CompletedChartActive.Size = new System.Drawing.Size(368, 42);
            this.LBL_CompletedChartActive.TabIndex = 4;
            this.LBL_CompletedChartActive.Text = "Виконані";
            this.LBL_CompletedChartActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 673);
            this.Controls.Add(this.LBL_CompletedChartActive);
            this.Controls.Add(this.LBL_ActiveChartTitle);
            this.Controls.Add(this.CHRT_CompletedTasks);
            this.Controls.Add(this.CHRT_ActiveTasks);
            this.Controls.Add(groupBox1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_ActiveTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHRT_CompletedTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_ActiveTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHRT_CompletedTasks;
        private System.Windows.Forms.Label LBL_ActiveChartTitle;
        private System.Windows.Forms.Label LBL_CompletedChartActive;
    }
}