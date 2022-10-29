using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kamu yakin logout ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();    
            }
        }

        private void imgLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kamu yakin logout ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tutup program ini ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
