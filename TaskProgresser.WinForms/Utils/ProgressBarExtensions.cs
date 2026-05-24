using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskProgresser.WinForms.Utils
{
    public static class ProgressBarExtensions
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Константа сообщения для изменения состояния
        private const uint PBM_SETSTATE = 0x0410; //  Команда "Установить" (1040)
        private const uint PBM_GETSTATE = 0x0411; // Команда "Получить" (1041)
        public enum ProgressBarColor : int
        {
            Green = 1, // Зеленый
            Red = 2,  // Красный
            Yellow = 3 // Желтый
        }

        public static void SetColor(this ProgressBar pBar, ProgressBarColor color)
        {
            SendMessage(pBar.Handle, PBM_SETSTATE, (IntPtr)color, IntPtr.Zero);
            Update(pBar);
        }
        public static ProgressBarColor GetColor(this ProgressBar pBar)
        {
            // Отправляем команду получения. wParam и lParam здесь равны нулю.
            IntPtr result = SendMessage(pBar.Handle, PBM_GETSTATE, IntPtr.Zero, IntPtr.Zero);

            // Преобразуем полученный результат (число) обратно в наш удобный enum
            return (ProgressBarColor)result.ToInt32();
        }

        public static void Update(ProgressBar pBar)
        {
            // Защита от выхода за пределы
            if (pBar.Value == pBar.Maximum)
            {
                pBar.Value -= 10;       // Шагаем назад (анимация сбрасывается)
                pBar.Value = pBar.Maximum;           // Возвращаемся в максимум
            }
            else
            {
                pBar.Value += 10;       // Шагаем назад (анимация сбрасывается)
                pBar.Value = pBar.Minimum;
            }
        }
    }
}