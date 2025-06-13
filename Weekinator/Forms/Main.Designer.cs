namespace Weekinator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.PrecentLabel = new System.Windows.Forms.Label();
            this.dateRangeControl1 = new Weekinator.DateRangeControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProgressBar.Location = new System.Drawing.Point(60, 40);
            this.MainProgressBar.Maximum = 10000;
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(461, 23);
            this.MainProgressBar.TabIndex = 0;
            this.MainProgressBar.Value = 6000;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.PrecentLabel);
            this.panel1.Controls.Add(this.MainProgressBar);
            this.panel1.Location = new System.Drawing.Point(27, 415);
            this.panel1.MinimumSize = new System.Drawing.Size(430, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 90);
            this.panel1.TabIndex = 1;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // EndDate
            // 
            this.EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDate.Location = new System.Drawing.Point(381, 70);
            this.EndDate.MaxDate = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            this.EndDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 20);
            this.EndDate.TabIndex = 5;
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // StartDate
            // 
            this.StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartDate.Location = new System.Drawing.Point(0, 70);
            this.StartDate.MaxDate = new System.DateTime(2026, 6, 17, 0, 0, 0, 0);
            this.StartDate.MinDate = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 20);
            this.StartDate.TabIndex = 4;
            this.StartDate.Value = new System.DateTime(2025, 4, 10, 0, 0, 0, 0);
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // PrecentLabel
            // 
            this.PrecentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecentLabel.AutoSize = true;
            this.PrecentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrecentLabel.Location = new System.Drawing.Point(65, 17);
            this.PrecentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrecentLabel.Name = "PrecentLabel";
            this.PrecentLabel.Size = new System.Drawing.Size(41, 20);
            this.PrecentLabel.TabIndex = 2;
            this.PrecentLabel.Text = "59%";
            // 
            // dateRangeControl1
            // 
            this.dateRangeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateRangeControl1.Location = new System.Drawing.Point(27, 12);
            this.dateRangeControl1.MaximumSize = new System.Drawing.Size(0, 90);
            this.dateRangeControl1.MinimumSize = new System.Drawing.Size(430, 90);
            this.dateRangeControl1.Name = "dateRangeControl1";
            this.dateRangeControl1.Size = new System.Drawing.Size(430, 90);
            this.dateRangeControl1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 752);
            this.Controls.Add(this.dateRangeControl1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(526, 200);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label PrecentLabel;
        private DateRangeControl dateRangeControl1;
    }
}

