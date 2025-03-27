using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaloria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double ZsirkcalSzamit(double zsir)
        {
            return zsir * 9;
        }

        public static double SzenhidratkcalSzamit(double szenhidrat)
        {
            return szenhidrat * 4;
        }

        public static double OsszesitkcalSzamit(double kiszamoltzsir, double kiszamoltszenhidrat)
        {
            return kiszamoltzsir + kiszamoltszenhidrat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                double zsir = Convert.ToInt32(textBox1.Text);
                double szenhidrat = Convert.ToInt32(textBox2.Text);

                double kiszamoltzsir = ZsirkcalSzamit(zsir);
                double kiszamoltszenhidrat = SzenhidratkcalSzamit(szenhidrat);
                double osszesit = OsszesitkcalSzamit(kiszamoltzsir, kiszamoltszenhidrat);

                label7.Text = $"{zsir}g, {kiszamoltzsir} kcal";
                label8.Text = $"{szenhidrat}g, {kiszamoltszenhidrat} kcal";
                label9.Text = $"Az összesített kcal értéke: {osszesit}";
            
        }
    }
}
