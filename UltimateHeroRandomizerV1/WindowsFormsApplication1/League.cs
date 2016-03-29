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
    public partial class League : Form
    {
        MainMenu menu;
        LeagueQuiz quiz;
        LeagueRandomize random;
        public League()
        {
            InitializeComponent();
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
            quiz = new LeagueQuiz();
            quiz.Show();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            random = new LeagueRandomize();
            random.Show();
        }
    }
}
