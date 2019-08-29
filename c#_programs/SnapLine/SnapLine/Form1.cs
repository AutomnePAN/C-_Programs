using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "SURPRISE MOTHER FUCKER!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SURPRISE MOTHER FUCKER!";
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Hello world!";
        }
    }
}
