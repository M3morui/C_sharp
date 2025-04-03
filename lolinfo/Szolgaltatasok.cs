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
    public partial class Szolgaltatasok : Form
    {
        public Szolgaltatasok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szol;
            szol = label14.Text;

            try
            {
                string connection = "server=localhost;database=lolinfo;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO szolgaltatas (szol_felnev, szol) VALUES (@szol_felnev, @szol)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("szol_felnev", Session.belepfelnev);
                        cmd.Parameters.AddWithValue("@szol", szol);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sikeres csatlakozás!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string szol;
            szol = label12.Text;

            try
            {
                string connection = "server=localhost;database=lolinfo;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO szolgaltatas (szol_felnev, szol) VALUES (@szol_felnev, @szol)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("szol_felnev", Session.belepfelnev);
                        cmd.Parameters.AddWithValue("@szol", szol);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sikeres csatlakozás!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string szol;
            szol = label13.Text;

            try
            {
                string connection = "server=localhost;database=lolinfo;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO szolgaltatas (szol_felnev, szol) VALUES (@szol_felnev, @szol)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("szol_felnev", Session.belepfelnev);
                        cmd.Parameters.AddWithValue("@szol", szol);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sikeres csatlakozás!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }
    }
}
