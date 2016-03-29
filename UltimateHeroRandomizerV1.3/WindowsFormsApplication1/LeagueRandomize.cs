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
    public partial class LeagueRandomize : Form
    {

        Rectangle[,] rectangles;

        Random rnd = new Random();

        League leagueMenu;

        string champName;

        int xValue = 0, yValue = 0;

        public LeagueRandomize()
        {
            InitializeComponent();
            ChampionsImage.Controls.Add(ChampionSelected);
            ChampionSelected.BackColor = Color.Transparent;
            ChampionSelected.Hide();
        }

        public void LoadRectangles()
        {
            rectangles = new Rectangle[7, 7];

            int x = 0;
            int y = 0;


            for (int i = 0; i < rectangles.GetLength(0); i++)
            {

                for (int j = 0; j < rectangles.GetLength(1); j++)
                {
                    rectangles[i, j] = new Rectangle(x, y, 100, 100);
                    if (j == 0)
                    {
                        y = 0;
                    }
                    if (j == 1)
                    {
                        y = 100;
                    }
                    if (j == 2)
                    {
                        y = 200;
                    }
                    if (j == 3)
                    {
                        y = 300;
                    }
                    if (j == 4)
                    {
                        y = 400;
                    }
                    if (j == 5)
                    {
                        y = 500;
                    }
                    if (j == 6)
                    {
                        y = 600;
                    }
                }

                y += 100;
                x += 100;
                if (i == 0)
                {
                    x = 0;
                }
            }

        }

        public void Randomize()
        {

            xValue = rnd.Next(0, 6) * 100;
            yValue = rnd.Next(0, 6) * 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomize();

            ChampionName();
            this.ChampionSelected.Location = new System.Drawing.Point(xValue, yValue);
            ChampionSelected.Show();


            this.label1.Text = champName;
        }

        public void ChampionName()
        {

            //Row 1
            if (xValue == 0 * 100 && yValue == 0 * 100)
            {
                champName = "Aatrox";
            }
            if (xValue == 1 * 100 && yValue == 0 * 100)
            {
                champName = "Ahri";
            }
            if (xValue == 2 * 100 && yValue == 0 * 100)
            {
                champName = "Akali";
            }
            if (xValue == 3 * 100 && yValue == 0 * 100)
            {
                champName = "Alistar";
            }
            if (xValue == 4 * 100 && yValue == 0 * 100)
            {
                champName = "Amumu";
            }
            if (xValue == 5 * 100 && yValue == 0 * 100)
            {
                champName = "Anivia";
            }

            //Row 2

            if (xValue == 0 * 100 && yValue == 1 * 100)
            {
                champName = "Annie";
            }
            if (xValue == 1 * 100 && yValue == 1 * 100)
            {
                champName = "Ashe";
            }
            if (xValue == 2 * 100 && yValue == 1 * 100)
            {
                champName = "Azir";
            }
            if (xValue == 3 * 100 && yValue == 1 * 100)
            {
                champName = "Bard";
            }
            if (xValue == 4 * 100 && yValue == 1 * 100)
            {
                champName = "Blitzcrank";
            }
            if (xValue == 5 * 100 && yValue == 1 * 100)
            {
                champName = "Brand";
            }

            //Row 3

            if (xValue == 0 * 100 && yValue == 2 * 100)
            {
                champName = "Braum";
            }
            if (xValue == 1 * 100 && yValue == 2 * 100)
            {
                champName = "Caitlyn";
            }
            if (xValue == 2 * 100 && yValue == 2 * 100)
            {
                champName = "Cassiopeia";
            }
            if (xValue == 3 * 100 && yValue == 2 * 100)
            {
                champName = "Cho Gath";
            }
            if (xValue == 4 * 100 && yValue == 2 * 100)
            {
                champName = "Corki";
            }
            if (xValue == 5 * 100 && yValue == 2 * 100)
            {
                champName = "Darius";
            }

            //Row 4

            if (xValue == 0 * 100 && yValue == 3 * 100)
            {
                champName = "Diana";
            }
            if (xValue == 1 * 100 && yValue == 3 * 100)
            {
                champName = "Draven";
            }
            if (xValue == 2 * 100 && yValue == 3 * 100)
            {
                champName = "Dr Mundo";
            }
            if (xValue == 3 * 100 && yValue == 3 * 100)
            {
                champName = "Ekko";
            }
            if (xValue == 4 * 100 && yValue == 3 * 100)
            {
                champName = "Elise";
            }
            if (xValue == 5 * 100 && yValue == 3 * 100)
            {
                champName = "Evelynn";
            }

            //Row 5

            if (xValue == 0 * 100 && yValue == 4 * 100)
            {
                champName = "Ezreal";
            }
            if (xValue == 1 * 100 && yValue == 4 * 100)
            {
                champName = "Fiddlesticks";
            }
            if (xValue == 2 * 100 && yValue == 4 * 100)
            {
                champName = "Fiora";
            }
            if (xValue == 3 * 100 && yValue == 4 * 100)
            {
                champName = "Fizz";
            }
            if (xValue == 4 * 100 && yValue == 4 * 100)
            {
                champName = "Galio";
            }
            if (xValue == 5 * 100 && yValue == 4 * 100)
            {
                champName = "Gangplank";
            }

            //Row 6

            if (xValue == 0 * 100 && yValue == 5 * 100)
            {
                champName = "Garen";
            }
            if (xValue == 1 * 100 && yValue == 5 * 100)
            {
                champName = "Gnar";
            }
            if (xValue == 2 * 100 && yValue == 5 * 100)
            {
                champName = "Gragas";
            }
            if (xValue == 3 * 100 && yValue == 5 * 100)
            {
                champName = "Graves";
            }
            if (xValue == 4 * 100 && yValue == 5 * 100)
            {
                champName = "Hecarim";
            }
            if (xValue == 5 * 100 && yValue == 5 * 100)
            {
                champName = "Heimerdinger";
            }

        }

        private void ChampionsImage_MouseClick(object sender, MouseEventArgs e)
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
                        this.ChampionSelected.Location = new System.Drawing.Point(rectangles[i, j].X, rectangles[i, j].Y);
                        ChampionSelected.Show();
                    }

                }

            }

            if (rectangles[1, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Aatrox";
            }
            if (rectangles[2, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Ahri";
            }
            if (rectangles[3, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Akali";
            }
            if (rectangles[4, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Alistar";
            }
            if (rectangles[5, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Amumu";
            }
            if (rectangles[6, 1].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Anivia";
            }

            ////Row 2

            if (rectangles[1, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Annie";
            }
            if (rectangles[2, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Ashe";
            }
            if (rectangles[3, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Azir";
            }
            if (rectangles[4, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Bard";
            }
            if (rectangles[5, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Blitzcrank";
            }
            if (rectangles[6, 2].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Brand";
            }

            ////Row 3

            if (rectangles[1, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Braum";
            }
            if (rectangles[2, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Caitlyn";
            }
            if (rectangles[3, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Cassiopeia";
            }
            if (rectangles[4, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Cho Gath";
            }
            if (rectangles[5, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Corki";
            }
            if (rectangles[6, 3].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Darius";
            }

            //Row 4

            if (rectangles[1, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Diana";
            }
            if (rectangles[2, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Draven";
            }
            if (rectangles[3, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Dr Mundo";
            }
            if (rectangles[4, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Ekko";
            }
            if (rectangles[5, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Elise";
            }
            if (rectangles[6, 4].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Evelynn";
            }

            //Row 5

            if (rectangles[1, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Ezreal";
            }
            if (rectangles[2, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Fiddlesticks";
            }
            if (rectangles[3, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Fiora";
            }
            if (rectangles[4, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Fizz";
            }
            if (rectangles[5, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Galio";
            }
            if (rectangles[6, 5].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Gangplank";
            }

            //Row 6

            if (rectangles[1, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Garen";
            }
            if (rectangles[2, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Gnar";
            }
            if (rectangles[3, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Gragas";
            }
            if (rectangles[4, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Graves";
            }
            if (rectangles[5, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Hecarim";
            }
            if (rectangles[6, 6].Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                champName = "Heimerdinger";
            }

            this.label1.Text = champName;

        }

        private void ChampionsImage_Click(object sender, EventArgs e)
        {

        }

        private void LeagueRandomize_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            leagueMenu = new League();
            leagueMenu.Show();
        }

        private void ChampionSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
