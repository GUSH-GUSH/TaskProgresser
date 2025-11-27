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
            System.Windows.Forms.Label label1;
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Precision_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.openTestIconForm_Button = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CurrentDateTime_Label = new System.Windows.Forms.Label();
            CurrentDateTimeTitle_Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Precision_NumericUpDown)).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 13);
            label1.TabIndex = 10;
            label1.Text = "Точность:";
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.Precision_NumericUpDown);
            this.groupBox1.Controls.Add(this.DateRangeControl);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(110, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Семестр 4.1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Get Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Precision_NumericUpDown
            // 
            this.Precision_NumericUpDown.Location = new System.Drawing.Point(81, 137);
            this.Precision_NumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Precision_NumericUpDown.Name = "Precision_NumericUpDown";
            this.Precision_NumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.Precision_NumericUpDown.TabIndex = 6;
            this.Precision_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precision_NumericUpDown.ValueChanged += new System.EventHandler(this.Precission_NumericUpDown_ValueChanged);
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.Location = new System.Drawing.Point(18, 38);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.Size = new System.Drawing.Size(482, 90);
            this.DateRangeControl.TabIndex = 0;
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
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Precision_NumericUpDown)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DateRangeControl DateRangeControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openTestIconForm_Button;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CurrentDateTime_Label;
        private System.Windows.Forms.NumericUpDown Precision_NumericUpDown;
        private System.Windows.Forms.Button button2;
    }
}

