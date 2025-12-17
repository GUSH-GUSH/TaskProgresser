namespace Weekinator.Forms.UserControls
{
    partial class TaskControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LBL_Accurancy;
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.BTN_GetInfo = new System.Windows.Forms.Button();
            this.NUD_Accurancy = new System.Windows.Forms.NumericUpDown();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            LBL_Accurancy = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Accurancy)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Accurancy
            // 
            LBL_Accurancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LBL_Accurancy.AutoSize = true;
            LBL_Accurancy.Location = new System.Drawing.Point(18, 120);
            LBL_Accurancy.Name = "LBL_Accurancy";
            LBL_Accurancy.Size = new System.Drawing.Size(57, 13);
            LBL_Accurancy.TabIndex = 10;
            LBL_Accurancy.Text = "Точность:";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox.Controls.Add(this.BTN_GetInfo);
            this.GroupBox.Controls.Add(LBL_Accurancy);
            this.GroupBox.Controls.Add(this.NUD_Accurancy);
            this.GroupBox.Controls.Add(this.DateRangeControl);
            this.GroupBox.Controls.Add(this.BTN_Save);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(340, 150);
            this.GroupBox.TabIndex = 13;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Семестр 4.1";
            // 
            // BTN_GetInfo
            // 
            this.BTN_GetInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_GetInfo.Location = new System.Drawing.Point(132, 114);
            this.BTN_GetInfo.Name = "BTN_GetInfo";
            this.BTN_GetInfo.Size = new System.Drawing.Size(75, 23);
            this.BTN_GetInfo.TabIndex = 11;
            this.BTN_GetInfo.Text = "Get Info";
            this.BTN_GetInfo.UseVisualStyleBackColor = true;
            this.BTN_GetInfo.Click += new System.EventHandler(this.BTN_GetInfo_Click);
            // 
            // NUD_Accurancy
            // 
            this.NUD_Accurancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUD_Accurancy.Location = new System.Drawing.Point(81, 117);
            this.NUD_Accurancy.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Accurancy.Name = "NUD_Accurancy";
            this.NUD_Accurancy.Size = new System.Drawing.Size(36, 20);
            this.NUD_Accurancy.TabIndex = 6;
            this.NUD_Accurancy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Accurancy.ValueChanged += new System.EventHandler(this.NUD_Accurancy_ValueChanged);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Save.Location = new System.Drawing.Point(245, 114);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.Location = new System.Drawing.Point(18, 18);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.Size = new System.Drawing.Size(302, 90);
            this.DateRangeControl.TabIndex = 0;
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.MaximumSize = new System.Drawing.Size(10000, 150);
            this.MinimumSize = new System.Drawing.Size(340, 150);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(340, 150);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Accurancy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        public System.Windows.Forms.Button BTN_GetInfo;
        public System.Windows.Forms.NumericUpDown NUD_Accurancy;
        public DateRangeControl DateRangeControl;
        public System.Windows.Forms.Button BTN_Save;
    }
}
