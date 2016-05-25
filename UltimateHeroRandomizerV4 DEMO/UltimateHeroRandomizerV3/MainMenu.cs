using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{

  public enum ChooseGame
    {
        League,
        Dota,
    }
    public partial class MainMenu : Form
    {
        Submenu submenu;
        Highscore highScore;

        ChooseGame gameSelected;

        SoundPlayer sound;
        public MainMenu()
        {

            InitializeComponent();

            sound = new SoundPlayer("Welcome_Rift2.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameSelected = ChooseGame.League;
            submenu = new Submenu(ref gameSelected);
            //sound.Play();
            ActiveForm.Hide();
            submenu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DotaButton_Click(object sender, EventArgs e)
        {
            gameSelected = ChooseGame.Dota;
            submenu = new Submenu(ref gameSelected);
            ActiveForm.Hide();
            submenu.Show();
        }


        private void MainMenu_Click(object sender, EventArgs e)
        {

        }

        private void highscoreButton_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            highScore = new Highscore();
            highScore.Show();
        }
    }
}