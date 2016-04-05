using System;
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
    public partial class MainMenu : Form
    {
        Dota dota;
        League league;

        SoundPlayer sound;
        public MainMenu()
        {
            dota = new Dota();
            league = new League();
            InitializeComponent();

            sound = new SoundPlayer("Welcome_Rift2.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.Play();
            ActiveForm.Hide();
            league.Show();

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
            ActiveForm.Hide();
            dota.Show();
        }
    }
}
