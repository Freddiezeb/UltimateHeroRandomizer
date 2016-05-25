using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    public partial class SlidePuzzle : Form
    {
        Submenu subMenu;
        UploadHighscore uploadHighscore;
        ChooseGame gameSelected;

        public static int ticks;
        int timerTicks = 6;
        bool isPressed, isShowing, isCounting, isSPplaying;
        bool pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9;

        public SlidePuzzle()
        {
            InitializeComponent();

            timer1.Start();
            windowTimer.Start();
            //CheckWin();
            if (Submenu.League)
            {
                this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.lolmeny3;
            }
        }

        void CheckWin()
        {
            
            if (pictureBox1.Image == Properties.Resources.SPmorph9)
            {
                pic1 = true;
            }
            if (pictureBox2.Image == Properties.Resources.SPwhite)
            {
                pic2 = true;
            }
            if (pictureBox3.Image == Properties.Resources.SPmorph5)
            {
                pic3 = true;
            }
            if (pictureBox4.Image == Properties.Resources.SPmorph8)
            {
                pic4 = true;
            }
            if (pictureBox5.Image == Properties.Resources.SPmorph4)
            {
                pic5 = true;
            }
            if (pictureBox6.Image == Properties.Resources.SPmorph1)
            {
                pic6 = true;
            }
            if (pictureBox7.Image == Properties.Resources.SPmorph2)
            {
                pic7 = true;
            }
            if (pictureBox8.Image == Properties.Resources.SPmorph7)
            {
                pic8 = true;
            }
            if (pictureBox9.Image == Properties.Resources.SPmorph6)
            {
                pic9 = true;
            }
            if (pic1 && pic2 && pic3 && pic4 && pic5 && pic6 && pic7 && pic8 && pic9 == true)
            {
                isPressed = false;
                isShowing = true;
                timer1.Stop();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Aqua;
            pictureBox2.BackColor = Color.Aqua;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.Aqua;
            pictureBox5.BackColor = Color.Aqua;
            pictureBox6.BackColor = Color.Aqua;
            pictureBox7.BackColor = Color.Aqua;
            pictureBox8.BackColor = Color.Aqua;
            pictureBox9.BackColor = Color.Aqua;



            if (Submenu.Dota)
            {
                pictureBox1.Image = Properties.Resources.SPmorph9;
                pictureBox2.Image = Properties.Resources.SPmorph5;
                pictureBox3.Image = Properties.Resources.SPwhite;
                pictureBox4.Image = Properties.Resources.SPmorph8;
                pictureBox5.Image = Properties.Resources.SPmorph4;
                pictureBox6.Image = Properties.Resources.SPmorph1;
                pictureBox7.Image = Properties.Resources.SPmorph2;
                pictureBox8.Image = Properties.Resources.SPmorph7;
                pictureBox9.Image = Properties.Resources.SPmorph6;
                pictureBox10.Image = Properties.Resources._110_morphling;
            }

            if (Submenu.League)
            {
                pictureBox1.Image = Properties.Resources.lucian8;
                pictureBox2.Image = Properties.Resources.lucian4;
                pictureBox3.Image = Properties.Resources.SPwhite;
                pictureBox4.Image = Properties.Resources.lucian7;
                pictureBox5.Image = Properties.Resources.lucian3;
                pictureBox6.Image = Properties.Resources.lucian1;
                pictureBox7.Image = Properties.Resources.lucian2;
                pictureBox8.Image = Properties.Resources.lucian5;
                pictureBox9.Image = Properties.Resources.lucian6;
                pictureBox10.Image = Properties.Resources.lucian;
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox1.Image = Properties.Resources.SPwhite;
                pictureBox1.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox1.Image = Properties.Resources.SPwhite;
                pictureBox1.BackColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.SPwhite;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.SPwhite;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox2.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.SPwhite;
                pictureBox2.BackColor = Color.White;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox3.Image = Properties.Resources.SPwhite;
                pictureBox3.BackColor = Color.White;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox3.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox3.Image = Properties.Resources.SPwhite;
                pictureBox3.BackColor = Color.White;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox4.Image;
                pictureBox1.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.SPwhite;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox4.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.SPwhite;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox4.Image;
                pictureBox7.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.SPwhite;
                pictureBox4.BackColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox5.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.SPwhite;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox5.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.SPwhite;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.SPwhite;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox5.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.SPwhite;
                pictureBox5.BackColor = Color.White;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox6.Image;
                pictureBox3.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.SPwhite;
                pictureBox6.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.SPwhite;
                pictureBox6.BackColor = Color.White;
            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox6.Image;
                pictureBox9.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.SPwhite;
                pictureBox6.BackColor = Color.White;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox7.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox7.Image = Properties.Resources.SPwhite;
                pictureBox7.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox7.Image = Properties.Resources.SPwhite;
                pictureBox7.BackColor = Color.White;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox8.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.SPwhite;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.SPwhite;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox8.Image;
                pictureBox9.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.SPwhite;
                pictureBox8.BackColor = Color.White;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox9.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox9.Image = Properties.Resources.SPwhite;
                pictureBox9.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox9.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox9.Image = Properties.Resources.SPwhite;
                pictureBox9.BackColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPressed == true)
                ticks++;

            label1.Text = "Timer: " + ticks.ToString();

            if (isShowing == true)
                this.Size = new Size(1200, 600);

            if (isShowing == false)
                this.Size = new Size(630, 600);
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            isPressed = true;

            pictureBox2.Enabled = true;
            pictureBox6.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isShowing = true;
            isCounting = true;
        }

        private void SlidePuzzle_Click(object sender, EventArgs e)
        {

        }

        private void SlidePuzzle_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void windowTimer_Tick(object sender, EventArgs e)
        {
            if (isCounting == true)
            {
                timerTicks--;
            }
            if (timerTicks == 0)
            {
                isShowing = false;
                isCounting = false;
                timerTicks = 6;
            }

            label2.Text = "Time Left: " + timerTicks.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();

            if (Submenu.Dota)
            {
                gameSelected = ChooseGame.Dota;
            }
            if (Submenu.League)
            {
                gameSelected = ChooseGame.League;
            }

            subMenu = new Submenu(ref gameSelected);
            subMenu.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.SPmorph9;
            //pictureBox2.Image = Properties.Resources.SPmorph5;
            //pictureBox3.Image = Properties.Resources.SPwhite;
            //pictureBox4.Image = Properties.Resources.SPmorph8;
            //pictureBox5.Image = Properties.Resources.SPmorph4;
            //pictureBox6.Image = Properties.Resources.SPmorph1;
            //pictureBox7.Image = Properties.Resources.SPmorph2;
            //pictureBox8.Image = Properties.Resources.SPmorph7;
            //pictureBox9.Image = Properties.Resources.SPmorph6;


            if (pictureBox1.Image == Properties.Resources.SPmorph9)
            {
                pic1 = true;
            }
            if (pictureBox2.Image == Properties.Resources.SPwhite)
            {
                pic2 = true;
            }
            if (pictureBox3.Image == Properties.Resources.SPmorph5)
            {
                pic3 = true;
            }
            if (pictureBox4.Image == Properties.Resources.SPmorph8)
            {
                pic4 = true;
            }
            if (pictureBox5.Image == Properties.Resources.SPmorph4)
            {
                pic5 = true;
            }
            if (pictureBox6.Image == Properties.Resources.SPmorph1)
            {
                pic6 = true;
            }
            if (pictureBox7.Image == Properties.Resources.SPmorph2)
            {
                pic7 = true;
            }
            if (pictureBox8.Image == Properties.Resources.SPmorph7)
            {
                pic8 = true;
            }
            if (pictureBox9.Image == Properties.Resources.SPmorph6)
            {
                pic9 = true;
            }
            //if (pic1 && pic2 && pic3 && pic4 && pic5 && pic6 && pic7 && pic8 && pic9 == true)
            //{
            //    isPressed = false;
            //    isShowing = true;
            //    Application.Exit();
            //}
            if (ticks >= 60)
            {
                isPressed = false;
                uploadHighscore = new UploadHighscore();
                uploadHighscore.Show();
            }
        }
    }
}
