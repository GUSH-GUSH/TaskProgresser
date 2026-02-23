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
            System.Windows.Forms.Label Label_CurDateTimeTitle;
            this.BTN_OpenTestIconForm = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BTN_Load = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.Label_CurrentDateTime = new System.Windows.Forms.Label();
            this.TabPage_Completed = new System.Windows.Forms.TabPage();
            this.FlowPanel_Completed = new System.Windows.Forms.FlowLayoutPanel();
            this.TabPage_Active = new System.Windows.Forms.TabPage();
            this.FlowPanel_Active = new System.Windows.Forms.FlowLayoutPanel();
            this.TSKCTRL_Semestr = new Weekinator.Forms.UserControls.TaskControl();
            this.TSKCNTRL_Bakalavr = new Weekinator.Forms.UserControls.TaskControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            Label_CurDateTimeTitle = new System.Windows.Forms.Label();
            this.BottomPanel.SuspendLayout();
            this.TabPage_Completed.SuspendLayout();
            this.TabPage_Active.SuspendLayout();
            this.FlowPanel_Active.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_CurDateTimeTitle
            // 
            Label_CurDateTimeTitle.AutoSize = true;
            Label_CurDateTimeTitle.Location = new System.Drawing.Point(7, 17);
            Label_CurDateTimeTitle.Name = "Label_CurDateTimeTitle";
            Label_CurDateTimeTitle.Size = new System.Drawing.Size(125, 13);
            Label_CurDateTimeTitle.TabIndex = 8;
            Label_CurDateTimeTitle.Text = "Текущая дата и время:";
            // 
            // BTN_OpenTestIconForm
            // 
            this.BTN_OpenTestIconForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OpenTestIconForm.AutoSize = true;
            this.BTN_OpenTestIconForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_OpenTestIconForm.Location = new System.Drawing.Point(317, 12);
            this.BTN_OpenTestIconForm.Name = "BTN_OpenTestIconForm";
            this.BTN_OpenTestIconForm.Size = new System.Drawing.Size(88, 23);
            this.BTN_OpenTestIconForm.TabIndex = 7;
            this.BTN_OpenTestIconForm.Text = "Test Icon Form";
            this.BTN_OpenTestIconForm.UseVisualStyleBackColor = true;
            this.BTN_OpenTestIconForm.Click += new System.EventHandler(this.openTestIconForm_Button_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPanel.Controls.Add(this.BTN_Load);
            this.BottomPanel.Controls.Add(this.BTN_Save);
            this.BottomPanel.Controls.Add(this.Label_CurrentDateTime);
            this.BottomPanel.Controls.Add(Label_CurDateTimeTitle);
            this.BottomPanel.Controls.Add(this.BTN_OpenTestIconForm);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 406);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(664, 45);
            this.BottomPanel.TabIndex = 8;
            // 
            // BTN_Load
            // 
            this.BTN_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Load.AutoSize = true;
            this.BTN_Load.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Load.Location = new System.Drawing.Point(479, 12);
            this.BTN_Load.Name = "BTN_Load";
            this.BTN_Load.Size = new System.Drawing.Size(62, 23);
            this.BTN_Load.TabIndex = 11;
            this.BTN_Load.Text = "Load";
            this.BTN_Load.UseVisualStyleBackColor = true;
            this.BTN_Load.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Save.AutoSize = true;
            this.BTN_Save.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Save.Location = new System.Drawing.Point(411, 12);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(62, 23);
            this.BTN_Save.TabIndex = 10;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_CurrentDateTime
            // 
            this.Label_CurrentDateTime.AutoSize = true;
            this.Label_CurrentDateTime.Location = new System.Drawing.Point(127, 17);
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
            this.TabPage_Completed.Size = new System.Drawing.Size(603, 381);
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
            this.FlowPanel_Completed.Size = new System.Drawing.Size(603, 381);
            this.FlowPanel_Completed.TabIndex = 9;
            // 
            // TabPage_Active
            // 
            this.TabPage_Active.Controls.Add(this.FlowPanel_Active);
            this.TabPage_Active.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Active.Name = "TabPage_Active";
            this.TabPage_Active.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Active.Size = new System.Drawing.Size(656, 380);
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
            this.FlowPanel_Active.Size = new System.Drawing.Size(650, 374);
            this.FlowPanel_Active.TabIndex = 7;
            this.FlowPanel_Active.WrapContents = false;
            // 
            // TSKCTRL_Semestr
            // 
            this.TSKCTRL_Semestr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.Location = new System.Drawing.Point(6, 162);
            this.TSKCTRL_Semestr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCTRL_Semestr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCTRL_Semestr.Name = "TSKCTRL_Semestr";
            this.TSKCTRL_Semestr.Size = new System.Drawing.Size(639, 150);
            this.TSKCTRL_Semestr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.TabIndex = 10;
            this.TSKCTRL_Semestr.Task = null;
            this.TSKCTRL_Semestr.Title = "Практика";
            this.TSKCTRL_Semestr.DoubleClick += new System.EventHandler(this.TSKCTRL_Semestr_DoubleClick);
            // 
            // TSKCNTRL_Bakalavr
            // 
            this.TSKCNTRL_Bakalavr.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TSKCNTRL_Bakalavr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.Location = new System.Drawing.Point(6, 6);
            this.TSKCNTRL_Bakalavr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCNTRL_Bakalavr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCNTRL_Bakalavr.Name = "TSKCNTRL_Bakalavr";
            this.TSKCNTRL_Bakalavr.Size = new System.Drawing.Size(639, 150);
            this.TSKCNTRL_Bakalavr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.TabIndex = 9;
            this.TSKCNTRL_Bakalavr.Task = null;
            this.TSKCNTRL_Bakalavr.Title = "Бакалавриат";
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
            this.TabControl.Size = new System.Drawing.Size(664, 406);
            this.TabControl.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(664, 451);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.BottomPanel);
            this.MaximumSize = new System.Drawing.Size(680, 490);
            this.MinimumSize = new System.Drawing.Size(680, 490);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TabPage_Completed.ResumeLayout(false);
            this.TabPage_Active.ResumeLayout(false);
            this.FlowPanel_Active.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_OpenTestIconForm;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label Label_CurrentDateTime;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Load;
        private System.Windows.Forms.TabPage TabPage_Completed;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Completed;
        private System.Windows.Forms.TabPage TabPage_Active;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel_Active;
        private Forms.UserControls.TaskControl TSKCNTRL_Bakalavr;
        private Forms.UserControls.TaskControl TSKCTRL_Semestr;
        private System.Windows.Forms.TabControl TabControl;
    }
}

