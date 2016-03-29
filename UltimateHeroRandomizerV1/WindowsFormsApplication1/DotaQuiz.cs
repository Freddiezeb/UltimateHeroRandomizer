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
    public partial class DotaQuiz : Form
    {
      int totalScore = 0;
        public DotaQuiz()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (CorrectAnswer.Checked)
            {
                totalScore ++;
                MessageBox.Show("Well Done! - Correct Answer");
                ScoreLabel.Text = totalScore.ToString();
            }          
            else MessageBox.Show("Try again retard!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DontTouch_Click(object sender, EventArgs e)
        {

        }

        private void DotaQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
