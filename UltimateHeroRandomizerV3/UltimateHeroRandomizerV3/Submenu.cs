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
    public partial class Submenu : Form
    {
        MainMenu menu;
        Quiz quiz;


        ChooseGame gameSelected;

        bool Dota, League;

        public Submenu(ref ChooseGame game)
        {
            InitializeComponent();

            switch (game)
            {
                case ChooseGame.League:
                    League = true;
                    break;
                case ChooseGame.Dota:
                    Dota = true;
                    this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.dota2_menu3;
                    this.RandomizeButton.Location = new System.Drawing.Point(108, 192);
                    this.MinigamesButton.Location = new System.Drawing.Point(108, 294);
                    this.ReturnButton.Location = new System.Drawing.Point(108, 397);

                    QuizButton.Location = new System.Drawing.Point(108, 140);
                    MemoryButton.Location = new System.Drawing.Point(108, 240);
                    SlidePuzzleButton.Location = new System.Drawing.Point(108, 340);
                    PongButton.Location = new System.Drawing.Point(108, 440);
                    DiceButton.Location = new System.Drawing.Point(108, 540);
                    break;
                default:
                    break;
            }
            QuizButton.Hide();
            MemoryButton.Hide();
            SlidePuzzleButton.Hide();
            PongButton.Hide();
            DiceButton.Hide();

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menu = new MainMenu();
            menu.Show();
        }

        private void MinigamesButton_Click(object sender, EventArgs e)
        {
            if (Dota)
            {
                gameSelected = ChooseGame.Dota;
            }
            if (League)
            {
                gameSelected = ChooseGame.League;
            }

            ShowMinigames();

        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();


            using (var game = new Game1())
                game.Run();
        }


        public void GetEnumInfo(ref ChooseGame state)
        {
            switch (state)
            {
                case ChooseGame.League:
                    break;
                case ChooseGame.Dota:


                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowMinigames()
        {
            QuizButton.Show();
            MemoryButton.Show();
            SlidePuzzleButton.Show();
            PongButton.Show();
            DiceButton.Show();

            ReturnButton.Hide();
            MinigamesButton.Hide();
            RandomizeButton.Hide();
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            quiz = new Quiz(ref gameSelected);
            quiz.Show();
        }

    }
}