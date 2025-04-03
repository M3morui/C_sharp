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

namespace lolinfo
{
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Belepes belepes = new Belepes();
            belepes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nev, felnev, email, jelszo, jelszoo;
            nev = textBox1.Text;
            felnev = textBox2.Text;
            email = textBox3.Text;
            jelszo = textBox4.Text;
            jelszoo = textBox5.Text;

            if(jelszo != jelszoo)
            {
                MessageBox.Show("A jelszó nem egyezik!");
                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                try
                {
                    string connection = "server=localhost;database=lolinfo;user=root;password=;";
                    using (MySqlConnection conn = new MySqlConnection(connection))
                    {
                        conn.Open();
                        string query = "INSERT INTO felhasznalok (nev, felnev, email, jelszo) VALUES (@nev, @felnev, @email, @jelszo)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nev", nev);
                            cmd.Parameters.AddWithValue("@felnev", felnev);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@jelszo", jelszo);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sikeres regisztráció!");


                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Valami nem jó!" + ex.Message);
                }
            }
            
        }
    }
}
