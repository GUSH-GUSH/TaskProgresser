using System.Drawing;
using System.Windows.Forms;

namespace CourseWork.Forms
{

    partial class AddEditTaskForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTitle;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Назва*:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(15, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(578, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(36, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Опис:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 78);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(581, 80);
            this.txtDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(219, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(305, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.EnableIcon = false;
            this.DateRangeControl.Location = new System.Drawing.Point(12, 166);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.Size = new System.Drawing.Size(581, 90);
            this.DateRangeControl.TabIndex = 21;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(23, 261);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(101, 13);
            this.lblStartDate.TabIndex = 22;
            this.lblStartDate.Text = "Дата призначення";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(479, 259);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(98, 13);
            this.lblEndDate.TabIndex = 23;
            this.lblEndDate.Text = "Дата завершення";
            // 
            // AddEditTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(605, 321);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.DateRangeControl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(340, 360);
            this.Name = "AddEditTaskForm";
            this.Text = "Задача";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private ErrorProvider ErrorProvider;
        private Weekinator.DateRangeControl DateRangeControl;
        private Label lblEndDate;
        private Label lblStartDate;
    }
}

