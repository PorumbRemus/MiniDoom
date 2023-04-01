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
    public partial class Form4 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int m = 1, t = 0, posX = 0, posY = 0, nr = 3, nr1 = 0, posX1 = 3, posY1 = 0, posX2 = 1, posY2 = 7, posX3 = 6, posY3 = 7,nr2=1;
        int dx = 56
            , dy = 56;
        int ok = 1, ok1 = 1, ok2 = 1;
        PictureBox[] b = new PictureBox[9];

        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (a.mus == 1)
                player.URL = "doom.mp3";
            pictureBox10.Image = Image.FromFile("banut.gif");
            pictureBox11.Image = Image.FromFile("banut.gif");
            pictureBox12.Image = Image.FromFile("banut.gif");
            pictureBox13.Image = Image.FromFile("banut.gif");
            pictureBox14.Image = Image.FromFile("banut.gif");
            pictureBox15.Image = Image.FromFile("banut.gif");
            pictureBox16.Image = Image.FromFile("banut.gif");
            pictureBox17.Image = Image.FromFile("banut.gif");
            for (int i = 1; i <= 8; i++)
            {
                b[1] = pictureBox18;
                b[2] = pictureBox19;
                b[3] = pictureBox20;
                b[4] = pictureBox21;
                b[5] = pictureBox22;
                b[6] = pictureBox23;
                b[7] = pictureBox24;
                b[8] = pictureBox25;
            }
            DoubleBuffered = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (a.mus == 1)
                player.controls.play();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (a.nice == 0)
            {
                this.Hide();
                Form10 f = new Form10(); // pentru fereastra Form2
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

        public int[,] harta = new int[9, 13]
        {
            
            {0,1,0,0,0,0,0,0,1,0,0,0,1},
            {0,0,0,1,0,1,1,1,1,1,0,0,1},
            {0,1,0,1,0,0,0,0,1,0,0,1,1},
            {0,1,0,1,0,0,0,0,1,0,0,0,0},
            {0,1,0,1,1,1,1,0,0,0,0,0,1},
            {0,0,0,0,1,0,0,0,1,1,1,0,1},
            {0,1,1,0,1,0,1,1,1,0,0,0,1},
            {0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1},
        };
        private bool interior(int x, int y)
        {
            if (y < 0 || y > 8 || x < 0 || x > 12)
                return false;
            return true;
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
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
            if (posX == 11 && posY == 3)
                pictureBox1.Image = Image.FromFile("win.gif");
            if (posX == 12 && posY == 3)
            {
                this.Hide();
                Form8 f = new Form8();
                f.Show();
                player.controls.pause();
            }
            if (((posX == posX1 && posY == posY1)) || (posX == posX2 && posY == posY2) || (posX == posX3 && posY == posY3))
            {
                if (nr > 1)
                    nr--;
                else
                {
                    if (m == 1)
                    {
                        m = 0;
                        pictureBox8.Image = Image.FromFile("inima1.png");
                        pictureBox1.Image = Image.FromFile("death.gif");
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox5.Visible = false;
                        MessageBox.Show("Ați pierdut!");
                        if (a.nice == 0)
                        {
                            this.Hide();
                            Form10 f = new Form10(); // pentru fereastra Form2
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
                        player.controls.pause();
                    }
                }
                if (nr == 2)
                    pictureBox6.Image = Image.FromFile("inima1.png");
                if (nr == 1)
                    pictureBox7.Image = Image.FromFile("inima1.png");
            }
            label1.Text = nr1.ToString();
            if (posX == 0 && posY == 2 && pictureBox17.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox17.Visible = false;
                pictureBox17.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 0 && posY == 5 && pictureBox12.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox12.Visible = false;
                pictureBox12.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 3 && posY == 5 && pictureBox11.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox11.Visible = false;
                pictureBox11.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 2 && posY == 3 && pictureBox16.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox16.Visible = false;
                pictureBox16.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 7 && posY == 2 && pictureBox10.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox10.Visible = false;
                pictureBox10.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 7 && posY == 5 && pictureBox13.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox13.Visible = false;
                pictureBox13.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 9 && posY == 6 && pictureBox15.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox15.Visible = false;
                pictureBox15.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 9 && posY == 0 && pictureBox14.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox14.Visible = false;
                pictureBox14.Enabled = false;
                a.nrb++;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = t.ToString();
            t++;
            int x1 = pictureBox5.Location.X;   // pe picturebox5 am pus personajul
            int y1 = pictureBox5.Location.Y;
            int x2 = pictureBox3.Location.X;   // pe picturebox3 am pus personajul
            int y2 = pictureBox3.Location.Y;
            int x3 = pictureBox2.Location.X;  // pe picturebox2 am pus personajul
            int y3 = pictureBox2.Location.Y;
            //monstru 1
            if (ok == 1)
                if (interior(posX1 - 1, posY1) && (harta[posY1, posX1 - 1] == 0))
                {

                    posX1--;
                    if (posX == posX1 && posY == posY1)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                MessageBox.Show("Ați pierdut!");
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");


                    }
                    if (interior(posX1 - 1, posY1) == false || (harta[posY1, posX1 - 1] == 1))
                        ok = ok * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok == 1)
                    {
                        pictureBox5.Location = new Point(x1 - dx, y1);
                        pictureBox5.Image = Image.FromFile("demon3.png");
                    }
                }
            if (ok == -1)
                if (interior(posX1, posY1) && (harta[posY1, posX1] == 0))
                {

                    posX1++;
                    if (posX == posX1 && posY == posY1)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                MessageBox.Show("Ați pierdut!");
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");
                    }
                    if (interior(posX1, posY1) == false || (harta[posY1, posX1] == 1))
                        ok = ok * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok == -1)
                    {
                        pictureBox5.Location = new Point(x1 + dx, y1);
                        pictureBox5.Image = Image.FromFile("demon4.jpg");
                    }
                }
            //monstru 2
            if (ok1 == 1)
                if (interior(posX2 - 1, posY2) && (harta[posY2, posX2 - 1] == 0))
                {

                    posX2--;
                    if (posX == posX2 && posY == posY2)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");


                    }
                    if (interior(posX2 - 1, posY2) == false || (harta[posY2, posX2 - 1] == 1))
                        ok1 = ok1 * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok1 == 1)
                    {
                        pictureBox3.Location = new Point(x2 - dx, y2);
                        pictureBox3.Image = Image.FromFile("demon3.png");
                    }
                }
            if (ok1 == -1)
                if (interior(posX2, posY2) && (harta[posY2, posX2] == 0))
                {

                    posX2++;
                    if (posX == posX2 && posY == posY2)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                MessageBox.Show("Ați pierdut!");
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");
                    }
                    if (interior(posX2, posY2) == false || (harta[posY2, posX2] == 1))
                        ok1 = ok1 * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok1 == -1)
                    {
                        pictureBox3.Location = new Point(x2 + dx, y2);
                        pictureBox3.Image = Image.FromFile("demon4.jpg");
                    }
                }
            //monstru 3
            if (ok2 == 1)
                if (interior(posX3 - 1, posY3) && (harta[posY3, posX3 - 1] == 0))
                {

                    posX3--;
                    if (posX == posX3 && posY == posY3)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                MessageBox.Show("Ați pierdut!");
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");


                    }
                    if (interior(posX3 - 1, posY3) == false || (harta[posY3, posX3 - 1] == 1))
                        ok2 = ok2 * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok2 == 1)
                    {
                        pictureBox2.Location = new Point(x3 - dx, y3);
                        pictureBox2.Image = Image.FromFile("demon3.png");
                    }
                }
            if (ok2 == -1)
                if (interior(posX3, posY3) && (harta[posY3, posX3] == 0))
                {

                    posX3++;
                    if (posX == posX3 && posY == posY3)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox8.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox5.Visible = false;
                                MessageBox.Show("Ați pierdut!");
                                if (a.nice == 0)
                                {
                                    this.Hide();
                                    Form10 f = new Form10(); // pentru fereastra Form2
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
                                player.controls.pause();
                            }
                        }
                        if (nr == 2)
                            pictureBox6.Image = Image.FromFile("inima1.png");
                        if (nr == 1)
                            pictureBox7.Image = Image.FromFile("inima1.png");
                    }
                    if (interior(posX3, posY3) == false || (harta[posY3, posX3] == 1))
                        ok2 = ok2 * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok2 == -1)
                    {
                        pictureBox2.Location = new Point(x3 + dx, y3);
                        pictureBox2.Image = Image.FromFile("demon4.jpg");
                    }
                }
        }
    }
}
