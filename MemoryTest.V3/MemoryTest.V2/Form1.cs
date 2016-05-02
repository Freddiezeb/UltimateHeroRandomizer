using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemoryTest.V2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            // Lägger till transparent bakgrund till bilderna
            InitializeComponent();

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

        PictureBox texture;
            
        int count = 0;

        //int remaining = 8;

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
            //Trycker du på bilden ska arrayen av bilden slumpa bilderna

            int[] pictureArray = new int[16];
            Random random1 = new Random();

            int i = 0;

            while (i < 16)
            {
                int randomCount = random1.Next(1, 16);
                if (Array.IndexOf(pictureArray, random1) == -1)
                {
                    pictureArray[i] = randomCount;
                    i++;
                }

                for (int a = 0; a < 16; a++)
                {
                    if (pictureArray[a] > 8) pictureArray[a] -= 8;
                }
            }

            int b = 0;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Tag = pictureArray[b].ToString();
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
                //remaining--;
            }

            else
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                lastTexture.Image = Image.FromFile("0.png");
                nextTexture.Image = Image.FromFile("0.png");               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "League of Memory";

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Startar om spelet genom att ladda om allting igen efter tryck på restartknappen
            DefaultPicture();
            CheckPicture();
            TagPicture();
            Restart();
            count = 0;
        }
    }
}
