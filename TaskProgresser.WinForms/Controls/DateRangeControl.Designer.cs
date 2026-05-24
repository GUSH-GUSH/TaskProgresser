using System;

namespace TaskProgresser.WinForms
{
    partial class DateRangeControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem PrecentIconMenuItem_HideIcon;
            System.Windows.Forms.ToolStripMenuItem PrecentIconMenuItem_ShowFlyoutForm;
            this.IconMainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.PrecentLabel = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PrecentIcon = new TaskProgresser.WinForms.DynamicTextNotifyIcon(this.components);
            PrecentIconMenuItem_HideIcon = new System.Windows.Forms.ToolStripMenuItem();
            PrecentIconMenuItem_ShowFlyoutForm = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMainMenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrecentIconMenuItem_HideIcon
            // 
            PrecentIconMenuItem_HideIcon.BackColor = System.Drawing.SystemColors.ControlText;
            PrecentIconMenuItem_HideIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            PrecentIconMenuItem_HideIcon.Name = "PrecentIconMenuItem_HideIcon";
            PrecentIconMenuItem_HideIcon.Size = new System.Drawing.Size(179, 22);
            PrecentIconMenuItem_HideIcon.Text = "Сховати значок";
            PrecentIconMenuItem_HideIcon.Click += new System.EventHandler(this.PrecentIconMenuItem_HideIcon_Click);
            // 
            // PrecentIconMenuItem_ShowFlyoutForm
            // 
            PrecentIconMenuItem_ShowFlyoutForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            PrecentIconMenuItem_ShowFlyoutForm.Name = "PrecentIconMenuItem_ShowFlyoutForm";
            PrecentIconMenuItem_ShowFlyoutForm.Size = new System.Drawing.Size(179, 22);
            PrecentIconMenuItem_ShowFlyoutForm.Text = "Показати вікно-превью";
            PrecentIconMenuItem_ShowFlyoutForm.Click += new System.EventHandler(this.PrecentIconMenuItem_ShowFlyoutForm_Click);
            // 
            // IconMainMenuStrip
            // 
            this.IconMainMenuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.IconMainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.IconMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            PrecentIconMenuItem_ShowFlyoutForm,
            PrecentIconMenuItem_HideIcon});
            this.IconMainMenuStrip.Name = "IconMainMenuStrip";
            this.IconMainMenuStrip.ShowImageMargin = false;
            this.IconMainMenuStrip.Size = new System.Drawing.Size(180, 48);
            this.IconMainMenuStrip.Text = "Меню";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProgressBar.Location = new System.Drawing.Point(60, 39);
            this.MainProgressBar.Maximum = 10000;
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(362, 23);
            this.MainProgressBar.TabIndex = 10;
            this.MainProgressBar.Value = 6000;
            // 
            // PrecentLabel
            // 
            this.PrecentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecentLabel.AutoSize = true;
            this.PrecentLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrecentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrecentLabel.Location = new System.Drawing.Point(195, 16);
            this.PrecentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PrecentLabel.Name = "PrecentLabel";
            this.PrecentLabel.Size = new System.Drawing.Size(41, 20);
            this.PrecentLabel.TabIndex = 11;
            this.PrecentLabel.Text = "59%";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartDateTimePicker.CustomFormat = "HH:mm dd/MM/yyyy";
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartDateTimePicker.Location = new System.Drawing.Point(0, 70);
            this.StartDateTimePicker.MaxDate = new System.DateTime(2026, 6, 17, 0, 0, 0, 0);
            this.StartDateTimePicker.MinDate = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.StartDateTimePicker.TabIndex = 12;
            this.StartDateTimePicker.Value = new System.DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateTimePicker.CustomFormat = "HH:mm dd/MM/yyyy";
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(352, 70);
            this.EndDateTimePicker.MaxDate = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            this.EndDateTimePicker.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.EndDateTimePicker.TabIndex = 13;
            this.EndDateTimePicker.Value = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EndDateTimePicker);
            this.MainPanel.Controls.Add(this.StartDateTimePicker);
            this.MainPanel.Controls.Add(this.MainProgressBar);
            this.MainPanel.Controls.Add(this.PrecentLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(482, 90);
            this.MainPanel.TabIndex = 10;
            // 
            // PrecentIcon
            // 
            this.PrecentIcon.BaloonTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.PrecentIcon.BaloonTipText = "";
            this.PrecentIcon.BaloonTipTitle = "";
            this.PrecentIcon.ContextMenuStrip = this.IconMainMenuStrip;
            this.PrecentIcon.DisplayText = "0";
            this.PrecentIcon.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F);
            this.PrecentIcon.Visible = false;
            this.PrecentIcon.Click += new System.EventHandler(this.PrecentIcon_Click);
            this.PrecentIcon.DoubleClick += new System.EventHandler(this.PrecentIcon_DoubleClick);
            // 
            // DateRangeControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(300, 90);
            this.Name = "DateRangeControl";
            this.Size = new System.Drawing.Size(482, 90);
            this.Load += new System.EventHandler(this.DateRangeControl_Load);
            this.Resize += new System.EventHandler(this.DateRangeControl_Resize);
            this.IconMainMenuStrip.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip IconMainMenuStrip;
        private DynamicTextNotifyIcon PrecentIcon;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.Label PrecentLabel;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Panel MainPanel;
    }
}
