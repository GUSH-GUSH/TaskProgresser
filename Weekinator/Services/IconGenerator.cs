using System;
using System.Drawing;
using System.Drawing.Imaging;

using System.Runtime.InteropServices;

namespace TaskProgresser.Services
{
    public static class IconGenerator
    {
        public static readonly Size DefaultSize = new Size(32, 32);
        public static readonly Font DefaultFont =
                                new Font("Bahnschrift SemiBold Condensed", 18, FontStyle.Regular);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        public static Icon GetIcon(string text, Font font, Size iconSize, Color textColor, Color BackgroundColor)
        {
            using (Bitmap bitmap = new Bitmap(
                            iconSize.Width,
                            iconSize.Height,
                            PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(BackgroundColor);

                    using (SolidBrush brush = new SolidBrush(textColor))
                    {
                        SizeF textSize = g.MeasureString(text, font);
                        float x = iconSize.Width / 2 - textSize.Width / 2;
                        float y = iconSize.Height / 2 - textSize.Height / 2;
                        g.DrawString(text, font, brush, x, y);
                    }
                }

                IntPtr hIcon = bitmap.GetHicon();
                Icon icon = (Icon)Icon.FromHandle(hIcon).Clone();
                DestroyIcon(hIcon);
                return icon;
            }
        }

        public static Icon GetDefaultIcon(string text) {
            return GetIcon(text, DefaultFont, DefaultSize, Color.White, Color.Black);
        }
    }
}
