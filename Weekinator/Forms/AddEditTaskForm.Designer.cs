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
            this.lblCourseHours = new System.Windows.Forms.Label();
            this.nudCourseHours = new System.Windows.Forms.NumericUpDown();
            this.nudCourseECTS = new System.Windows.Forms.NumericUpDown();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateRangeControl = new Weekinator.DateRangeControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseECTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Назва:";
            // 
            // txtName
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(15, 31);
            this.txtTitle.Name = "txtName";
            this.txtTitle.Size = new System.Drawing.Size(527, 20);
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
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 78);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(530, 80);
            this.txtDescription.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(360, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(450, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCourseHours
            // 
            this.lblCourseHours.AutoSize = true;
            this.lblCourseHours.Location = new System.Drawing.Point(19, 520);
            this.lblCourseHours.Name = "lblCourseHours";
            this.lblCourseHours.Size = new System.Drawing.Size(132, 13);
            this.lblCourseHours.TabIndex = 20;
            this.lblCourseHours.Text = "Довжина курсу (години):";
            // 
            // nudCourseHours
            // 
            this.nudCourseHours.Location = new System.Drawing.Point(154, 518);
            this.nudCourseHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCourseHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseHours.Name = "nudCourseHours";
            this.nudCourseHours.Size = new System.Drawing.Size(45, 20);
            this.nudCourseHours.TabIndex = 8;
            this.nudCourseHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCourseECTS
            // 
            this.nudCourseECTS.DecimalPlaces = 1;
            this.nudCourseECTS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCourseECTS.Location = new System.Drawing.Point(309, 518);
            this.nudCourseECTS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudCourseECTS.Name = "nudCourseECTS";
            this.nudCourseECTS.Size = new System.Drawing.Size(45, 20);
            this.nudCourseECTS.TabIndex = 9;
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
            this.DateRangeControl.Size = new System.Drawing.Size(530, 90);
            this.DateRangeControl.TabIndex = 21;
            // 
            // AddEditTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.DateRangeControl);
            this.Controls.Add(this.nudCourseECTS);
            this.Controls.Add(this.lblCourseHours);
            this.Controls.Add(this.nudCourseHours);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseECTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblCourseHours;
        private NumericUpDown nudCourseHours;
        private NumericUpDown nudCourseECTS;
        private ErrorProvider ErrorProvider;
        private Weekinator.DateRangeControl DateRangeControl;
    }
}

