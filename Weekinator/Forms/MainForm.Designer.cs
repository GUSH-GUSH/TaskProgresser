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
            System.Windows.Forms.Label Label_CurDateTimeTitle;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenMainWindow;
            System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CloseApp;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.Label_CurrentDateTime = new System.Windows.Forms.Label();
            this.TabPage_Completed = new System.Windows.Forms.TabPage();
            this.FlowPanel_Completed = new System.Windows.Forms.FlowLayoutPanel();
            this.TabPage_Active = new System.Windows.Forms.TabPage();
            this.FlowPanel_Active = new System.Windows.Forms.FlowLayoutPanel();
            this.TSKCNTRL_Bakalavr = new Weekinator.Forms.UserControls.TaskControl();
            this.TSKCTRL_Semestr = new Weekinator.Forms.UserControls.TaskControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MainIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            Label_CurDateTimeTitle = new System.Windows.Forms.Label();
            ToolStripMenuItem_OpenMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            ToolStripMenuItem_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomPanel.SuspendLayout();
            this.TabPage_Completed.SuspendLayout();
            this.TabPage_Active.SuspendLayout();
            this.FlowPanel_Active.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_CurDateTimeTitle
            // 
            Label_CurDateTimeTitle.AutoSize = true;
            Label_CurDateTimeTitle.Location = new System.Drawing.Point(7, 17);
            Label_CurDateTimeTitle.Name = "Label_CurDateTimeTitle";
            Label_CurDateTimeTitle.Size = new System.Drawing.Size(112, 13);
            Label_CurDateTimeTitle.TabIndex = 8;
            Label_CurDateTimeTitle.Text = "Поточна дата та час:";
            // 
            // ToolStripMenuItem_OpenMainWindow
            // 
            ToolStripMenuItem_OpenMainWindow.Name = "ToolStripMenuItem_OpenMainWindow";
            ToolStripMenuItem_OpenMainWindow.Size = new System.Drawing.Size(176, 22);
            ToolStripMenuItem_OpenMainWindow.Text = "Головне вікно";
            ToolStripMenuItem_OpenMainWindow.Click += new System.EventHandler(this.ToolStripMenuItem_OpenMainWindow_Click);
            // 
            // ToolStripSeparator
            // 
            ToolStripSeparator.Name = "ToolStripSeparator";
            ToolStripSeparator.Size = new System.Drawing.Size(173, 6);
            // 
            // ToolStripMenuItem_CloseApp
            // 
            ToolStripMenuItem_CloseApp.Name = "ToolStripMenuItem_CloseApp";
            ToolStripMenuItem_CloseApp.Size = new System.Drawing.Size(176, 22);
            ToolStripMenuItem_CloseApp.Text = "Закрити програму";
            ToolStripMenuItem_CloseApp.Click += new System.EventHandler(this.ToolStripMenuItem_CloseApp_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.BTN_Add);
            this.BottomPanel.Controls.Add(this.Label_CurrentDateTime);
            this.BottomPanel.Controls.Add(Label_CurDateTimeTitle);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 404);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(664, 45);
            this.BottomPanel.TabIndex = 8;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Add.AutoSize = true;
            this.BTN_Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Add.Location = new System.Drawing.Point(541, 12);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(116, 26);
            this.BTN_Add.TabIndex = 12;
            this.BTN_Add.Text = "Додати задачу";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // Label_CurrentDateTime
            // 
            this.Label_CurrentDateTime.AutoSize = true;
            this.Label_CurrentDateTime.Location = new System.Drawing.Point(115, 17);
            this.Label_CurrentDateTime.Name = "Label_CurrentDateTime";
            this.Label_CurrentDateTime.Size = new System.Drawing.Size(110, 13);
            this.Label_CurrentDateTime.TabIndex = 9;
            this.Label_CurrentDateTime.Text = "11.05.2005 08:00 AM";
            // 
            // TabPage_Completed
            // 
            this.TabPage_Completed.Controls.Add(this.FlowPanel_Completed);
            this.TabPage_Completed.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Completed.Name = "TabPage_Completed";
            this.TabPage_Completed.Size = new System.Drawing.Size(654, 372);
            this.TabPage_Completed.TabIndex = 2;
            this.TabPage_Completed.Text = "Завершені задачі";
            this.TabPage_Completed.UseVisualStyleBackColor = true;
            // 
            // FlowPanel_Completed
            // 
            this.FlowPanel_Completed.AutoScroll = true;
            this.FlowPanel_Completed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlowPanel_Completed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_Completed.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel_Completed.Name = "FlowPanel_Completed";
            this.FlowPanel_Completed.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.FlowPanel_Completed.Size = new System.Drawing.Size(654, 372);
            this.FlowPanel_Completed.TabIndex = 9;
            // 
            // TabPage_Active
            // 
            this.TabPage_Active.Controls.Add(this.FlowPanel_Active);
            this.TabPage_Active.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Active.Name = "TabPage_Active";
            this.TabPage_Active.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPage_Active.Size = new System.Drawing.Size(656, 378);
            this.TabPage_Active.TabIndex = 0;
            this.TabPage_Active.Text = "Активні задачі";
            this.TabPage_Active.UseVisualStyleBackColor = true;
            // 
            // FlowPanel_Active
            // 
            this.FlowPanel_Active.AutoScroll = true;
            this.FlowPanel_Active.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FlowPanel_Active.Controls.Add(this.TSKCNTRL_Bakalavr);
            this.FlowPanel_Active.Controls.Add(this.TSKCTRL_Semestr);
            this.FlowPanel_Active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel_Active.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanel_Active.Location = new System.Drawing.Point(3, 3);
            this.FlowPanel_Active.Name = "FlowPanel_Active";
            this.FlowPanel_Active.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.FlowPanel_Active.Size = new System.Drawing.Size(650, 372);
            this.FlowPanel_Active.TabIndex = 7;
            this.FlowPanel_Active.WrapContents = false;
            // 
            // TSKCNTRL_Bakalavr
            // 
            this.TSKCNTRL_Bakalavr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TSKCNTRL_Bakalavr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.Location = new System.Drawing.Point(8, 8);
            this.TSKCNTRL_Bakalavr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TSKCNTRL_Bakalavr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCNTRL_Bakalavr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCNTRL_Bakalavr.Name = "TSKCNTRL_Bakalavr";
            this.TSKCNTRL_Bakalavr.Size = new System.Drawing.Size(639, 150);
            this.TSKCNTRL_Bakalavr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.TabIndex = 9;
            this.TSKCNTRL_Bakalavr.Task = null;
            this.TSKCNTRL_Bakalavr.Title = "Бакалавриат";
            // 
            // TSKCTRL_Semestr
            // 
            this.TSKCTRL_Semestr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.Location = new System.Drawing.Point(8, 168);
            this.TSKCTRL_Semestr.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TSKCTRL_Semestr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCTRL_Semestr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCTRL_Semestr.Name = "TSKCTRL_Semestr";
            this.TSKCTRL_Semestr.Size = new System.Drawing.Size(639, 150);
            this.TSKCTRL_Semestr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.TabIndex = 10;
            this.TSKCTRL_Semestr.Task = null;
            this.TSKCTRL_Semestr.Title = "Практика";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage_Active);
            this.TabControl.Controls.Add(this.TabPage_Completed);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(664, 404);
            this.TabControl.TabIndex = 14;
            // 
            // MainIcon
            // 
            this.MainIcon.ContextMenuStrip = this.MainContextMenu;
            this.MainIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainIcon.Icon")));
            this.MainIcon.Text = "TaskProgresser";
            this.MainIcon.Visible = true;
            this.MainIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainIcon_MouseDoubleClick);
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripMenuItem_OpenMainWindow,
            ToolStripSeparator,
            ToolStripMenuItem_CloseApp});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(177, 54);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(664, 449);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 488);
            this.MinimumSize = new System.Drawing.Size(680, 488);
            this.Name = "MainForm";
            this.Text = "TaskProgresser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TabPage_Completed.ResumeLayout(false);
            this.TabPage_Active.ResumeLayout(false);
            this.FlowPanel_Active.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label Label_CurrentDateTime;
        private System.Windows.Forms.TabPage TabPage_Completed;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Completed;
        private System.Windows.Forms.TabPage TabPage_Active;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Active;
        private Forms.UserControls.TaskControl TSKCNTRL_Bakalavr;
        private Forms.UserControls.TaskControl TSKCTRL_Semestr;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.NotifyIcon MainIcon;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
    }
}

