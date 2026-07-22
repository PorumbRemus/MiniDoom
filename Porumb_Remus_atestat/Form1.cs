using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porumb_Remus_atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f = new Form7(); // pentru fereastra Form2
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4(); // pentru fereastra Form2
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2(); // pentru fereastra Form2
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (a.mus == 1)
            {
                a.mus = 0;
                pictureBox1.Image = Image.FromFile("x.png");
            }
            else
            {
                a.mus = 1;
                pictureBox1.Image = Image.FromFile("bifa.png");
            }
        }
    }
}
