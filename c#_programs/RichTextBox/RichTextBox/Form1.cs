using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;
            oldFont = this.richTextBox1.SelectionFont;
            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;
            // Get the font that is being used in the selected text.
            oldFont = this.richTextBox1.SelectionFont;
            // If the font is using Italic style now, we should remove it.
            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            // Insert the new font.
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;
            // Get the font that is being used in the selected text.
            oldFont = this.richTextBox1.SelectionFont;
            // If the font is using Underline style now, we should remove it.
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            // Insert the new font.
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
                this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            else
                this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBox1.Focus();
        }

        private void ApplyTextSize(string textSize)
        {
            float newSize = Convert.ToSingle(textSize);
            FontFamily currentFontFamily;
            Font newFont;
            currentFontFamily = this.richTextBox1.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);
            this.richTextBox1.SelectionFont = newFont;
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) &&e.KeyChar != 8 && e.KeyChar != 13)
                e.Handled = true;
            else if (e.KeyChar == 13)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Length > 0)
                    ApplyTextSize(txt.Text);
                e.Handled = true;
                this.richTextBox1.Focus();
            }
        }

        private void textBoxSize_Validated(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            ApplyTextSize(txt.Text);
            this.richTextBox1.Focus();
        }

        private void richTextBoxText_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("Test.rtf");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No file to load yet");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile("Test.rtf");
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
