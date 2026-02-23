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
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.NUD_Accurancy = new System.Windows.Forms.NumericUpDown();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.BTN_Complete = new System.Windows.Forms.Button();
            LBL_Accurancy = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Accurancy)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Accurancy
            // 
            LBL_Accurancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LBL_Accurancy.AutoSize = true;
            LBL_Accurancy.Location = new System.Drawing.Point(100, 120);
            LBL_Accurancy.Name = "LBL_Accurancy";
            LBL_Accurancy.Size = new System.Drawing.Size(57, 13);
            LBL_Accurancy.TabIndex = 10;
            LBL_Accurancy.Text = "Точность:";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox.Controls.Add(this.BTN_Complete);
            this.GroupBox.Controls.Add(this.BTN_Delete);
            this.GroupBox.Controls.Add(this.BtnEdit);
            this.GroupBox.Controls.Add(LBL_Accurancy);
            this.GroupBox.Controls.Add(this.NUD_Accurancy);
            this.GroupBox.Controls.Add(this.DateRangeControl);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(400, 150);
            this.GroupBox.TabIndex = 13;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Семестр 4.1";
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete.Location = new System.Drawing.Point(317, 114);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(64, 23);
            this.BTN_Delete.TabIndex = 13;
            this.BTN_Delete.Text = "Видалити";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(239, 114);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "Детальніше";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // NUD_Accurancy
            // 
            this.NUD_Accurancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUD_Accurancy.Location = new System.Drawing.Point(157, 117);
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
            // DateRangeControl
            // 
            this.DateRangeControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.EnableIcon = false;
            this.DateRangeControl.Location = new System.Drawing.Point(18, 18);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.Size = new System.Drawing.Size(362, 90);
            this.DateRangeControl.TabIndex = 0;
            // 
            // BTN_Complete
            // 
            this.BTN_Complete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Complete.ForeColor = System.Drawing.Color.Green;
            this.BTN_Complete.Location = new System.Drawing.Point(17, 114);
            this.BTN_Complete.Name = "BTN_Complete";
            this.BTN_Complete.Size = new System.Drawing.Size(74, 23);
            this.BTN_Complete.TabIndex = 14;
            this.BTN_Complete.Text = "Виконати";
            this.BTN_Complete.UseVisualStyleBackColor = true;
            this.BTN_Complete.Click += new System.EventHandler(this.BTN_Complete_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.MaximumSize = new System.Drawing.Size(10000, 150);
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(400, 150);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Accurancy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        public System.Windows.Forms.NumericUpDown NUD_Accurancy;
        public DateRangeControl DateRangeControl;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Button BTN_Delete;
        public System.Windows.Forms.Button BTN_Complete;
    }
}
