using MySql.Data.MySqlClient;
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
    public partial class Regisztrácio : Form
    {
        public Regisztrácio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nev, felnev, jelszo;
            nev = textBox1.Text;
            felnev = textBox2.Text;
            jelszo = textBox3.Text;

            try
            {
                string connection = "server=localhost;database=autokereskedes;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO vasarlo (nev, felnev, jelszo) VALUES (@nev, @felnev, @jelszo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.Parameters.AddWithValue("@felnev", felnev);
                        cmd.Parameters.AddWithValue("@jelszo", jelszo);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sikeres regisztráció!");

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Belepes belepes = new Belepes();
            belepes.Show();
            this.Hide();
        }
    }
}
