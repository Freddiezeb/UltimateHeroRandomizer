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
    public partial class Memory : Form
    {
        PictureBox texture;

        Submenu subMenu;
        ChooseGame gameSelected;

        int count = 0;
        int score = 0;
        int remaining = 8;

        public Memory()
        {
            // Lägger till transparent bakgrund till bilderna
            InitializeComponent();

            gameSelected = ChooseGame.League;

            ScoreLabel.Text = "Score: " + score.ToString() + " points";
            label1.Text = "Remaining Pairs: " + remaining.ToString();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
        }

        private void DefaultPicture()
        {
            // Brickorna ska ha loggan som bild från början

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Properties.Resources._0;
                }
            }
        }

        private void CheckPicture()
        {
            // Kollar bilderna om det går att trycka på dem
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Tag = "0";
                }
            }
        }
        private void TagPicture()
        {
            //Slumpar ut bilderna genom en array och random

            int[] textureArray = new int[16];
            Random random = new Random();

            int i = 0;
            while (i < 16)
            {
                int randomCounter = random.Next(1, 17);
                if (Array.IndexOf(textureArray, randomCounter) == -1)
                {
                    textureArray[i] = randomCounter;
                    i++;
                }
            }

            for (int j = 0; j < 16; j++)
            {
<<<<<<< HEAD
                if (textureArray[j] > 8)
=======
                if (textureArray[j] > 16)
>>>>>>> origin/master
                    textureArray[j] -= 8;
            }

            int b = 8;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Tag = textureArray[b].ToString();
                    b++;
                }
            }

        }
        private void textureMatch(PictureBox lastTexture, PictureBox nextTexture)
        {
            // Bestämmer vad som händer om man får dubblett
            // DoEvents() för att förlänga eventerna med Sleep(500)        

            if (lastTexture.Tag.ToString() == nextTexture.Tag.ToString())
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                lastTexture.Visible = false;
                nextTexture.Visible = false;

                remaining--;
                label1.Text = "Remaining Pairs: " + remaining.ToString();

                score = score + 10;
                ScoreLabel.Text = "Score: " + score.ToString() + " points";
            }

            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                lastTexture.Image = Image.FromFile("0.png");
                nextTexture.Image = Image.FromFile("0.png");
            }

            if (remaining <= 0)
            {
                MessageBox.Show("Congratulations!\nRestart or Exit the Game");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "League of Memory";
            //Laddar in alla metoder som ska finnas från start av spel
            DefaultPicture();
            CheckPicture();
            TagPicture();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Vänder brickorna efter klick på texturrutorna
            PictureBox currentTexture = (sender as PictureBox);

            currentTexture.Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");

            if (count == 0)
            {
                texture = currentTexture;
                count++;
            }
            else
            {
                if (texture == currentTexture)
                {
                    MessageBox.Show("You Can't Do That!");
                    count = 0;
                    texture.Image = Image.FromFile("0.png");
                }
                else
                {
                    textureMatch(texture, currentTexture);
                    count = 0;
                }
            }

        }
        private void ShowPictures()
        {
            // Visa vilka bilder som gömmer sig under loggan på alla brickorna
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Image.FromFile(x.Tag.ToString() + ".png");
                }
            }

            score = score - 5;
            ScoreLabel.Text = "Score: " + score.ToString() + " points";
        }
        private void HidePictures()
        {
            //Vänder tillbaka brickorna igen
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Image = Image.FromFile("0.png");
                }
            }
        }
        private void Restart()
        {
            //Startar om spelet och vänder brickorna
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    (x as PictureBox).Visible = true;
                }
            }

            score = 0;
            ScoreLabel.Text = "Score: " + score.ToString() + " points";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Stänger av applikationen
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Laddar in metoderna efter hur händelserna ska ske
            ShowPictures();

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            HidePictures();
            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Startar om spelet genom att ladda om allting igen efter tryck på restartknappen
            DefaultPicture();
            CheckPicture();
            TagPicture();
            Restart();
            count = 0;
            remaining = 8;
            label1.Text = "Remaining Pairs: " + remaining.ToString();
            score = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();

            subMenu = new Submenu(ref gameSelected);
            subMenu.Show();
        }
    }
}

