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
            this.LBL_CompleteAt = new System.Windows.Forms.Label();
            this.CHB_AddToTray = new System.Windows.Forms.CheckBox();
            this.BTN_Complete = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.NUD_Precision = new System.Windows.Forms.NumericUpDown();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            LBL_Accurancy = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Accurancy
            // 
            LBL_Accurancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            LBL_Accurancy.AutoSize = true;
            LBL_Accurancy.Location = new System.Drawing.Point(223, 147);
            LBL_Accurancy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LBL_Accurancy.Name = "LBL_Accurancy";
            LBL_Accurancy.Size = new System.Drawing.Size(72, 16);
            LBL_Accurancy.TabIndex = 10;
            LBL_Accurancy.Text = "Точность:";
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox.Controls.Add(this.LBL_CompleteAt);
            this.GroupBox.Controls.Add(this.CHB_AddToTray);
            this.GroupBox.Controls.Add(this.BTN_Complete);
            this.GroupBox.Controls.Add(this.BTN_Delete);
            this.GroupBox.Controls.Add(this.BtnEdit);
            this.GroupBox.Controls.Add(LBL_Accurancy);
            this.GroupBox.Controls.Add(this.NUD_Precision);
            this.GroupBox.Controls.Add(this.DateRangeControl);
            this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox.Location = new System.Drawing.Point(0, 0);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox.Size = new System.Drawing.Size(744, 185);
            this.GroupBox.TabIndex = 13;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Семестр 4.1";
            // 
            // LBL_CompleteAt
            // 
            this.LBL_CompleteAt.AutoSize = true;
            this.LBL_CompleteAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_CompleteAt.ForeColor = System.Drawing.Color.Green;
            this.LBL_CompleteAt.Location = new System.Drawing.Point(27, 78);
            this.LBL_CompleteAt.Name = "LBL_CompleteAt";
            this.LBL_CompleteAt.Size = new System.Drawing.Size(337, 25);
            this.LBL_CompleteAt.TabIndex = 16;
            this.LBL_CompleteAt.Text = "Виконано за 89% відведеного часу!";
            // 
            // CHB_AddToTray
            // 
            this.CHB_AddToTray.AutoSize = true;
            this.CHB_AddToTray.Location = new System.Drawing.Point(369, 145);
            this.CHB_AddToTray.Margin = new System.Windows.Forms.Padding(4);
            this.CHB_AddToTray.Name = "CHB_AddToTray";
            this.CHB_AddToTray.Size = new System.Drawing.Size(122, 20);
            this.CHB_AddToTray.TabIndex = 15;
            this.CHB_AddToTray.Text = "Додати у трей";
            this.CHB_AddToTray.UseVisualStyleBackColor = true;
            this.CHB_AddToTray.CheckedChanged += new System.EventHandler(this.CHB_AddToTray_CheckedChanged);
            // 
            // BTN_Complete
            // 
            this.BTN_Complete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Complete.AutoSize = true;
            this.BTN_Complete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Complete.ForeColor = System.Drawing.Color.Green;
            this.BTN_Complete.Location = new System.Drawing.Point(23, 141);
            this.BTN_Complete.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Complete.Name = "BTN_Complete";
            this.BTN_Complete.Size = new System.Drawing.Size(179, 27);
            this.BTN_Complete.TabIndex = 14;
            this.BTN_Complete.Text = "Скасувати виконання";
            this.BTN_Complete.UseVisualStyleBackColor = true;
            this.BTN_Complete.Click += new System.EventHandler(this.BTN_Complete_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete.Location = new System.Drawing.Point(633, 140);
            this.BTN_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(85, 28);
            this.BTN_Delete.TabIndex = 13;
            this.BTN_Delete.Text = "Видалити";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(529, 140);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 28);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Text = "Детальніше";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // NUD_Precision
            // 
            this.NUD_Precision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NUD_Precision.Location = new System.Drawing.Point(299, 143);
            this.NUD_Precision.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_Precision.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_Precision.Name = "NUD_Precision";
            this.NUD_Precision.Size = new System.Drawing.Size(48, 22);
            this.NUD_Precision.TabIndex = 6;
            this.NUD_Precision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Precision.ValueChanged += new System.EventHandler(this.NUD_Accurancy_ValueChanged);
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.EnableEdit = false;
            this.DateRangeControl.EnableIcon = false;
            this.DateRangeControl.Location = new System.Drawing.Point(24, 22);
            this.DateRangeControl.Margin = new System.Windows.Forms.Padding(5);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(400, 111);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.RangeName = null;
            this.DateRangeControl.Size = new System.Drawing.Size(693, 111);
            this.DateRangeControl.TabIndex = 0;
            this.DateRangeControl.IconClick += new System.Action(this.DateRangeControl_IconClick);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(13333, 185);
            this.MinimumSize = new System.Drawing.Size(633, 185);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(744, 185);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        public System.Windows.Forms.NumericUpDown NUD_Precision;
        public DateRangeControl DateRangeControl;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Button BTN_Delete;
        public System.Windows.Forms.Button BTN_Complete;
        private System.Windows.Forms.CheckBox CHB_AddToTray;
        private System.Windows.Forms.Label LBL_CompleteAt;
    }
}
