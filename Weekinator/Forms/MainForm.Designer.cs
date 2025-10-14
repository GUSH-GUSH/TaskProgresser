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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.PrecentIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Precent = new System.Windows.Forms.NotifyIcon(this.components);
            this.openTestIconForm_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
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
            this.DateRangeControl.Location = new System.Drawing.Point(18, 37);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Size = new System.Drawing.Size(482, 90);
            this.DateRangeControl.TabIndex = 0;
            // 
            // PrecentIcon
            // 
            this.PrecentIcon.Text = "Weekinator";
            this.PrecentIcon.Visible = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 428);
            this.Controls.Add(this.openTestIconForm_Button);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(526, 200);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateRangeControl DateRangeControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon PrecentIcon;
        private System.Windows.Forms.NotifyIcon Precent;
        private System.Windows.Forms.Button openTestIconForm_Button;
    }
}

