﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public enum ChooseGame
    {
        League,
        Dota,
    }
    public partial class MainMenu : Form
    {
        Submeny submeny;



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
            submeny = new Submeny(ref gameSelected);
            sound.Play();
            ActiveForm.Hide();
            submeny.Show();
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
            submeny = new Submeny(ref gameSelected);
            ActiveForm.Hide();
            submeny.Show();
        }


        private void MainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
