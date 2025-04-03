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
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regisztracio regisz = new Regisztracio();
            regisz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string felnev, jelszo;
            felnev = textBox2.Text;
            jelszo = textBox4.Text;

            try
            {
                string connection = "server=localhost;database=lolinfo;user=root;password=;";
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT * FROM felhasznalok WHERE felnev = @felnev AND  jelszo = @jelszo";
                    using (MySqlDataAdapter dta = new MySqlDataAdapter(query, conn))
                    {
                        dta.SelectCommand.Parameters.AddWithValue("@felnev", felnev);
                        dta.SelectCommand.Parameters.AddWithValue("@jelszo", jelszo);

                        DataTable datatable = new DataTable();
                        dta.Fill(datatable);

                        if(datatable.Rows.Count > 0)
                        {
                            MessageBox.Show("Sikeres volt a belépés!");
                            textBox2.Clear();
                            textBox4.Clear();

                            Jinx jinx = new Jinx();
                            Session.belepfelnev = felnev;
                            jinx.Show();
                            this.Hide();
                        }
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
