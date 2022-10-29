namespace Dashboard
{
    public partial class Form1 : Form
    {
        readonly string Username = "amriiqro@gmail.com";
        readonly string Password = "12345";

        public static Form1? instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == Username && txtPasswprd.Text == Password)
            {
                MessageBox.Show("Kamu berhasil login");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (txtEmail.Text == "" || txtPasswprd.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {
            String Naam;

            Naam = lblKeluar.Text;

            string message = "Apa kamu yakin keluar dari MicroLearn";
            string title = "Keluar dari MicroLearn";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }
    }
}