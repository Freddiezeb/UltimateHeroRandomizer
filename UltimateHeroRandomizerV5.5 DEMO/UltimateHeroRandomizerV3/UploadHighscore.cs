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
        SlidePuzzle slidePuzzle = new SlidePuzzle();

        public UploadHighscore()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine(SlidePuzzle.ticks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=195.178.232.16;username=AF7302;password=Freddie95";
            string Query = "insert into af7302.slidepuzzle (namn, score) values('" + this.nameBox.Text + "','" + SlidePuzzle.ticks + "') ;";
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
    }
}