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
    public partial class Jinx : Form
    {
        public Jinx()
        {
            InitializeComponent();
            comboBox1.Items.Add("Aatrox");
            comboBox1.Items.Add("Aphelios");
            comboBox1.Items.Add("Jinx");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Szolgaltatasok szolgaltatas = new Szolgaltatasok();
            szolgaltatas.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedForm = comboBox1.SelectedItem.ToString();

            Form newForm = null;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == selectedForm)
                {
                    openForm.Focus();
                    return;
                }
            }

            switch (selectedForm)
            {
                case "Jinx":
                    newForm = new Jinx();
                    break;

                case "Aphelios":
                    newForm = new Aphelios();
                    break;

                case "Aatrox":
                    newForm = new Aatrox();
                    break;
            }

            if (newForm != null)
            {
                newForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Belepes belepes = new Belepes();
            belepes.Show();
            this.Hide();
        }

        public static List<Rendeles> Lol = new List<Rendeles>();

        public class Rendeles
        {
            public string termek;
            public string tipus;
            public int ar;
            public int db;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string termek = label1.Text;
            string tipus = label10.Text;
            int ar = int.Parse(label2.Text);
            int db = Convert.ToInt32(numericUpDown1.Value);

            Lol.Add(new Rendeles
            {
                termek = termek,
                tipus = tipus,
                ar = ar,
                db = db
            });

            MessageBox.Show("Sikeresen a kosárhoz adtad a termékeket.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string termek = label4.Text;
            string tipus = label11.Text;
            int ar = int.Parse(label5.Text);
            int db = Convert.ToInt32(numericUpDown2.Value);

            Lol.Add(new Rendeles
            {
                termek = termek,
                tipus = tipus,
                ar = ar,
                db = db
            });

            MessageBox.Show("Sikeresen a kosárhoz adtad a termékeket.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string termek = label7.Text;
            string tipus = label12.Text;
            int ar = int.Parse(label8.Text);
            int db = Convert.ToInt32(numericUpDown3.Value);

            Lol.Add(new Rendeles
            {
                termek = termek,
                tipus = tipus,
                ar = ar,
                db = db
            });

            MessageBox.Show("Sikeresen a kosárhoz adtad a termékeket.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "server=localhost;database=lolinfo;user=root;password=;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    foreach (var item in Lol)
                    {
                        string query = "INSERT INTO vasarlas (vas_felnev,termek,tipus,ar,db) VALUES (@vas_felnev,@termek,@tipus,@ar,@db)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@vas_felnev", Session.belepfelnev);
                            cmd.Parameters.AddWithValue("@termek", item.termek);
                            cmd.Parameters.AddWithValue("@tipus", item.tipus);
                            cmd.Parameters.AddWithValue("@ar", item.ar);
                            cmd.Parameters.AddWithValue("@db", item.db);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sikeres volt a vásárlás.");



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
