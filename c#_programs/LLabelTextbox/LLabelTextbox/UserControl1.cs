using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLabelTextbox
{
    public partial class ctlLabelTextbox: UserControl
    {
        private string labelText = "";
        public enum PositionEnum
        {
            Right,
            Below
        }

        private PositionEnum position = PositionEnum.Right;
        private int textboxMargin = 0;

        public PositionEnum Position
        {
            get { return position; }
            set
            {
                position = value;
                MoveControls();
            }
        }

        public int TextboxMargin
        {
            get { return textboxMargin; }
            set
            {
                textboxMargin = value;
                MoveControls();
            }
        }

        private void ctlLabelTextbox_Load(object sender, EventArgs e)
        {
            labelCaption.Text = labelText;
            Height = textBoxText.Height > labelCaption.Height ?
            textBoxText.Height : labelCaption.Height;
            MoveControls();
        }
        private void ctlLabelTextbox_SizeChanged(object sender, System.EventArgs e)
        {
            MoveControls();
        }

        private void MoveControls()
        {
            switch (position)
            {
                case PositionEnum.Below:
                    textBoxText.Top = labelCaption.Bottom;
                    textBoxText.Left = labelCaption.Left;
                    textBoxText.Width = Width;
                    Height = textBoxText.Height + labelCaption.Height;
                    break;
                case PositionEnum.Right:
                    textBoxText.Top = labelCaption.Top;
                    if (textboxMargin == 0)
                    {
                        int width = Width - labelCaption.Width - 3;
                        textBoxText.Left = labelCaption.Right + 3;
                        textBoxText.Width = width;
                    }
                    else
                    {
                        textBoxText.Left = textboxMargin + labelCaption.Width;
                        textBoxText.Width = Width - textBoxText.Left;
                    }
                    Height = textBoxText.Height > labelCaption.Height ?
                    textBoxText.Height : labelCaption.Height;
                    break;
            }
        }

        public string LabelText
        {
            get { return labelCaption.Text; }
            set
            {
                labelCaption.Text = LabelText =  value;
                MoveControls();
            }
        }
        public string TextboxText
        {
            get { return textBoxText.Text; }
            set
            {
                textBoxText.Text = value;
            }
        }

        public ctlLabelTextbox()
        {
            InitializeComponent();
        }

        
    }
}
