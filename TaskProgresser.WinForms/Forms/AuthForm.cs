using System;
using System.Windows.Forms;
using TaskProgresser.Core.Validators;
using TaskProgresser.WinForms.Services;

using TaskProgresser.WinForms.Repositories.ApiClients;

namespace TaskProgresser.WinForms.Forms
{
    public partial class AuthForm : Form
    {
        private readonly AuthApiClient _authApiClient = new AuthApiClient();


        public string Username => TBOX_Username.Text;
        public string Password => TBOX_Password.Text;

        public string Token { get; private set; }

        private (bool username, bool password) isCorrect {
            get => (AuthValidator.ValidateLogin(TBOX_Username.Text), AuthValidator.ValidatePassword(TBOX_Password.Text));
        }


        public AuthForm()
        {
            InitializeComponent();
            LBL_Version.Text = $"Версія {VersionGetter.ShortVersion}";
        }

        private async void BTN_Login_Click(object sender, EventArgs e)
        {
            try {
                WaitingForm.ShowWaitingFormWithDefaultTimeMessage(this, LOGIN_PROCESSING_MESSAGE);
                Enabled = false;
                Token = await _authApiClient.LoginAsync(Username, Password);
                WaitingForm.CloseWaitingForm();
                MessageBox.Show(this, $"Вхід в аккаунт {Username} виконано успішно!", "Вітаємо!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, LOGIN_ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally { WaitingForm.CloseWaitingForm(); Enabled = true; }
        }

        private async void BTN_Reg_Click(object sender, EventArgs e)
        {
            if(!(isCorrect.username && isCorrect.password))
            {
                UpdateUsernameError();
                UpdatePasswordError();
                MessageBox.Show(this, $"Будь ласка, заповніть усі поля правильно.\n\n{AuthValidator.LOGIN_ERROR_MESSAGE}\n\n{AuthValidator.PASSWORD_ERROR_MESSAGE}", "Помилка реєстрації!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                WaitingForm.ShowWaitingFormWithDefaultTimeMessage(this, REGISTER_PROCESSING_MESSAGE);
                Enabled = false;
                await _authApiClient.RegisterAsync(Username, Password);
                WaitingForm.CloseWaitingForm();
                MessageBox.Show(this, $"Аккаунт {Username} успішно створено!", "Успіх!");
                BTN_Login_Click(this, new EventArgs());
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, REGISTER_ERROR_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Warning); WaitingForm.CloseWaitingForm(); Enabled = true; }
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

        private void TBOX_Username_TextChanged(object sender, EventArgs e) => UpdateUsernameError();

        private void TBOX_Password_TextChanged(object sender, EventArgs e) => UpdatePasswordError();
        
        private void UpdateUsernameError()
        {
            if (!isCorrect.username) ErrorProvider.SetError(TBOX_Username, AuthValidator.LOGIN_ERROR_MESSAGE);
            else ErrorProvider.SetError(TBOX_Username, string.Empty);
        }

        private void UpdatePasswordError()
        {
            if (!isCorrect.password) ErrorProvider.SetError(TBOX_Password, AuthValidator.PASSWORD_ERROR_MESSAGE);
            else ErrorProvider.SetError(TBOX_Password, string.Empty);
        }

        #endregion --- VALIDATION ---


        public static readonly string LOGIN_PROCESSING_MESSAGE = "Вхід в аккаунт...";
        public static readonly string LOGIN_ERROR_MESSAGE = "Помилка входу в аккаунт!";
        public static readonly string REGISTER_PROCESSING_MESSAGE = "Реєстрація нового аккаунта...";
        public static readonly string REGISTER_ERROR_MESSAGE = "Реєстрація нового аккаунта...";

    }
}
