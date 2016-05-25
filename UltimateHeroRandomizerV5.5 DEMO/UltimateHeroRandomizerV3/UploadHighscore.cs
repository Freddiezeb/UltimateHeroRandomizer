using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UltimateHeroRandomizerV3
{
    public partial class UploadHighscore : Form
    {


        public UploadHighscore()
        {
            InitializeComponent();
            if (Submenu.League)
            {
                pictureBox1.Image = global::UltimateHeroRandomizerV3.Properties.Resources.logolol;
            }
            if (Submenu.Dota)
            {
                pictureBox1.Image = global::UltimateHeroRandomizerV3.Properties.Resources._250pxDotA2;
            }
            System.Diagnostics.Debug.WriteLine(SlidePuzzle.ticks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query;
            string constring = "datasource=195.178.232.16;username=AF7302;password=Freddie95";
            if (Quiz.isQuizPlaying == true)
            {
                Query = "insert into af7302.quiz (namn, score) values('" + this.nameBox.Text + "','" + Quiz.quizScore + "') ;";
                Quiz.isQuizPlaying = false;
            }
            else if (Memory.isMemoryPlaying == true)
            {
                Query = "insert into af7302.memory (namn, score) values('" + this.nameBox.Text + "','" + Memory.memoryScore + "') ;";
                Memory.isMemoryPlaying = false;
            }
            else
            { 
                Query = "insert into af7302.slidepuzzle (namn, score) values('" + this.nameBox.Text + "','" + SlidePuzzle.ticks + "') ;";
            }
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}