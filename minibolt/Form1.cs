using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minibolt
{
    public partial class Form1 : Form
    {

        public decimal db1 = 0;
        public decimal price1 = 0;
        public decimal db2 = 0;
        public decimal price2 = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db1 = numericUpDown1.Value;
            price1 = Convert.ToDecimal(label1.Text);
            MessageBox.Show("Kosárba raktad a termékeket!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db2 = numericUpDown2.Value;
            price2 = Convert.ToDecimal(label2.Text);
            MessageBox.Show("Kosárba raktad a termékeket!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal result = (db1 * price1) + (db2 * price2);
            MessageBox.Show($"Köszönjük a vásárlást! A Végösszeg: {result}");
        }
    }
}
