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
    public partial class Dota : Form
    {
        MainMenu menu;
        DotaQuiz quiz;
        public Dota()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menu = new MainMenu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            quiz = new DotaQuiz();
            quiz.Show();
        }

        private void Dota_Load(object sender, EventArgs e)
        {

        }
    }
}
