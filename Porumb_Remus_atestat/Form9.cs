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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            a.nice = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(); // pentru fereastra Form2
            f.Show();
        }
    }
}
