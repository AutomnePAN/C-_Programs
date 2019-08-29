using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOK.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ValidateOK()
        {
            this.buttonOK.Enabled = (textBoxName.BackColor != Color.Red &&
                                     textBoxAddr.BackColor != Color.Red &&
                                     textBoxAge.BackColor != Color.Red);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name: " + textBoxName.Text + "\r\n";
            output += "Address: " + textBoxAddr.Text + "\r\n";
            output += "Occupation: " + (string)(checkBoxProgrammer.Checked ?"Programmer" : "Not a programmer") + "\r\n";
            output += "Sex: " + (string)(radioButtonFemale.Checked ? "Female" :
            "Male") + "\r\n";
            output += "Age: " + textBoxAge.Text;
            textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name = Your name\r\n";
            output += "Address = Your address\r\n";
            output += "Programmer = Check 'Programmer' if you are a programmer\r\n";
            output += "Sex = Choose your sex\r\n";
            output += "Age = Your age";
            // Insert the new text.
            this.textBoxOutput.Text = output;
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;
            ValidateOK();
        }

       

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
