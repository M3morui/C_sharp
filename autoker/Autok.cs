using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoker
{
    public partial class Autok : Form
    {
        public Autok()
        {
            InitializeComponent();
        }

        public static List<Rendeles> Auto = new List<Rendeles>();

        public class Rendeles
        {
            public string marka;
            public decimal ar;
            public int db;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string marka = label1.Text;
            decimal ar = decimal.Parse(label2.Text);
            int db = Convert.ToInt32(numericUpDown1.Value);

            Auto.Add(new Rendeles
            {
                marka = marka,
                ar = ar,
                db = db
            });
            MessageBox.Show("Sikeresen a kosárhoz adtad az autót!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;database=autokereskedes;user=root;password=;";

                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    foreach(var item in Auto)
                    {
                        string query = "INSERT INTO vasarlas (vas_felnev, marka, ar, db) VALUES (@vas_felnev, @marka, @ar, @db)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@vas_felnev", Session.belepfelnev);
                            cmd.Parameters.AddWithValue("@marka", item.marka);
                            cmd.Parameters.AddWithValue("@ar", item.ar);
                            cmd.Parameters.AddWithValue("@db", item.db);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sikeres volt a vásárlás!");
                        }
                    }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string marka = label3.Text;
            decimal ar = decimal.Parse(label4.Text);
            int db = Convert.ToInt32(numericUpDown2.Value);

            Auto.Add(new Rendeles
            {
                marka = marka,
                ar = ar,
                db = db
            });
            MessageBox.Show("Sikeresen a kosárhoz adtad az autót!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string marka = label5.Text;
            decimal ar = decimal.Parse(label6.Text);
            int db = Convert.ToInt32(numericUpDown3.Value);

            Auto.Add(new Rendeles
            {
                marka = marka,
                ar = ar,
                db = db
            });
            MessageBox.Show("Sikeresen a kosárhoz adtad az autót!");
        }
    }
}
