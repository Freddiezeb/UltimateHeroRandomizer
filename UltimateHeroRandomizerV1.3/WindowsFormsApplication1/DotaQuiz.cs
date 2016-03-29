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
        RadioButton correctAnswer;

        DotaQuestion question;

        Dota dotaMenu;

        int a = 0;

        int score = 0;

        bool lastQuestion = false;

        public DotaQuiz()
        {
            InitializeComponent();

            question = new DotaQuestion(label1.Text, this.radioButton1.Text, this.radioButton2.Text, this.radioButton3.Text, this.radioButton4.Text);

            ScoreLabel.Text = "Score:" + score.ToString() + " points";

            question.Question1();

            label1.Text = question.questionText;
            radioButton1.Text = question.Answer1;
            radioButton2.Text = question.Answer2;
            radioButton3.Text = question.Answer3;
            radioButton4.Text = question.Answer4;


            this.correctAnswer = new RadioButton();

            correctAnswer = radioButton1;

        }


        private void DotaQuiz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (correctAnswer.Checked)
            {
                // Lägger till poängen för varje korrekt svar
                score = score + 10;
                ScoreLabel.Text = "Score:" + score.ToString() + " points";

                if (!lastQuestion)
                {
                    MessageBox.Show("NICEU");
                    a++;
                    QuestionNumberCheck();
                    CheckReset();
                }
                //Säger ifrån vad som händer om det är sista frågan samt korrekt svar
                if (lastQuestion && correctAnswer.Checked)
                {
                    MessageBox.Show("YOU WONNERED, WP");
                    a = 0;
                    lastQuestion = false;
                    QuestionNumberCheck();
                    CheckReset();
                }

            }
            else
            {
                MessageBox.Show("Wrong answer, try again!");
                score = score - 5;
                ScoreLabel.Text = "Score:" + score.ToString() + " points";
            }


        }

        private void QuestionNumberCheck()
        {
            if (a == 0)
            {
                question.Question1();
                correctAnswer = radioButton1;
            }
            if (a == 1)
            {
                question.Question2();
                correctAnswer = radioButton3;

            }
            if (a == 2)
            {
                question.Question3();
                correctAnswer = radioButton2;
            }
            if (a == 3)
            {
                question.Question4();
                correctAnswer = radioButton1;
            }
            if (a == 4)
            {
                question.Question5();
                correctAnswer = radioButton4;
            }
            if (a == 5)
            {
                question.Question6();
                correctAnswer = radioButton4;
            }
            if (a == 6)
            {
                question.Question7();
                correctAnswer = radioButton2;
            }
            if (a == 7)
            {
                question.Question8();
                correctAnswer = radioButton1;
            }
            if (a == 8)
            {
                question.Question9();
                correctAnswer = radioButton3;
            }
            if (a == 9)
            {
                question.Question10();
                correctAnswer = radioButton4;
            }
            if (a == 10)
            {
                question.Question11();
                correctAnswer = radioButton3;
            }
            if (a == 11)
            {
                question.Question12();
                correctAnswer = radioButton4;
            }
            if (a == 12)
            {
                question.Question13();
                correctAnswer = radioButton1;
            }

            GetQuestionAndAnswers();

        }

        private void GetQuestionAndAnswers()
        {
            label1.Text = question.questionText;
            radioButton1.Text = question.Answer1;
            radioButton2.Text = question.Answer2;
            radioButton3.Text = question.Answer3;
            radioButton4.Text = question.Answer4;
        }

        private void CheckReset()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }



        private void ReturnButton_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            dotaMenu = new Dota();
            dotaMenu.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
