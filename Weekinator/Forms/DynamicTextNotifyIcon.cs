using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Weekinator.Services;
using System.Text;


namespace Weekinator
{
    public class DynamicTextNotifyIcon : Component
    {

        #region --- FIELDS ---

        private readonly NotifyIcon _notifyIcon;

        private string _displayText = "0";
        private Font _font = IconGenerator.DefaultFont;
        private Size _size = IconGenerator.DefaultSize;
        private Color _textColor = Color.White;
        private Color _backgroundColor = Color.Transparent;

        private string _instanceSuffix; //for identification icon in tray;

        #endregion


        #region --- PROPERTIES ---

        public bool Visible
        {
            get => _notifyIcon.Visible;
            set => _notifyIcon.Visible = value;
        }
        public ContextMenuStrip ContextMenuStrip
        {
            get => _notifyIcon.ContextMenuStrip;
            set => _notifyIcon.ContextMenuStrip = value;
        }
        public ToolTipIcon BaloonTipIcon {
            get => _notifyIcon.BalloonTipIcon;
            set => _notifyIcon.BalloonTipIcon = value;
        }
        public string BaloonTipTitle
        {
            get => _notifyIcon.BalloonTipTitle;
            set => _notifyIcon.BalloonTipTitle = value;
        }
        public string BaloonTipText
        {
            get => _notifyIcon.BalloonTipText;
            set => _notifyIcon.BalloonTipText = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Текст, отображаемый при наведении")]
        public string HeaderText {
            get => _notifyIcon.Text;
            //set => _notifyIcon.Text = value + _instanceSuffix;
        }

        [Description("Текст, который будет отображаться на иконке")]
        public string DisplayText
        {
            get => _displayText;
            set
            {
                if (_displayText == value) return;                
                if (string.IsNullOrEmpty(value)) _displayText = "";
                else _displayText = value;

                UpdateIcon();
            }
        }

        [Description("Шрифт для текста на иконке")]
        public Font Font
        {
            get => _font;
            set
            {
                _font = value ?? IconGenerator.DefaultFont;
                UpdateIcon();
            }
        }

        #endregion


        #region --- SETUP ---

        public DynamicTextNotifyIcon()
        {
            //Суффикс-идентификатор, который добавляется в HeaderText для того, чтобы винда отличала иконки
            StringBuilder sb = new StringBuilder(++instanceCount);
            for (int i = 0; i < instanceCount; i++) sb.Append(IDENTIFIER);
            _instanceSuffix = sb.ToString();
            
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Visible = false;
            _notifyIcon.Text = GetHashCode().ToString();

            UpdateIcon();
        }

        public DynamicTextNotifyIcon(IContainer container) : this()
        {
            container.Add(this);
        }

        #endregion


        #region --- LOGIC ---

        private void UpdateIcon()
        {
            _notifyIcon.Icon?.Dispose();
            _notifyIcon.Icon = IconGenerator.GetIcon(_displayText, Font, _size, _textColor, _backgroundColor);
        }

        #endregion


        #region --- DISPOSE ---

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _notifyIcon.Visible = false;
                _notifyIcon.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion


        #region --- STATIC ---

        private const char IDENTIFIER = '\t';
        private static int instanceCount = 0;
        
        #endregion

    }
}