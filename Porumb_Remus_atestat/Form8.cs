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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("doctor3.gif");
            pictureBox2.Image = Image.FromFile("win.gif");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
