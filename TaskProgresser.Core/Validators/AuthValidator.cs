using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProgresser.Core.Validators
{
    public static class AuthValidator
    {
        public static readonly int MAX_LOGIN_LENGTH = 100;
        public static readonly int MIN_LOGIN_LENGTH = 3;

        public static readonly int MAX_PASSWORD_LENGTH = 12;
        public static readonly int MIN_PASSWORD_LENGTH = 8;

        // Регулярное выражение для проверки логина (только буквы и цифры)
        public static readonly string LOGIN_PATTERN = $"^[\\w-]{{{MIN_LOGIN_LENGTH},{MAX_LOGIN_LENGTH}}}$";

        // Регулярное выражение для проверки пароля
        public static readonly string PASSWORD_PATTERN = $"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z-0-9])\\S{{{MIN_PASSWORD_LENGTH},{MAX_PASSWORD_LENGTH}}}$";


        //TODO: Возможно сделать кортеж, который будет возвращать список несоответствий для клиента
        public static bool ValidateLogin(string login)
        {
            //#1 Проверка на null или пустую строку
            if (string.IsNullOrWhiteSpace(login)) return false;

            //#2 Проверка на регулярное выражение
            if (!System.Text.RegularExpressions.Regex.IsMatch(login, LOGIN_PATTERN)) return false;

            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return false;

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, PASSWORD_PATTERN)) return false;

            return true;
        }

        public static readonly string LOGIN_ERROR_MESSAGE = $"Логін може містити a-z, A-Z, _, 0-9. Довжина від {MIN_LOGIN_LENGTH} до {MAX_LOGIN_LENGTH} символів.";
        public static readonly string PASSWORD_ERROR_MESSAGE = $"Пароль має містити хоча б один символ із кожного набору: a-z, A-Z, 0-9, спец-символи. Довжина від {MIN_PASSWORD_LENGTH} до {MAX_PASSWORD_LENGTH} символів.";
    }
}
