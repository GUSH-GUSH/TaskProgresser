using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TaskProgresser.WinForms.ApiClients;

namespace TaskProgresser.WinForms.Forms
{
    public partial class AuthForm : Form
    {
        private bool _enabled = true;
        private readonly AuthApiClient _authApiClient = new AuthApiClient();
        
        public string Username => TBOX_Username.Text;
        public string Password => TBOX_Password.Text;

        public string Token { get; private set; }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void CHB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TBOX_Password.PasswordChar = CHB_ShowPass.Checked ? '\0' : '•';
        }

        private async void BTN_Login_Click(object sender, EventArgs e)
        {
            try {
                Enabled = false;
                Token = await _authApiClient.LoginAsync(Username, Password);
                MessageBox.Show(this, $"Вхід в аккаунт {Username} виконано успішно!", "Вітаємо!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { Enabled = true; }
        }

        private async void BTN_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                await _authApiClient.RegisterAsync(Username, Password);
                MessageBox.Show(this, $"Аккаунт {Username} успішно створено!", "Успіх!");
                BTN_Login_Click(this, new EventArgs());
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); Enabled = true; }
        }
    }
}
