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
            System.Windows.Forms.Label CurrentDateTimeTitle_Label;
            this.openTestIconForm_Button = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentDateTime_Label = new System.Windows.Forms.Label();
            this.TSKCTRL_Semestr = new Weekinator.Forms.UserControls.TaskControl();
            this.TSKCNTRL_Bakalavr = new Weekinator.Forms.UserControls.TaskControl();
            CurrentDateTimeTitle_Label = new System.Windows.Forms.Label();
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
            // TSKCTRL_Semestr
            // 
            this.TSKCTRL_Semestr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.Location = new System.Drawing.Point(110, 73);
            this.TSKCTRL_Semestr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCTRL_Semestr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCTRL_Semestr.Name = "TSKCTRL_Semestr";
            this.TSKCTRL_Semestr.Size = new System.Drawing.Size(518, 150);
            this.TSKCTRL_Semestr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCTRL_Semestr.TabIndex = 10;
            this.TSKCTRL_Semestr.Title = "Практика";
            this.TSKCTRL_Semestr.DoubleClick += new System.EventHandler(this.TSKCTRL_Semestr_DoubleClick);
            // 
            // TSKCNTRL_Bakalavr
            // 
            this.TSKCNTRL_Bakalavr.End = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.Location = new System.Drawing.Point(110, 251);
            this.TSKCNTRL_Bakalavr.MaximumSize = new System.Drawing.Size(10000, 150);
            this.TSKCNTRL_Bakalavr.MinimumSize = new System.Drawing.Size(340, 150);
            this.TSKCNTRL_Bakalavr.Name = "TSKCNTRL_Bakalavr";
            this.TSKCNTRL_Bakalavr.Size = new System.Drawing.Size(518, 150);
            this.TSKCNTRL_Bakalavr.Start = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TSKCNTRL_Bakalavr.TabIndex = 9;
            this.TSKCNTRL_Bakalavr.Title = "Бакалавриат";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(711, 428);
            this.Controls.Add(this.TSKCTRL_Semestr);
            this.Controls.Add(this.TSKCNTRL_Bakalavr);
            this.Controls.Add(this.TopPanel);
            this.MinimumSize = new System.Drawing.Size(526, 200);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openTestIconForm_Button;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CurrentDateTime_Label;
        private Forms.UserControls.TaskControl TSKCNTRL_Bakalavr;
        private Forms.UserControls.TaskControl TSKCTRL_Semestr;
    }
}

