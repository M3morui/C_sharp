namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int birth_age = Convert.ToInt32(textBox2.Text);
            int tickets = Convert.ToInt32(textBox3.Text);
            int diak_tickets = Convert.ToInt32(textBox4.Text);
            int fullprice = 0;

            if(2025 - birth_age >= 14)
            {
                if(diak_tickets == 0)
                {
                    fullprice = tickets * 2800;
                    
                }
                else
                {
                    fullprice = diak_tickets * 1800 + ((tickets - diak_tickets) * 2800);
                }

                label3.Text = $"A megrendelõ: {name}, születési dátum: {birth_age}, fizetendõ összeg: {fullprice}";
            }
            else
            {
                MessageBox.Show("14 év felett lehet csak jegyet venni!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
