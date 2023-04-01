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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = Image.FromFile("doomguy.gif");
            pictureBox2.Image = Image.FromFile("demon1.jpg");
            pictureBox3.Image = Image.FromFile("sfera.gif");
            pictureBox4.Image = Image.FromFile("banut.gif");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6(); // pentru fereastra Form2
            f.Show();
        }
    }
}
