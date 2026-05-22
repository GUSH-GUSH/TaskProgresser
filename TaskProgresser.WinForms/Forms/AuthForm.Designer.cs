namespace TaskProgresser.WinForms.Forms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(0, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(47, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Увійти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(47, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Зареєструватися";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LBL_Username
            // 
            this.LBL_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Username.Location = new System.Drawing.Point(-1, 10);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(49, 20);
            this.LBL_Username.TabIndex = 4;
            this.LBL_Username.Text = "Логін";
            // 
            // LBL_Password
            // 
            this.LBL_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Password.Location = new System.Drawing.Point(-1, 65);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(67, 20);
            this.LBL_Password.TabIndex = 5;
            this.LBL_Password.Text = "Пароль";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.LBL_Password);
            this.MainPanel.Controls.Add(this.textBox2);
            this.MainPanel.Controls.Add(this.LBL_Username);
            this.MainPanel.Location = new System.Drawing.Point(47, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 127);
            this.MainPanel.TabIndex = 6;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(295, 305);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Panel MainPanel;
    }
}