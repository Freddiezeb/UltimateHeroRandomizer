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
    public partial class LeagueQuiz : Form
    {

        RadioButton correctButton;


        QuestionManager qManager;

        League leagueMenu;

        int score = 0;

        int value;

        int correctAnswer;

        int questionCount;

        string a, b, c;

        public LeagueQuiz()
        {
            InitializeComponent();

            label1.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            button1.Hide();

            ScoreLabel.Hide();

            correctButton = new RadioButton();

            ScoreLabel.Text = "Score:" + score.ToString() + " points";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correctButton.Checked)
            {
                // Lägger till poängen för varje korrekt svar
                score = score + 10;
                ScoreLabel.Text = "Score:" + score.ToString() + " points";

 
                    MessageBox.Show("NICEU");
                    CheckReset();

            }
            else
            {
                MessageBox.Show("Wrong answer, try again!");
                score = score - 5;
                ScoreLabel.Text = "Score:" + score.ToString() + " points";
            }



            qManager.SECOND(ref a, ref b, ref c, ref correctAnswer);

            GetCorrectAnswer();
            questionCount++;

            ResetQuiz();

            this.label1.Text = a;
            this.radioButton1.Text = b;
            this.radioButton2.Text = c;

        }


        private void CheckReset()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            leagueMenu = new League();
            leagueMenu.Show();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = (int)this.comboBox1.SelectedItem;
        }

        private void GetCorrectAnswer()
        {
            if (correctAnswer == 1)
            {
                correctButton = radioButton1;
            }
            if (correctAnswer == 2)
            {
                correctButton = radioButton2;
            }
            if (correctAnswer == 3)
            {
                correctButton = radioButton3;
            }
            if (correctAnswer == 4)
            {
                correctButton = radioButton4;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qManager = new QuestionManager(value);

            qManager.SECOND(ref a, ref b, ref c, ref correctAnswer);

            GetCorrectAnswer();

            this.label1.Text = a;
            this.radioButton1.Text = b;
            this.radioButton2.Text = c;
            this.label1.Show();
            this.radioButton1.Show();
            this.radioButton2.Show();
            this.button1.Show();

            comboBox1.Hide();
            button2.Hide();
        }

        public void ResetQuiz()
        {
            if (questionCount > value)
            {
                MessageBox.Show("Well Done, The Quiz Is Finished!");
                label1.Hide();
                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();
                radioButton4.Hide();
                button1.Hide();

                ScoreLabel.Hide();

                comboBox1.Show();
                button2.Show();

                questionCount = 0;

            } 
        }

    }
}
