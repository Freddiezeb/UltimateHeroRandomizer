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
        Memory memory;
        SlidePuzzle slidePuzzle;

        Form gameForm;

        ChooseGame gameSelected;

        public static bool Dota, League;

        public Submenu(ref ChooseGame game)
        {
            InitializeComponent();

            switch (game)
            {
                case ChooseGame.League:
                    League = true;
                    Dota = false;
                    break;
                case ChooseGame.Dota:
                    Dota = true;
                    League = false;
                    this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.dota2_menu3;
                    this.RandomizeButton.Location = new System.Drawing.Point(108, 192);
                    this.MinigamesButton.Location = new System.Drawing.Point(108, 294);
                    this.ReturnButton.Location = new System.Drawing.Point(108, 397);
                    QuizButton.Location = new System.Drawing.Point(108, 100);
                    MemoryButton.Location = new System.Drawing.Point(108, 200);
                    SlidePuzzleButton.Location = new System.Drawing.Point(108, 300);
                    PongButton.Location = new System.Drawing.Point(108, 400);
                    DiceButton.Location = new System.Drawing.Point(108, 500);
                    BackButton.Location = new System.Drawing.Point(108, 600);
                    break;
                default:
                    break;
            }
            QuizButton.Hide();
            MemoryButton.Hide();
            SlidePuzzleButton.Hide();
            PongButton.Hide();
            DiceButton.Hide();
            BackButton.Hide();

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
            if (Dota)
            {
                gameSelected = ChooseGame.Dota;
            }
            if (League)
            {
                gameSelected = ChooseGame.League;
            }

            using (var game = new Game1())
            {
                gameForm = Control.FromHandle(game.Window.Handle) as Form;
                gameForm.ClientSize = new System.Drawing.Size(1175, 900);
                game.Run();
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
            BackButton.Show();

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

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            memory = new Memory();
            memory.Show();
        }

        private void SlidePuzzleButton_Click(object sender, EventArgs e)
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
            slidePuzzle = new SlidePuzzle();
            slidePuzzle.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            QuizButton.Hide();
            MemoryButton.Hide();
            SlidePuzzleButton.Hide();
            PongButton.Hide();
            DiceButton.Hide();
            BackButton.Hide();

            ReturnButton.Show();
            MinigamesButton.Show();
            RandomizeButton.Show();
        }
    }
}