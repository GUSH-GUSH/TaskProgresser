namespace Weekinator.Forms
{
    partial class TrayFlayoutTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateRangeControl = new Weekinator.DateRangeControl();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateRangeControl
            // 
            this.DateRangeControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRangeControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DateRangeControl.EnableIcon = false;
            this.DateRangeControl.Location = new System.Drawing.Point(2, 8);
            this.DateRangeControl.MinimumSize = new System.Drawing.Size(300, 90);
            this.DateRangeControl.Name = "DateRangeControl";
            this.DateRangeControl.Precision = ((byte)(3));
            this.DateRangeControl.Size = new System.Drawing.Size(416, 90);
            this.DateRangeControl.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(420, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrayFlayoutTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 100);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DateRangeControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 92);
            this.Name = "TrayFlayoutTaskForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TrayFlayoutTaskForm";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.TrayFlayoutTaskForm_Deactivate);
            this.Load += new System.EventHandler(this.TrayFlayoutTaskForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DateRangeControl DateRangeControl;
        private System.Windows.Forms.Label Title;
    }
}