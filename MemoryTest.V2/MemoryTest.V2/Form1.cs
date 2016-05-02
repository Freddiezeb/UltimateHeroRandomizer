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

        int remaining = 8;

        private void DefaultPicture()
        {
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
            int[] pictureArray = new int[16];
            Random random1 = new Random();

            int i = 0;
            while (i < 16)
            {
                int rast = random1.Next(1, 17);
                if (Array.IndexOf(pictureArray, random1) == -1)
                {
                    pictureArray[i] = rast;
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
        private void TextureMatch(PictureBox lastTexture, PictureBox nextTexture)
        {
            if (lastTexture == nextTexture)
            {
                lastTexture.Visible = false;
                nextTexture.Visible = false;
                remaining--;
                texture.Dispose();
            }
            else
            {
                lastTexture.Image = Image.FromFile("0.png");
                nextTexture.Image = Image.FromFile("0.png");
                texture.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultPicture();
            CheckPicture();
            TagPicture();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox currentTexture = (sender as PictureBox);

            (sender as PictureBox).Image = Image.FromFile((sender as PictureBox).Tag.ToString() + ".png");

            if (count == 0)
            {
                texture = currentTexture;
                count++;
            }
            else
            {
                if (texture == currentTexture)
                {
                    MessageBox.Show("Good Job!");
                    count = 0;
                    texture.Image = Image.FromFile("0.png"); 
                }
                else
                {
                    TextureMatch(texture, currentTexture);
                    count = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
