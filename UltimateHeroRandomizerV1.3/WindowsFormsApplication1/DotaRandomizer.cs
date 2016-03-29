using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DotaRandomizer : Form
    {
        

        Rectangle[,] rectangles;

        Random rnd = new Random();

        Dota dotaMenu;

        string heroName;

        int xValue = 0, yValue = 0;

        public DotaRandomizer()
        {
            InitializeComponent();
            HeroesImage.Controls.Add(HeroSelected);
            HeroSelected.BackColor = Color.Transparent;
            HeroSelected.Hide();
        }

        public void LoadRectangles()
        {
            rectangles = new Rectangle[12, 10];

            int x = 0;
            int y = 0;


            for (int i = 0; i < rectangles.GetLength(0); i++)
            {

                for (int j = 0; j < rectangles.GetLength(1); j++)
                {
                    rectangles[i, j] = new Rectangle(x, y, 45, 51);
                    if (j == 0)
                    {
                        y = 0;
                    }
                    if (j == 1)
                    {
                        y = 51;
                    }
                    if (j == 2)
                    {
                        y = 102;
                    }
                    if (j == 3)
                    {
                        y = 153;
                    }
                    if (j == 4)
                    {
                        y = 204;
                    }
                    if (j == 5)
                    {
                        y = 255;
                    }
                    if (j == 6)
                    {
                        y = 306;
                    }
                }

                y += 52;
                x += 45;
                if (i == 0)
                {
                    x = 0;
                }
            }

        }

        public void Randomize()
        {

            xValue = rnd.Next(0, 6) * 45;
            yValue = rnd.Next(0, 6) * 51;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomize();

            HeroName();
            this.HeroSelected.Location = new System.Drawing.Point(xValue, yValue);
            HeroSelected.Show();


            this.label1.Text = heroName;
        }

        public void HeroName()
        {

            //Row 1
            if (xValue == 0 * 45 && yValue == 0 * 51)
            {
                heroName = "Kunkka";
            }
            if (xValue == 1 * 45 && yValue == 0 * 51)
            {
                heroName = "Chen";
            }
            if (xValue == 2 * 45 && yValue == 0 * 51)
            {
                heroName = "Phantom Lancer";
            }
            if (xValue == 3 * 45 && yValue == 0 * 51)
            {
                heroName = "Ogre Magi";
            }
            if (xValue == 4 * 45 && yValue == 0 * 51)
            {
                heroName = "Zeus";
            }
            if (xValue == 5 * 45 && yValue == 0 * 51)
            {
                heroName = "Queen Of Pain";
            }

            //Row 2

            if (xValue == 0 * 45 && yValue == 1 * 51)
            {
                heroName = "Slark";
            }
            if (xValue == 1 * 45 && yValue == 1 * 51)
            {
                heroName = "Gryo";
            }
            if (xValue == 2 * 45 && yValue == 1 * 51)
            {
                heroName = "Jakiro";
            }
            if (xValue == 3 * 45 && yValue == 1 * 51)
            {
                heroName = "Skywrath Mage";
            }
            if (xValue == 4 * 45 && yValue == 1 * 51)
            {
                heroName = "Omniknight";
            }
            if (xValue == 5 * 45 && yValue == 1 * 51)
            {
                heroName = "Lina";
            }

            //Row 3

            if (xValue == 0 * 45 && yValue == 2 * 51)
            {
                heroName = "Medusa";
            }
            if (xValue == 1 * 45 && yValue == 2 * 51)
            {
                heroName = "Death Prophet";
            }
            if (xValue == 2 * 45 && yValue == 2 * 51)
            {
                heroName = "Huskar";
            }
            if (xValue == 3 * 45 && yValue == 2 * 51)
            {
                heroName = "Oracle";
            }
            if (xValue == 4 * 45 && yValue == 2 * 51)
            {
                heroName = "Techies";
            }
            if (xValue == 5 * 45 && yValue == 2 * 51)
            {
                heroName = "Legion Commander";
            }

            //Row 4

            if (xValue == 0 * 45 && yValue == 3 * 51)
            {
                heroName = "Tidehunter";
            }
            if (xValue == 1 * 45 && yValue == 3 * 51)
            {
                heroName = "Leshrac";
            }
            if (xValue == 2 * 45 && yValue == 3 * 51)
            {
                heroName = "Spirit Breaker";
            }
            if (xValue == 3 * 45 && yValue == 3 * 51)
            {
                heroName = "Crystal Maiden";
            }
            if (xValue == 4 * 45 && yValue == 3 * 51)
            {
                heroName = "Disruptor";
            }
            if (xValue == 5 * 45 && yValue == 3 * 51)
            {
                heroName = "Sniper";
            }

            //Row 5

            if (xValue == 0 * 45 && yValue == 4 * 51)
            {
                heroName = "Sladar";
            }
            if (xValue == 1 * 45 && yValue == 4 * 51)
            {
                heroName = "Morphling";
            }
            if (xValue == 2 * 45 && yValue == 4 * 51)
            {
                heroName = "Naga Siren";
            }
            if (xValue == 3 * 45 && yValue == 4 * 51)
            {
                heroName = "Puck";
            }
            if (xValue == 4 * 45 && yValue == 4 * 51)
            {
                heroName = "Io";
            }
            if (xValue == 5 * 45 && yValue == 4 * 51)
            {
                heroName = "Vengeful Spirit";
            }

            //Row 6

            if (xValue == 0 * 45 && yValue == 5 * 51)
            {
                heroName = "Storm Spirit";
            }
            if (xValue == 1 * 45 && yValue == 5 * 51)
            {
                heroName = "Razor";
            }
            if (xValue == 2 * 45 && yValue == 5 * 51)
            {
                heroName = "Night Stalker";
            }
            if (xValue == 3 * 45 && yValue == 5 * 51)
            {
                heroName = "Enigma";
            }
            if (xValue == 4 * 45 && yValue == 5 * 51)
            {
                heroName = "Ancient Apparition";
            }
            if (xValue == 5 * 45 && yValue == 5 * 51)
            {
                heroName = "Dark Seer";
            }

        }

        private void HeroesImage_MouseClick(object sender, MouseEventArgs e)
        {
            LoadRectangles();


            int x = 0;
            int y = 0;

            for (int i = 0; i < rectangles.GetLength(0); i++)
            {

                for (int j = 0; j < rectangles.GetLength(1); j++)
                {
                    if (rectangles[i, j].Contains(e.Location) && e.Button == MouseButtons.Left)
                    {
                        this.HeroSelected.Location = new System.Drawing.Point(rectangles[i, j].X, rectangles[i, j].Y);
                        HeroSelected.Show();
                    }

                }

            }

            if (rectangles[1, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Kunkka";
            }
            if (rectangles[2, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Chen";
            }
            if (rectangles[3, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Phantom Lancer";
            }
            if (rectangles[4, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Ogre Magi";
            }
            if (rectangles[5, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Zeus";
            }
            if (rectangles[6, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Queen Of Pain";
            }

            ////Row 2

            if (rectangles[1, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Slark";
            }
            if (rectangles[2, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Gyrocopter";
            }
            if (rectangles[3, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Jakiro";
            }
            if (rectangles[4, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Skywrath Mage";
            }
            if (rectangles[5, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Omniknight";
            }
            if (rectangles[6, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Lina";
            }

            ////Row 3

            if (rectangles[1, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Medusa";
            }
            if (rectangles[2, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Death Prophet";
            }
            if (rectangles[3, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Huskar";
            }
            if (rectangles[4, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Oracle";
            }
            if (rectangles[5, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Techies";
            }
            if (rectangles[6, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Legion Commander";
            }

            //Row 4

            if (rectangles[1, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Tidehunter";
            }
            if (rectangles[2, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Leshrac";
            }
            if (rectangles[3, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Spirit Breaker";
            }
            if (rectangles[4, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Crystal Maiden";
            }
            if (rectangles[5, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Disrupter";
            }
            if (rectangles[6, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Sniper";
            }

            //Row 5

            if (rectangles[1, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Slardar";
            }
            if (rectangles[2, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Morphling";
            }
            if (rectangles[3, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Naga Siren";
            }
            if (rectangles[4, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Puck";
            }
            if (rectangles[5, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Io";
            }
            if (rectangles[6, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Vengeful Spirit";
            }

            //Row 6

            if (rectangles[1, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Storm Spirit";
            }
            if (rectangles[2, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Razor";
            }
            if (rectangles[3, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Night Stalker";
            }
            if (rectangles[4, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Enigma";
            }
            if (rectangles[5, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Ancient Apparition";
            }
            if (rectangles[6, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                heroName = "Dark Seer";
            }

            this.label1.Text = heroName;

        }

        private void HeroSelected_Click(object sender, EventArgs e)
        {

        }

        private void HeroesImage_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            dotaMenu = new Dota();
            dotaMenu.Show();
        }
    }
}
