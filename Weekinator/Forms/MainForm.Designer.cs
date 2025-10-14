namespace Weekinator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label CurrentDateTimeTitle_Label;
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.PrecentIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMainMenu_OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMainMenu_CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Precent = new System.Windows.Forms.NotifyIcon(this.components);
            this.openTestIconForm_Button = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentDateTime_Label = new System.Windows.Forms.Label();
            CurrentDateTimeTitle_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.IconMainMenuStrip.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentDateTimeTitle_Label
            // 
            CurrentDateTimeTitle_Label.AutoSize = true;
            CurrentDateTimeTitle_Label.Location = new System.Drawing.Point(7, 17);
            CurrentDateTimeTitle_Label.Name = "CurrentDateTimeTitle_Label";
            CurrentDateTimeTitle_Label.Size = new System.Drawing.Size(125, 13);
            CurrentDateTimeTitle_Label.TabIndex = 8;
            CurrentDateTimeTitle_Label.Text = "Текущая дата и время:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.DateRangeControl);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(110, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Семестр 4.1";
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.Location = new System.Drawing.Point(18, 38);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Size = new System.Drawing.Size(482, 90);
            this.DateRangeControl.TabIndex = 0;
            // 
            // PrecentIcon
            // 
            this.PrecentIcon.ContextMenuStrip = this.IconMainMenuStrip;
            this.PrecentIcon.Text = "Weekinator";
            this.PrecentIcon.Visible = true;
            this.PrecentIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PrecentIcon_MouseDoubleClick);
            // 
            // IconMainMenuStrip
            // 
            this.IconMainMenuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.IconMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMainMenu_OpenItem,
            this.IconMainMenu_CloseItem});
            this.IconMainMenuStrip.Name = "IconMainMenuStrip";
            this.IconMainMenuStrip.ShowImageMargin = false;
            this.IconMainMenuStrip.Size = new System.Drawing.Size(125, 48);
            this.IconMainMenuStrip.Text = "Меню";
            // 
            // IconMainMenu_OpenItem
            // 
            this.IconMainMenu_OpenItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.IconMainMenu_OpenItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconMainMenu_OpenItem.Name = "IconMainMenu_OpenItem";
            this.IconMainMenu_OpenItem.Size = new System.Drawing.Size(124, 22);
            this.IconMainMenu_OpenItem.Text = "Главное окно";
            this.IconMainMenu_OpenItem.Click += new System.EventHandler(this.IconMainMenu_OpenItem_Click);
            // 
            // IconMainMenu_CloseItem
            // 
            this.IconMainMenu_CloseItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.IconMainMenu_CloseItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.IconMainMenu_CloseItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconMainMenu_CloseItem.Name = "IconMainMenu_CloseItem";
            this.IconMainMenu_CloseItem.Size = new System.Drawing.Size(124, 22);
            this.IconMainMenu_CloseItem.Text = "Закрыть";
            this.IconMainMenu_CloseItem.Click += new System.EventHandler(this.IconMainMenu_CloseItem_Click);
            // 
            // Precent
            // 
            this.Precent.Text = "Weekinator";
            this.Precent.Visible = true;
            // 
            // openTestIconForm_Button
            // 
            this.openTestIconForm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openTestIconForm_Button.AutoSize = true;
            this.openTestIconForm_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.openTestIconForm_Button.Location = new System.Drawing.Point(611, 12);
            this.openTestIconForm_Button.Name = "openTestIconForm_Button";
            this.openTestIconForm_Button.Size = new System.Drawing.Size(88, 23);
            this.openTestIconForm_Button.TabIndex = 7;
            this.openTestIconForm_Button.Text = "Test Icon Form";
            this.openTestIconForm_Button.UseVisualStyleBackColor = true;
            this.openTestIconForm_Button.Click += new System.EventHandler(this.openTestIconForm_Button_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.CurrentDateTime_Label);
            this.TopPanel.Controls.Add(CurrentDateTimeTitle_Label);
            this.TopPanel.Controls.Add(this.openTestIconForm_Button);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(711, 45);
            this.TopPanel.TabIndex = 8;
            // 
            // CurrentDateTime_Label
            // 
            this.CurrentDateTime_Label.AutoSize = true;
            this.CurrentDateTime_Label.Location = new System.Drawing.Point(127, 17);
            this.CurrentDateTime_Label.Name = "CurrentDateTime_Label";
            this.CurrentDateTime_Label.Size = new System.Drawing.Size(110, 13);
            this.CurrentDateTime_Label.TabIndex = 9;
            this.CurrentDateTime_Label.Text = "11.05.2005 08:00 AM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(711, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopPanel);
            this.MinimumSize = new System.Drawing.Size(526, 200);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.IconMainMenuStrip.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateRangeControl DateRangeControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon PrecentIcon;
        private System.Windows.Forms.NotifyIcon Precent;
        private System.Windows.Forms.Button openTestIconForm_Button;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CurrentDateTime_Label;
        private System.Windows.Forms.ContextMenuStrip IconMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem IconMainMenu_OpenItem;
        private System.Windows.Forms.ToolStripMenuItem IconMainMenu_CloseItem;
    }
}

