using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafgyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ar = 360;
            int classsic = Convert.ToInt32(textBox1.Text);
            int cherry = Convert.ToInt32(textBox2.Text);
            int redorange = Convert.ToInt32(textBox3.Text);

            int osszeg = 360 * (cherry + classsic + redorange);

            label5.Text = $"Összesen {osszeg} Ft lesz a fizetendő összeg.";
        }
    }
}
