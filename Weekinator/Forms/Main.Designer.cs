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
            this.dateRangeControl1 = new Weekinator.DateRangeControl();
            this.SuspendLayout();
            // 
            // dateRangeControl1
            // 
            this.dateRangeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateRangeControl1.Location = new System.Drawing.Point(113, 176);
            this.dateRangeControl1.MinimumSize = new System.Drawing.Size(300, 90);
            this.dateRangeControl1.Name = "dateRangeControl1";
            this.dateRangeControl1.Size = new System.Drawing.Size(482, 90);
            this.dateRangeControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 428);
            this.Controls.Add(this.dateRangeControl1);
            this.MinimumSize = new System.Drawing.Size(526, 200);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DateRangeControl dateRangeControl1;
    }
}

