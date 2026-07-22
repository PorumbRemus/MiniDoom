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
    public partial class Form2 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int m = 1, nr1 = 0, s = 4, t = 0, posX = 0, posY = 0, nr = 3, posX1 = 0, posY1 = 13, posX2 = 15, posY2 = 13, posX3 = 12, posY3 = 0, nr2 = 1,nr3=1;// w de la win 

        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;   // pe picturebox1 am pus personajul
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Image = Image.FromFile("spate.png");
                if (interior(posX, posY - 1) && harta[posY - 1, posX] == 0)
                {
                    posY--;
                    pictureBox1.Location = new Point(x, y - dy);
                }
                //pictureBox2.Image = Image.FromFile("demon2.jpg");
            }

            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Image = Image.FromFile("fata3.png");
                if (interior(posX, posY + 1) && harta[posY + 1, posX] == 0)
                {
                    pictureBox1.Location = new Point(x, y + dy);
                    posY++;
                }
                //pictureBox2.Image = Image.FromFile("demon1.jpg");

            }

            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Image = Image.FromFile("doomguy.gif");
                if (interior(posX + 1, posY) && harta[posY, posX + 1] == 0)
                {
                    pictureBox1.Location = new Point(x + dx, y);
                    posX++;
                }
                //pictureBox2.Image = Image.FromFile("demon4.jpg");
            }

            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Image = Image.FromFile("doomguy2.gif");
                if (interior(posX - 1, posY) && harta[posY, posX - 1] == 0)
                {
                    pictureBox1.Location = new Point(x - dx, y);
                    posX--;
                }
                //pictureBox2.Image = Image.FromFile("demon3.png");
            }
            if (posX == 15 && posY == 1)
            {
                pictureBox1.Image = Image.FromFile("win.gif");
            }
            if (posX == 15 && posY == 0)
            {
                this.Hide();
                Form9 f = new Form9(); // pentru fereastra Form2
                f.Show();
                player.controls.pause();
            }
            if (((posX == posX1 && posY == posY1) || (posX == posX2 && posY == posY2) || (posX == posX3 && posY == posY3)) && pictureBox10.Visible == true)
            {
                if (nr > 1)
                    nr--;
                else
                {
                    if (m == 1)
                    {
                        m = 0;
                        pictureBox14.Image = Image.FromFile("inima1.png");
                        pictureBox1.Image = Image.FromFile("death.gif");
                        pictureBox2.Visible = false;
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
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
                    pictureBox13.Image = Image.FromFile("inima1.png");


            }
            if (((posX == posX1 && posY == posY1) && pictureBox10.Visible == false))
            {
                pictureBox2.Dispose();
                pictureBox2.Enabled = false;
                if (p != 0)
                {
                    nr1 = nr1 + 500;
                    c[nr3].Image = Image.FromFile("demon1.jpg");
                    nr3++;
                }
                p = 0;
            }
            if (((posX == posX2 && posY == posY2) && pictureBox10.Visible == false))
            {
                pictureBox11.Dispose();
                pictureBox11.Enabled = false;
                if (p1 != 0)
                {
                    nr1 = nr1 + 500;
                    c[nr3].Image = Image.FromFile("demon1.jpg");
                    nr3++;
                }
                p1 = 0;

            }
            if (((posX == posX3 && posY == posY3) && pictureBox10.Visible == false))
            {
                pictureBox12.Dispose();
                pictureBox12.Enabled = false;
                if (p2 != 0)
                {
                    nr1 = nr1 + 500;
                    c[nr3].Image = Image.FromFile("demon1.jpg");
                    nr3++;
                }
                p2 = 0;
            }
            label3.Text = nr1.ToString();

            if (posX == 0 && posY == 2 && pictureBox3.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 7 && posY == 3 && pictureBox7.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox7.Visible = false;
                pictureBox7.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 11 && posY == 7 && pictureBox8.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox8.Visible = false;
                pictureBox8.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 2 && posY == 5 && pictureBox15.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox15.Visible = false;
                pictureBox15.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 5 && posY == 11 && pictureBox16.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox16.Visible = false;
                pictureBox16.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 9 && posY == 9 && pictureBox17.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox17.Visible = false;
                pictureBox17.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 13 && posY == 9 && pictureBox18.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox18.Visible = false;
                pictureBox18.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 11 && posY == 5 && pictureBox19.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox19.Visible = false;
                pictureBox19.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 11 && posY == 3 && pictureBox20.Enabled == true)
            {
                nr1 = nr1 + 100;
                pictureBox20.Visible = false;
                pictureBox20.Enabled = false;
                b[nr2].Image = Image.FromFile("banut.gif");
                nr2++;
            }
            if (posX == 3 && posY == 9)
            {
                pictureBox10.Visible = false;
                pictureBox10.Enabled = false;
                //b[nr2].Image = Image.FromFile("banut.gif");
                //nr2++;
            }
        }

        int p = 1, p1 = 1, p2 = 1;
        PictureBox[] b = new PictureBox[13];
        PictureBox[] c = new PictureBox[4];
        private void timer2_Tick(object sender, EventArgs e)
        {
            s--;
            if (nr == 0)
                pictureBox1.Image = Image.FromFile("death.gif");
            if (s == 0)
            {
                timer2.Stop();
            }
        }

        int ok = 1, ok1 = 1, ok2 = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = t.ToString();
            t++;
            int x1 = pictureBox2.Location.X;   // pe picturebox2 am pus personajul
            int y1 = pictureBox2.Location.Y;
            int x2 = pictureBox11.Location.X;   // pe picturebox6 am pus personajul
            int y2 = pictureBox11.Location.Y;
            int x3 = pictureBox12.Location.X;  // pe picturebox12 am pus personajul
            int y3 = pictureBox12.Location.Y;
            //monstru 1
            if (ok == 1)
                if (interior(posX1, posY1 - 1) && (harta[posY1 - 1, posX1] == 0) && pictureBox2.Enabled == true)
                {

                    posY1--;
                    if (posX == posX1 && posY == posY1 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");

                    }
                    if (((posX == posX1 && posY == posY1) && pictureBox10.Visible == false && pictureBox2.Enabled == true))
                    {
                        pictureBox2.Dispose();
                        pictureBox2.Enabled = false;
                        if (p1 != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p1 = 0;
                        
                    }
                    if (interior(posX1, posY1 - 1) == false || (harta[posY1 - 1, posX1] == 1))
                        ok = ok * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok == 1)
                        pictureBox2.Location = new Point(x1, y1 - dy);
                    pictureBox2.Image = Image.FromFile("demon2.jpg");
                }
            if (ok == -1)
                if (interior(posX1, posY1) && (harta[posY1, posX1] == 0) && pictureBox2.Enabled == true)
                {

                    posY1++;
                    if (posX == posX1 && posY == posY1 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");

                    }
                    if (((posX == posX1 && posY == posY1) && pictureBox10.Visible == false && pictureBox2.Enabled == true))
                    {
                        pictureBox2.Dispose();
                        pictureBox2.Enabled = false;
                        if (p != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p = 0;
                        
                    }
                    if (interior(posX1, posY1 + 1) == false || (harta[posY1 + 1, posX1] == 1))
                        ok = ok * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok == -1)
                        pictureBox2.Location = new Point(x1, y1 + dy);
                    if (pictureBox10.Visible == true)
                        pictureBox2.Image = Image.FromFile("demon1.jpg");
                    else
                        pictureBox2.Image = Image.FromFile("pog3.jpg");
                }
            //monstru 2
            if (ok1 == 1)
                if (interior(posX2 - 1, posY2) && (harta[posY2, posX2 - 1] == 0) && pictureBox11.Enabled == true)
                {

                    posX2--;
                    if (posX == posX2 && posY == posY2 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");

                    }
                    if (((posX == posX2 && posY == posY2) && pictureBox10.Visible == false && pictureBox11.Enabled == true))
                    {
                        pictureBox11.Dispose();
                        pictureBox11.Enabled = false;
                        if (p1 != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p1 = 0;
                    }
                    if (interior(posX2 - 1, posY2) == false || (harta[posY2, posX2 - 1] == 1))
                        ok1 = ok1 * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok1 == 1)
                        pictureBox11.Location = new Point(x2 - dx, y2);
                    if (pictureBox10.Visible == true)
                        pictureBox11.Image = Image.FromFile("demon3.png");
                    else
                        pictureBox11.Image = Image.FromFile("pog2.1.jpg");
                }
            if (ok1 == -1)
                if (interior(posX2, posY2) && (harta[posY2, posX2] == 0) && pictureBox11.Enabled == true)
                {

                    posX2++;
                    if (posX == posX2 && posY == posY2 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");

                    }
                    if (((posX == posX2 && posY == posY2) && pictureBox10.Visible == false && pictureBox11.Enabled == true))
                    {
                        pictureBox11.Dispose();
                        pictureBox11.Enabled = false;
                        if (p1 != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p1 = 0;
                    }
                    if (interior(posX2 + 1, posY1) == false || (harta[posY2, posX2 + 1] == 1))
                        ok1 = ok1 * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok1 == -1)
                        pictureBox11.Location = new Point(x2 + dx, y2);
                    if (pictureBox10.Visible == true)
                        pictureBox11.Image = Image.FromFile("demon4.jpg");
                    else
                        pictureBox11.Image = Image.FromFile("pog1.1.jpg");
                }
            //monstru 3
            if (ok2 == 1)
                if (interior(posX3 - 1, posY3) && (harta[posY3, posX3 - 1] == 0) && pictureBox12.Enabled == true)
                {

                    posX3--;
                    if (posX == posX3 && posY == posY3 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");


                    }
                    if (((posX == posX3 && posY == posY3) && pictureBox10.Visible == false && pictureBox12.Enabled == true))
                    {
                        pictureBox12.Dispose();
                        pictureBox12.Enabled = false;
                        if (p2 != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p2 = 0;
                        
                    }
                    if (interior(posX3 - 1, posY3) == false || (harta[posY3, posX3 - 1] == 1))
                        ok2 = ok2 * (-1);
                    //  label1.Text = posX1.ToString() +  ok.ToString()+ posY1.ToString();
                    if (ok2 == 1)
                        pictureBox12.Location = new Point(x3 - dx, y3);
                    if (pictureBox10.Visible == true)
                        pictureBox12.Image = Image.FromFile("demon3.png");
                    else
                        pictureBox12.Image = Image.FromFile("pog2.1.jpg");
                }
            if (ok2 == -1)
                if (interior(posX3, posY3) && (harta[posY3, posX3] == 0) && pictureBox12.Enabled == true)
                {

                    posX3++;
                    if (posX == posX3 && posY == posY3 && pictureBox10.Visible == true)
                    {
                        if (nr > 1)
                            nr--;
                        else
                        {
                            if (m == 1)
                            {
                                m = 0;
                                pictureBox14.Image = Image.FromFile("inima1.png");
                                pictureBox1.Image = Image.FromFile("death.gif");
                                pictureBox2.Visible = false;
                                pictureBox11.Visible = false;
                                pictureBox12.Visible = false;
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
                            pictureBox13.Image = Image.FromFile("inima1.png");
                    }
                    if (((posX == posX3 && posY == posY3) && pictureBox10.Visible == false && pictureBox12.Enabled == true))
                    {
                        pictureBox12.Dispose();
                        pictureBox12.Enabled = false;
                        if (p2 != 0)
                        {
                            nr1 = nr1 + 500;
                            c[nr3].Image = Image.FromFile("demon1.jpg");
                            nr3++;
                        }
                        p2 = 0;
                    }
                    if (interior(posX3, posY3) == false || (harta[posY3, posX3] == 1))
                        ok2 = ok2 * (-1);
                    // label1.Text = posX1.ToString() + ok.ToString() + posY1.ToString();
                    if (ok2 == -1)
                        pictureBox12.Location = new Point(x3 + dx, y3);
                    if (pictureBox10.Visible == true)
                        pictureBox12.Image = Image.FromFile("demon4.jpg");
                    else
                        pictureBox12.Image = Image.FromFile("pog1.1.jpg");
                }
        }

        int dx = 47, dy = 47;


        public int[,] harta = new int[15, 16]
        {

          {0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0},
          {1,1,1,1,0,0,1,0,0,0,1,0,1,0,1,0},
          {0,0,0,1,0,0,1,1,1,0,1,1,1,0,1,0},
          {0,1,0,1,0,0,1,0,1,0,0,0,1,0,1,0},
          {0,1,1,1,0,0,1,0,1,0,1,1,1,0,1,0},
          {0,0,0,0,0,0,1,0,1,0,1,0,0,0,1,0},
          {0,1,1,1,0,0,1,0,1,0,1,1,1,0,1,0},
          {0,1,0,0,0,0,1,0,1,0,0,0,1,0,1,0},
          {0,1,0,1,1,0,1,0,1,1,1,1,1,0,1,0},
          {0,1,0,0,1,0,1,0,1,0,1,0,0,0,1,0},
          {0,1,1,1,1,0,1,0,1,0,1,0,1,1,1,0},
          {0,0,0,0,0,0,1,0,1,0,0,0,1,1,1,0},
          {0,1,0,1,1,1,1,0,1,0,0,0,1,1,0,0},
          {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        };

        private void Form2_Load(object sender, EventArgs e)
        {
            if (a.mus == 1)
                player.controls.play();
        }

        private void label1_Click(object sender, EventArgs e)
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

        public Form2()
        {
            InitializeComponent();
            if (a.mus == 1)
                player.URL = "doom.mp3";
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox3.Image = Image.FromFile("banut.gif");
            pictureBox7.Image = Image.FromFile("banut.gif");
            pictureBox8.Image = Image.FromFile("banut.gif");
            pictureBox15.Image = Image.FromFile("banut.gif");
            pictureBox16.Image = Image.FromFile("banut.gif");
            pictureBox17.Image = Image.FromFile("banut.gif");
            pictureBox18.Image = Image.FromFile("banut.gif");
            pictureBox19.Image = Image.FromFile("banut.gif");
            pictureBox20.Image = Image.FromFile("banut.gif");
            pictureBox10.Image = Image.FromFile("sfera.gif");
            for (int i = 1; i <= 10; i++)
            {
                b[1] = pictureBox21;
                b[2] = pictureBox22;
                b[3] = pictureBox23;
                b[4] = pictureBox24;
                b[5] = pictureBox25;
                b[6] = pictureBox26;
                b[7] = pictureBox27;
                b[8] = pictureBox28;
                b[9] = pictureBox29;
               // b[10] = pictureBox30;
            }
            for(int i=1;i<=3;i++)
            {
                c[1] = pictureBox32;
                c[2] = pictureBox33;
                c[3] = pictureBox34;
            }
            if (nr == 0)
                timer2.Start();
            DoubleBuffered = true;
        }
        private bool interior(int x, int y)
        {
            if (y < 0 || y > 14 || x < 0 || x > 15)
                return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1(); // pentru fereastra Form2
            f.Show();
        }
    }
}