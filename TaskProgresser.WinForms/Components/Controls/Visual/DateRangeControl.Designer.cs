using System;
using WinFormsExtensions;

namespace TaskProgresser.WinForms.Components.Controls
{
    partial class DateRangeControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.IconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.LBL_Precent = new System.Windows.Forms.Label();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TextPrecentIcon = new TaskProgresser.WinForms.Components.TextNotifyIcon(this.components);
            PrecentIconMenuItem_HideIcon = new System.Windows.Forms.ToolStripMenuItem();
            PrecentIconMenuItem_ShowFlyoutForm = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenuStrip.SuspendLayout();
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
            this.IconMenuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.IconMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.IconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            PrecentIconMenuItem_ShowFlyoutForm,
            PrecentIconMenuItem_HideIcon});
            this.IconMenuStrip.Name = "IconMainMenuStrip";
            this.IconMenuStrip.ShowImageMargin = false;
            this.IconMenuStrip.Size = new System.Drawing.Size(180, 48);
            this.IconMenuStrip.Text = "Меню";
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
            this.LBL_Precent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Precent.AutoSize = true;
            this.LBL_Precent.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Precent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Precent.Location = new System.Drawing.Point(195, 16);
            this.LBL_Precent.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Precent.Name = "PrecentLabel";
            this.LBL_Precent.Size = new System.Drawing.Size(41, 20);
            this.LBL_Precent.TabIndex = 11;
            this.LBL_Precent.Text = "59%";
            // 
            // StartDateTimePicker
            // 
            this.DTP_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DTP_Start.CustomFormat = "HH:mm dd/MM/yyyy";
            this.DTP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTP_Start.Location = new System.Drawing.Point(0, 70);
            this.DTP_Start.MaxDate = new System.DateTime(2026, 6, 17, 0, 0, 0, 0);
            this.DTP_Start.MinDate = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            this.DTP_Start.Name = "StartDateTimePicker";
            this.DTP_Start.Size = new System.Drawing.Size(130, 20);
            this.DTP_Start.TabIndex = 1;
            this.DTP_Start.Value = new System.DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.DTP_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_End.CustomFormat = "HH:mm dd/MM/yyyy";
            this.DTP_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_End.Location = new System.Drawing.Point(352, 70);
            this.DTP_End.MaxDate = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            this.DTP_End.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DTP_End.Name = "EndDateTimePicker";
            this.DTP_End.Size = new System.Drawing.Size(130, 20);
            this.DTP_End.TabIndex = 2;
            this.DTP_End.Value = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.DTP_End);
            this.MainPanel.Controls.Add(this.DTP_Start);
            this.MainPanel.Controls.Add(this.MainProgressBar);
            this.MainPanel.Controls.Add(this.LBL_Precent);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(482, 90);
            this.MainPanel.TabIndex = 10;
            // 
            // PrecentIcon
            // 
            this.TextPrecentIcon.BaloonTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.TextPrecentIcon.BaloonTipText = "";
            this.TextPrecentIcon.BaloonTipTitle = "";
            this.TextPrecentIcon.ContextMenuStrip = this.IconMenuStrip;
            this.TextPrecentIcon.DisplayText = "0";
            this.TextPrecentIcon.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 18F);
            this.TextPrecentIcon.Visible = false;
            this.TextPrecentIcon.Click += new System.EventHandler(this.PrecentIcon_Click);
            this.TextPrecentIcon.DoubleClick += new System.EventHandler(this.PrecentIcon_DoubleClick);
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
            this.IconMenuStrip.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip IconMenuStrip;
        private TextNotifyIcon TextPrecentIcon;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.Label LBL_Precent;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.Panel MainPanel;
    }
}
