namespace Weekinator.Forms.DebugForms
{
    partial class TextIconTestForm
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
            this.components = new System.ComponentModel.Container();
            this.fontStyle_ComboBox = new System.Windows.Forms.ComboBox();
            this.fontFamily_ComboBox = new System.Windows.Forms.ComboBox();
            this.iconText_TextBox = new System.Windows.Forms.TextBox();
            this.fontSize_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fontStyle_ComboBox
            // 
            this.fontStyle_ComboBox.FormattingEnabled = true;
            this.fontStyle_ComboBox.Location = new System.Drawing.Point(379, 24);
            this.fontStyle_ComboBox.Name = "fontStyle_ComboBox";
            this.fontStyle_ComboBox.Size = new System.Drawing.Size(78, 21);
            this.fontStyle_ComboBox.TabIndex = 8;
            this.fontStyle_ComboBox.SelectedIndexChanged += new System.EventHandler(this.fontStyle_ComboBox_SelectedIndexChanged);
            // 
            // fontFamily_ComboBox
            // 
            this.fontFamily_ComboBox.FormattingEnabled = true;
            this.fontFamily_ComboBox.Location = new System.Drawing.Point(194, 24);
            this.fontFamily_ComboBox.Name = "fontFamily_ComboBox";
            this.fontFamily_ComboBox.Size = new System.Drawing.Size(179, 21);
            this.fontFamily_ComboBox.TabIndex = 7;
            this.fontFamily_ComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamily_ComboBox_SelectedIndexChanged);
            // 
            // iconText_TextBox
            // 
            this.iconText_TextBox.Location = new System.Drawing.Point(23, 24);
            this.iconText_TextBox.Name = "iconText_TextBox";
            this.iconText_TextBox.Size = new System.Drawing.Size(100, 20);
            this.iconText_TextBox.TabIndex = 6;
            this.iconText_TextBox.TextChanged += new System.EventHandler(this.iconText_TextBox_TextChanged);
            // 
            // fontSize_NumericUpDown
            // 
            this.fontSize_NumericUpDown.Location = new System.Drawing.Point(129, 24);
            this.fontSize_NumericUpDown.Name = "fontSize_NumericUpDown";
            this.fontSize_NumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.fontSize_NumericUpDown.TabIndex = 5;
            this.fontSize_NumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize_NumericUpDown.ValueChanged += new System.EventHandler(this.fontSize_NumericUpDown_ValueChanged);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            // 
            // TextIconTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 70);
            this.Controls.Add(this.fontStyle_ComboBox);
            this.Controls.Add(this.fontFamily_ComboBox);
            this.Controls.Add(this.iconText_TextBox);
            this.Controls.Add(this.fontSize_NumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TextIconTestForm";
            this.Text = "TextIconTestForm";
            this.Load += new System.EventHandler(this.TextIconTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontSize_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fontStyle_ComboBox;
        private System.Windows.Forms.ComboBox fontFamily_ComboBox;
        private System.Windows.Forms.TextBox iconText_TextBox;
        private System.Windows.Forms.NumericUpDown fontSize_NumericUpDown;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
    }
}