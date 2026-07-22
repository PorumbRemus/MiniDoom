using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Porumb_Remus_atestat
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int t = 0, posX = 0, posY = 0, nr = 0, nr1 = 0, nr2 = 1;
        PictureBox[] b = new PictureBox[7];
        
        int dx = 52, dy = 52;

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X; // pe picturebox1 am pus personajul  
            int y = pictureBox1.Location.Y;
           // button1.Text = x.ToString() + " " + y.ToString() + " " + posX.ToString() + " " + posY.ToString();
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Image = Image.FromFile("spate.png");
                if (interior(posX, posY - 1) && harta[posY - 1, posX] == 0)
                {
                    posY--;
                    pictureBox1.Location = new Point(x, y - dy);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Image = Image.FromFile("fata3.png");
                if (interior(posX, posY + 1) && harta[posY + 1, posX] == 0)
                {
                    pictureBox1.Location = new Point(x, y + dy);
                    posY++;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Image = Image.FromFile("doomguy.gif");
                if (interior(posX + 1, posY) && harta[posY, posX + 1] == 0)
                {
                    pictureBox1.Location = new Point(x + dx, y);
                    posX++;
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Image = Image.FromFile("doomguy2.gif");
                if (interior(posX - 1, posY) && harta[posY, posX - 1] == 0)
                {
                    pictureBox1.Location = new Point(x - dx, y);
                    posX--;
                }
            }
            label3.Text = nr1.ToString();
            if (posX == 0 && posY == 5 && pictureBox2.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 2 && posY == 5 && pictureBox3.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 6 && posY == 7 && pictureBox5.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 8 && posY == 2 && pictureBox6.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox6.Visible = false;
                pictureBox6.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 6 && posY == 0 && pictureBox8.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox8.Visible = false;
                pictureBox8.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 11 && posY == 0 && pictureBox7.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox7.Visible = false;
                pictureBox7.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 11 && posY == 3)
            {
                pictureBox1.Image = Image.FromFile("win.gif");
            }
            if (posX == 12 && posY == 3)
            {
                this.Hide();
                Form5 f = new Form5();
                f.Show();
                player.controls.pause();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (a.nice == 0)
            {
                this.Hide();
                Form10 f = new Form10(); // pentru fereastra Form10
                f.Show();
                player.controls.pause();
            }
            else
            {
                this.Hide();
                Form1 f = new Form1(); // pentru fereastra Form2
                f.Show();
                player.controls.pause();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(a.mus==1)
                player.controls.play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = t.ToString();
            t++;
        }

       

        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox2.Image = Image.FromFile("banut.gif");
            pictureBox3.Image = Image.FromFile("banut.gif");
            pictureBox5.Image = Image.FromFile("banut.gif");
            pictureBox6.Image = Image.FromFile("banut.gif");
            pictureBox7.Image = Image.FromFile("banut.gif");
            pictureBox8.Image = Image.FromFile("banut.gif");
            for (int i = 1; i <= 6; i++)
            {
                b[1] = pictureBox10;
                b[2] = pictureBox11;
                b[3] = pictureBox12;
                b[4] = pictureBox13;
                b[5] = pictureBox14;
                b[6] = pictureBox15;
            }
            if (a.mus == 1)
                player.URL = "doom.mp3";
            DoubleBuffered = true;
        }
        public int[,] harta = new int[8, 13]
       {
            {0,0,0,0,0,1,0,0,0,0,0,0,1},
            {1,1,1,0,0,1,0,1,1,1,1,0,1},
            {0,0,0,0,0,0,0,0,0,1,0,0,1},
            {0,1,1,0,1,0,0,0,0,0,0,0,0},
            {0,1,0,0,1,1,0,0,0,1,1,0,1},
            {0,1,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,0,1,1,1,0,1,1,0,1},
            {0,0,0,0,0,0,0,1,0,0,0,0,1},
       };
        private bool interior(int x, int y)
        {
            if (y < 0 || y > 7 || x < 0 || x > 12)
                return false;
            return true;
        }
    }       
}
