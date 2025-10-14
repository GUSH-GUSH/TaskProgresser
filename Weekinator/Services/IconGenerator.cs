using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekinator.Services
{
    public static class IconGenerator
    {
        public static readonly Size DefaultSize = new Size(32, 32);
        public static readonly Font DefaultFont =
                                new Font("Bahnschrift SemiBold Condensed", 18, FontStyle.Regular);

        public static Icon GetIcon(string text, Font font, Size iconSize)
        {
            using (Bitmap bitmap = new Bitmap(
                            iconSize.Width,
                            iconSize.Height,
                            PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.Transparent); // Очищаем фон, делаем его прозрачным

                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        // Рисуем текст в центре
                        SizeF textSize = g.MeasureString(text, font);
                        float x = iconSize.Width / 2 - textSize.Width / 2;
                        float y = iconSize.Height / 2 - textSize.Height / 2;
                        g.DrawString(text, font, brush, x, y);
                    }
                }

                // Создаём Icon из Bitmap. Это и есть решение!
                IntPtr hIcon = bitmap.GetHicon();
                Icon icon = Icon.FromHandle(hIcon);
                return icon;
            }
        }

        public static Icon GetDefaultIcon(string text) {
            return GetIcon(text, DefaultFont, DefaultSize);   
        }
    }
}
