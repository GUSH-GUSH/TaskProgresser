namespace TaskProgresser.WinForms
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
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenMainWindow;
            System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
            System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CloseApp;
            System.Windows.Forms.Label Label_CurDateTimeTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_UsernameTitle = new System.Windows.Forms.Label();
            this.Label_CurrentDateTime = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CHB_IsLocalData = new System.Windows.Forms.CheckBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BTN_Statistics = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage_Active = new System.Windows.Forms.TabPage();
            this.FlowPanel_Active = new System.Windows.Forms.FlowLayoutPanel();
            this.TSKCNTRL_Bakalavr = new TaskProgresser.WinForms.Forms.UserControls.TaskControl();
            this.TSKCTRL_Semestr = new TaskProgresser.WinForms.Forms.UserControls.TaskControl();
            this.TabPage_Completed = new System.Windows.Forms.TabPage();
            this.FlowPanel_Completed = new System.Windows.Forms.FlowLayoutPanel();
            ToolStripMenuItem_OpenMainWindow = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            ToolStripMenuItem_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
            Label_CurDateTimeTitle = new System.Windows.Forms.Label();
            this.MainContextMenu.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabPage_Active.SuspendLayout();
            this.FlowPanel_Active.SuspendLayout();
            this.TabPage_Completed.SuspendLayout();
            this.SuspendLayout();
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
            // Label_CurDateTimeTitle
            // 
            Label_CurDateTimeTitle.AutoSize = true;
            Label_CurDateTimeTitle.Location = new System.Drawing.Point(7, 17);
            Label_CurDateTimeTitle.Name = "Label_CurDateTimeTitle";
            Label_CurDateTimeTitle.Size = new System.Drawing.Size(112, 13);
            Label_CurDateTimeTitle.TabIndex = 8;
            Label_CurDateTimeTitle.Text = "Поточна дата та час:";
            // 
            // MainIcon
            // 
            this.MainIcon.ContextMenuStrip = this.MainContextMenu;
            this.MainIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainIcon.Icon")));
            this.MainIcon.Text = "TaskProgresser.WinForms";
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
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.BTN_Logout);
            this.TopPanel.Controls.Add(this.LBL_Username);
            this.TopPanel.Controls.Add(this.LBL_UsernameTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(664, 33);
            this.TopPanel.TabIndex = 15;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.Location = new System.Drawing.Point(552, 5);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(105, 23);
            this.BTN_Logout.TabIndex = 2;
            this.BTN_Logout.Text = "Вихід з аккаунта";
            this.BTN_Logout.UseVisualStyleBackColor = true;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // LBL_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Username.Location = new System.Drawing.Point(96, 9);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(33, 16);
            this.LBL_Username.TabIndex = 1;
            this.LBL_Username.Text = "ім\'я";
            // 
            // LBL_UsernameTitle
            // 
            this.LBL_UsernameTitle.AutoSize = true;
            this.LBL_UsernameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_UsernameTitle.Location = new System.Drawing.Point(3, 9);
            this.LBL_UsernameTitle.Name = "LBL_UsernameTitle";
            this.LBL_UsernameTitle.Size = new System.Drawing.Size(95, 16);
            this.LBL_UsernameTitle.TabIndex = 0;
            this.LBL_UsernameTitle.Text = "Користувач";
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
            // CHB_IsLocalData
            // 
            this.CHB_IsLocalData.AutoSize = true;
            this.CHB_IsLocalData.Enabled = false;
            this.CHB_IsLocalData.Location = new System.Drawing.Point(231, 13);
            this.CHB_IsLocalData.Name = "CHB_IsLocalData";
            this.CHB_IsLocalData.Size = new System.Drawing.Size(141, 17);
            this.CHB_IsLocalData.TabIndex = 13;
            this.CHB_IsLocalData.Text = "Локальное хранилище";
            this.CHB_IsLocalData.UseVisualStyleBackColor = true;
            this.CHB_IsLocalData.Visible = false;
            this.CHB_IsLocalData.CheckedChanged += new System.EventHandler(this.CHB_IsLocalData_CheckedChangedAsync);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.BTN_Statistics);
            this.BottomPanel.Controls.Add(this.BTN_Update);
            this.BottomPanel.Controls.Add(this.CHB_IsLocalData);
            this.BottomPanel.Controls.Add(this.BTN_Add);
            this.BottomPanel.Controls.Add(this.Label_CurrentDateTime);
            this.BottomPanel.Controls.Add(Label_CurDateTimeTitle);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 404);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(664, 45);
            this.BottomPanel.TabIndex = 8;
            // 
            // BTN_Statistics
            // 
            this.BTN_Statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Statistics.AutoSize = true;
            this.BTN_Statistics.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Statistics.Location = new System.Drawing.Point(369, 12);
            this.BTN_Statistics.Name = "BTN_Statistics";
            this.BTN_Statistics.Size = new System.Drawing.Size(90, 26);
            this.BTN_Statistics.TabIndex = 15;
            this.BTN_Statistics.Text = "Статистика";
            this.BTN_Statistics.UseVisualStyleBackColor = true;
            this.BTN_Statistics.Click += new System.EventHandler(this.BTN_Statistics_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Update.AutoSize = true;
            this.BTN_Update.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Update.Location = new System.Drawing.Point(465, 12);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(70, 26);
            this.BTN_Update.TabIndex = 14;
            this.BTN_Update.Text = "Оновити";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage_Active);
            this.TabControl.Controls.Add(this.TabPage_Completed);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TabControl.Location = new System.Drawing.Point(0, 33);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(664, 371);
            this.TabControl.TabIndex = 16;
            // 
            // TabPage_Active
            // 
            this.TabPage_Active.Controls.Add(this.FlowPanel_Active);
            this.TabPage_Active.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Active.Name = "TabPage_Active";
            this.TabPage_Active.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Active.Size = new System.Drawing.Size(656, 345);
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
            this.FlowPanel_Active.Padding = new System.Windows.Forms.Padding(3);
            this.FlowPanel_Active.Size = new System.Drawing.Size(650, 339);
            this.FlowPanel_Active.TabIndex = 8;
            this.FlowPanel_Active.WrapContents = false;
            // 
            // TSKCNTRL_Bakalavr
            // 
            this.TSKCNTRL_Bakalavr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TSKCNTRL_Bakalavr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.Location = new System.Drawing.Point(8, 8);
            this.TSKCNTRL_Bakalavr.Margin = new System.Windows.Forms.Padding(5);
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
            this.TSKCTRL_Semestr.Margin = new System.Windows.Forms.Padding(5);
            this.TSKCTRL_Semestr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCTRL_Semestr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCTRL_Semestr.Name = "TSKCTRL_Semestr";
            this.TSKCTRL_Semestr.Size = new System.Drawing.Size(639, 150);
            this.TSKCTRL_Semestr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.TabIndex = 10;
            this.TSKCTRL_Semestr.Task = null;
            this.TSKCTRL_Semestr.Title = "Практика";
            // 
            // TabPage_Completed
            // 
            this.TabPage_Completed.Controls.Add(this.FlowPanel_Completed);
            this.TabPage_Completed.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Completed.Name = "TabPage_Completed";
            this.TabPage_Completed.Size = new System.Drawing.Size(656, 345);
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
            this.FlowPanel_Completed.Padding = new System.Windows.Forms.Padding(3);
            this.FlowPanel_Completed.Size = new System.Drawing.Size(656, 345);
            this.FlowPanel_Completed.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(664, 449);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 488);
            this.MinimumSize = new System.Drawing.Size(680, 488);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskProgresser.WinForms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainContextMenu.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TabPage_Active.ResumeLayout(false);
            this.FlowPanel_Active.ResumeLayout(false);
            this.TabPage_Completed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon MainIcon;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Label_CurrentDateTime;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.CheckBox CHB_IsLocalData;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label LBL_UsernameTitle;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage_Active;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Active;
        private Forms.UserControls.TaskControl TSKCNTRL_Bakalavr;
        private Forms.UserControls.TaskControl TSKCTRL_Semestr;
        private System.Windows.Forms.TabPage TabPage_Completed;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Completed;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Statistics;
    }
}

