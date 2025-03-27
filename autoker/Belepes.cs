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
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string felnev, jelszo;
            felnev = textBox2.Text;
            jelszo = textBox1.Text;

            try
            {
                string connection = "server=localhost;database=autokereskedes;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "SELECT * FROM vasarlo WHERE felnev = @felnev AND jelszo = @jelszo";
                    using (MySqlDataAdapter dta = new MySqlDataAdapter(query, conn))
                    {
                        dta.SelectCommand.Parameters.AddWithValue("@felnev", felnev);
                        dta.SelectCommand.Parameters.AddWithValue("@jelszo", jelszo);

                        DataTable datatable = new DataTable();
                        dta.Fill(datatable);

                        if(datatable.Rows.Count > 0)
                        {
                            MessageBox.Show("Sikeres volt a belépés!");
                            textBox1.Clear();
                            textBox2.Clear();

                            Autok autok = new Autok();
                            Session.belepfelnev = felnev;
                            autok.Show();
                            this.Hide();
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Hiba" + ex.Message);
            }
        }
    }
}
