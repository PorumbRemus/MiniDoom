﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(); // pentru fereastra Form2
            f.Show();
        }
    }
}
