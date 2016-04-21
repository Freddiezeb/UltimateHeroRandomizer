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
    public partial class Submeny : Form
    {
        MainMenu menu;
        Quiz quiz;
        LeagueRandomize random;

        ChooseGame gameSelected;

        bool Dota, League;

        public Submeny(ref ChooseGame game)
        {
            InitializeComponent();

                switch (game)
                {
                    case ChooseGame.League:
                        League = true;
                        break;
                    case ChooseGame.Dota:
                        this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dota2_menu3;
                        this.RandomizeButton.Location = new System.Drawing.Point(108, 192);
                        this.MinigamesButton.Location = new System.Drawing.Point(108, 294);
                        this.ReturnButton.Location = new System.Drawing.Point(108, 397);
                        Dota = true;
                        break;
                    default:
                        break;
                }
                            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menu = new MainMenu();
            menu.Show();
        }

        private void MinigamesButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            if (Dota)
            {
                gameSelected = ChooseGame.Dota;
            }
            if (League)
            {
                gameSelected = ChooseGame.League;
            }
            quiz = new Quiz(ref gameSelected);
            quiz.Show();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            random = new LeagueRandomize();
            random.Show();
        }


        public void GetEnumInfo(ref ChooseGame state)
        {
            switch (state)
            {
                case ChooseGame.League:
                    break;
                case ChooseGame.Dota:
                    this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dota2_menu3;
                    this.RandomizeButton.Text = "WATT";

                    break;
                default:
                    break;
            }
        }


 


    }
}
