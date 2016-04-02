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

        string qText, answer1, answer2, answer3, answer4;

        public LeagueQuiz()
        {
            InitializeComponent();

            questionLabel.Hide();
            answerButton1.Hide();
            answerButton2.Hide();
            answerButton3.Hide();
            answerButton4.Hide();
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
                MessageBox.Show("Wrong answer!");
                score = score - 5;
                ScoreLabel.Text = "Score:" + score.ToString() + " points";
                CheckReset();
            }

            questionCount++;
            ResetQuiz();

            qManager.LoadQuestion(ref qText, ref answer1, ref answer2, ref answer3, ref answer4, ref correctAnswer);

            GetCorrectAnswer();

            GetStringInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qManager = new QuestionManager();

            qManager.LoadQuestion(ref qText, ref answer1, ref answer2, ref answer3, ref answer4, ref correctAnswer);

            GetCorrectAnswer();

            GetStringInfo();

            this.questionLabel.Show();
            this.answerButton1.Show();
            this.answerButton2.Show();
            this.answerButton3.Show();
            this.answerButton4.Show();
            this.button1.Show();

            this.ScoreLabel.Show();

            comboBox1.Hide();
            button2.Hide();
        }

        private void GetStringInfo()
        {
            this.questionLabel.Text = qText;
            this.answerButton1.Text = answer1;
            this.answerButton2.Text = answer2;
            this.answerButton3.Text = answer3;
            this.answerButton4.Text = answer4;
        }

        private void CheckReset()
        {
            answerButton1.Checked = false;
            answerButton2.Checked = false;
            answerButton3.Checked = false;
            answerButton4.Checked = false;
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
                correctButton = answerButton1;
            }
            if (correctAnswer == 2)
            {
                correctButton = answerButton2;
            }
            if (correctAnswer == 3)
            {
                correctButton = answerButton3;
            }
            if (correctAnswer == 4)
            {
                correctButton = answerButton4;
            }
        }



        public void ResetQuiz()
        {
            if (questionCount == value)
            {
                MessageBox.Show("Well Done, The Quiz Is Finished!\nYour Score:" + score);
                questionLabel.Hide();
                answerButton1.Hide();
                answerButton2.Hide();
                answerButton3.Hide();
                answerButton4.Hide();
                button1.Hide();

                ScoreLabel.Hide();

                comboBox1.Show();
                button2.Show();

                questionCount = 0;

            }
        }



    }
}
