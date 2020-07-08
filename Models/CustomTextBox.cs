using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsLibrary
{
    public partial class CustomTextBox : TextBox
    {
        #region Variables
        // Border
        private Color _BottomBorderColor = Color.Black;
        private Color _OnFocusColor = Color.Blue;
        // PlaceHolder
        private Color _WatermarkColor;
        private string _WatermarkText;
        private bool _Multiline = false;
        // Other
        private bool _IsPassword = false;
        #endregion

        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;

            //Add a label to the control (textbox)
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = _BottomBorderColor
            });

            InitializeComponent();
        }

        #region Border
        // Hides the BorderStyle from Control Preperty,
        // so to avoid people changing BorderStyle of the TextBox
        [Browsable(false)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        public Color BottomBorderColor
        {
            get { return _BottomBorderColor; }
            set
            {
                _BottomBorderColor = value;
                Controls[0].BackColor = _BottomBorderColor;
            }
        }

        public Color ButtonBorderOnFocusColor
        {
            get { return _OnFocusColor; }
            set { _OnFocusColor = value; }
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = _OnFocusColor;
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = _BottomBorderColor;
        }
        #endregion

        #region PlaceHolder
        [Browsable(false)]
        public new bool Multiline
        {
            get { return _Multiline; }
            set { _Multiline = false; }
        }

        [Browsable(true)]
        public Color ColorWatermark
        {
            get { return _WatermarkColor; }
            set { 
                _WatermarkColor = value;
                GetSetWatermark();
            }
        }

        // In order to get Watermark from the WatermarkText
        public string WatermarkText
        {
            get { return _WatermarkText; }
            set
            {
                _WatermarkText = value;
                GetSetWatermark();
            }
        }

        // This function will chech that wether the textbox is empty or not
        // If the textbox text is the same as Watermark then it will cinsider it watermark
        private void GetSetWatermark()
        {
            if((this.Text == WatermarkText) || (this.Text == string.Empty))
            {
                this.ForeColor = _WatermarkColor;
                this.Text = WatermarkText;
                this.PasswordChar = new char();
            }
            else
            {
                this.ForeColor = Color.Black;
                if (_IsPassword)
                    this.PasswordChar = '*';
            }
        }
        #endregion

        #region Other
        public bool IsPassword
        {
            get { return _IsPassword; }
            set { _IsPassword = value; }
        }
        #endregion
    }
}
