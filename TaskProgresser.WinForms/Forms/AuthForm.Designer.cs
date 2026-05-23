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
            this.TBOX_Username = new System.Windows.Forms.TextBox();
            this.TBOX_Password = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Reg = new System.Windows.Forms.Button();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Pass = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CHB_ShowPass = new System.Windows.Forms.CheckBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBOX_Username
            // 
            this.TBOX_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOX_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBOX_Username.Location = new System.Drawing.Point(0, 35);
            this.TBOX_Username.Name = "TBOX_Username";
            this.TBOX_Username.Size = new System.Drawing.Size(200, 26);
            this.TBOX_Username.TabIndex = 0;
            // 
            // TBOX_Password
            // 
            this.TBOX_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOX_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBOX_Password.Location = new System.Drawing.Point(0, 90);
            this.TBOX_Password.Name = "TBOX_Password";
            this.TBOX_Password.PasswordChar = '*';
            this.TBOX_Password.Size = new System.Drawing.Size(200, 26);
            this.TBOX_Password.TabIndex = 1;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Login.Location = new System.Drawing.Point(47, 198);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(200, 36);
            this.BTN_Login.TabIndex = 2;
            this.BTN_Login.Text = "Увійти";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Reg
            // 
            this.BTN_Reg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_Reg.Location = new System.Drawing.Point(47, 241);
            this.BTN_Reg.Name = "BTN_Reg";
            this.BTN_Reg.Size = new System.Drawing.Size(200, 36);
            this.BTN_Reg.TabIndex = 3;
            this.BTN_Reg.Text = "Зареєструватися";
            this.BTN_Reg.UseVisualStyleBackColor = true;
            this.BTN_Reg.Click += new System.EventHandler(this.BTN_Reg_Click);
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
            // LBL_Pass
            // 
            this.LBL_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Pass.AutoSize = true;
            this.LBL_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBL_Pass.Location = new System.Drawing.Point(-1, 65);
            this.LBL_Pass.Name = "LBL_Pass";
            this.LBL_Pass.Size = new System.Drawing.Size(67, 20);
            this.LBL_Pass.TabIndex = 5;
            this.LBL_Pass.Text = "Пароль";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.Controls.Add(this.CHB_ShowPass);
            this.MainPanel.Controls.Add(this.TBOX_Username);
            this.MainPanel.Controls.Add(this.LBL_Pass);
            this.MainPanel.Controls.Add(this.TBOX_Password);
            this.MainPanel.Controls.Add(this.LBL_Username);
            this.MainPanel.Location = new System.Drawing.Point(47, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 143);
            this.MainPanel.TabIndex = 6;
            // 
            // CHB_ShowPass
            // 
            this.CHB_ShowPass.AutoSize = true;
            this.CHB_ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CHB_ShowPass.Location = new System.Drawing.Point(3, 119);
            this.CHB_ShowPass.Name = "CHB_ShowPass";
            this.CHB_ShowPass.Size = new System.Drawing.Size(90, 20);
            this.CHB_ShowPass.TabIndex = 7;
            this.CHB_ShowPass.Text = "Показати";
            this.CHB_ShowPass.UseVisualStyleBackColor = true;
            this.CHB_ShowPass.CheckedChanged += new System.EventHandler(this.CHB_ShowPass_CheckedChanged);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(295, 305);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BTN_Reg);
            this.Controls.Add(this.BTN_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBOX_Username;
        private System.Windows.Forms.TextBox TBOX_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Reg;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Pass;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox CHB_ShowPass;
    }
}