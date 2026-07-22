using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TaskProgresser.WinForms.Helpers;

namespace TaskProgresser.WinForms
{
    public class DynamicTextNotifyIcon : Component
    {

        #region --- FIELDS ---

        private readonly NotifyIcon _notifyIcon;

        private string _displayText = "0";
        private Font _font = IconFactory.DefaultFont;
        private Size _size = IconFactory.DefaultSize;
        private Color _textColor = Color.White;
        private Color _backgroundColor = Color.Transparent;

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
            set => _notifyIcon.Text = value;// + _instanceSuffix;
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
                _font = value ?? IconFactory.DefaultFont;
                UpdateIcon();
            }
        }

        #endregion


        #region --- EVENTS ---

        public event EventHandler Click;
        public event EventHandler DoubleClick;

        #endregion


        #region --- SETUP ---

        public DynamicTextNotifyIcon()
        {
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Visible = false;
            _notifyIcon.MouseClick += (o, e) =>
            {
                if (e.Button == MouseButtons.Left) Click?.Invoke(o, e);
            };
            _notifyIcon.DoubleClick += (o, e) => DoubleClick?.Invoke(o, e);
            
            
            HeaderText = GetHashCode().ToString();

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
            //if (_notifyIcon?.Icon == null) return;
            _notifyIcon.Icon?.Dispose();
            _notifyIcon.Icon = IconFactory.GetIcon(_displayText, Font, _size, _textColor, _backgroundColor);
        }

        #endregion


        #region --- DISPOSE ---

        protected new void Dispose()
        {
            _notifyIcon.Visible = false;
            base.Dispose();
        }

        #endregion

    }
}