namespace veri_taban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelSoy_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lableAd_Click(object sender, EventArgs e)
        {

        }

        private void buttonKay�d_Click(object sender, EventArgs e)
        {
            string hataMesaj = "";

            if (textBox1.Text == "")
            {
                hataMesaj = "Ad ,";
            }
            else if (textBox2.Text == "")
            {
                hataMesaj += "SoyAd ,";
            }
            else if (textBox3.Text == "")
            {
                hataMesaj += "Dogum ,";
            }
            if (hataMesaj!="")
            {
                hataMesaj = hataMesaj.Trim().Substring(0, hataMesaj.Length - 1);
                MessageBox.Show(hataMesaj + " alanlar� bo� b�rak�lmaz :");

            }
            else
            {
                MessageBox.Show(" Kay�t tamamland� :");
            }

        }
    }
}