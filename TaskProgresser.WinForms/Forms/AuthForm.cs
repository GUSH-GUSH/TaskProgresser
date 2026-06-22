using System;
using System.Windows.Forms;
using TaskProgresser.Core.Validators;

using TaskProgresser.WinForms.ApiClients;

namespace TaskProgresser.WinForms.Forms
{
    public partial class AuthForm : Form
    {
        private readonly AuthApiClient _authApiClient = new AuthApiClient();
        private (bool username, bool password) _isCorrect = (false, false);



        public string Username => TBOX_Username.Text;
        public string Password => TBOX_Password.Text;

        public string Token { get; private set; }

        private (bool username, bool password) isCorrect {
            get => _isCorrect;
            set
            {
                _isCorrect = value;
                EnabledButtons = value.username && value.password;
            }
        }

        private bool EnabledButtons {
            set
            {
                BTN_Login.Enabled = value;
                BTN_Reg.Enabled = value;
            }
        }



        public AuthForm()
        {
            InitializeComponent();
            EnabledButtons = false;
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

        private void CHB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            TBOX_Password.PasswordChar = CHB_ShowPass.Checked ? '\0' : '•';
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Token  == null) DialogResult = DialogResult.Cancel;
        }



        #region --- VALIDATION ---

        private void TBOX_Username_TextChanged(object sender, EventArgs e)
        {
            if(!AuthValidator.ValidateLogin(TBOX_Username.Text))
            {
                ErrorProvider.SetError(TBOX_Username, AuthValidator.LOGIN_ERROR_MESSAGE);
                isCorrect = (false, isCorrect.password);
            }
            else
            {
                ErrorProvider.SetError(TBOX_Username, string.Empty);
                isCorrect = (true, isCorrect.password);
            }
        }

        private void TBOX_Password_TextChanged(object sender, EventArgs e)
        {
            if (!AuthValidator.ValidatePassword(TBOX_Password.Text))
            {
                ErrorProvider.SetError(TBOX_Password, AuthValidator.PASSWORD_ERROR_MESSAGE);
                isCorrect = (isCorrect.username, false);
            }
            else
            {
                ErrorProvider.SetError(TBOX_Password, string.Empty);
                isCorrect = (isCorrect.username, true);
            }
        }

        
        #endregion --- VALIDATION ---

    }
}
