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
    public partial class Highscore : Form
    {

        MainMenu menu;

        public Highscore()
        {
            InitializeComponent();
            load_spTable();
        }

        void load_spTable()
        {
            string constring = "datasource=195.178.232.16;username=AF7302;password=Freddie95";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from af7302.slidepuzzle ;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                sp_dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sp_buttonUpdate_Click(object sender, EventArgs e)
        {
            string constring = "datasource=195.178.232.16;username=AF7302;password=Freddie95";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from af7302.slidepuzzle ;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                sp_dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menu = new MainMenu();

            menu.Show();
        }
    }
}