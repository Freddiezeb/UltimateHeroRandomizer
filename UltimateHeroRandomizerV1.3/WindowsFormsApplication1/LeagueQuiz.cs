﻿using System;
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
        int comboBoxValue;

        int ticks = 30;

        int correctAnswer;
        int questionCount;

        string qText, answer1, answer2, answer3, answer4;

        public LeagueQuiz()
        {
            InitializeComponent();
            qManager = new QuestionManager();
            correctButton = new RadioButton();
            HideButtons();            
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
                Console.WriteLine("WATTTT");
            }
                       
            questionCount++;
            ResetQuiz();
            LoadQuestions();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadQuestions();
            ShowButtons();

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
            comboBoxValue = (int)this.comboBox1.SelectedItem;
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
            if (questionCount == comboBoxValue || ticks < 1)
            {
                MessageBox.Show("Well Done, The Quiz Is Finished!\nYour Score:" + score);
                HideButtons();
                button3.Show();
                button4.Show();
                ticks = 30;
                questionCount = 0;
                score = 0;
                label1.Show();
                label1.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ticks--;

            //this.TimerLabel.Text = "Time Left: " + ticks;

            //if (ticks < 1)
            //{
            //    timer1.Stop();
            //    MessageBox.Show("Time's up! Your score: " + score);
            //    ResetQuiz();
            //}
        }

        private void SpeedMode()
        {
            TimerLabel.Show();
            timer1.Start();
            ShowButtons();
            LoadQuestions();
        }

        private void NormalMode()
        {
            comboBox1.Show();
            button2.Show();
        }

        private void LoadQuestions()
        {
            qManager.LoadQuestion(ref qText, ref answer1, ref answer2, ref answer3, ref answer4, ref correctAnswer);
            GetCorrectAnswer();
            GetStringInfo();
        }

        private void HideButtons()
        {
            questionLabel.Hide();
            answerButton1.Hide();
            answerButton2.Hide();
            answerButton3.Hide();
            answerButton4.Hide();
            button1.Hide();
            button2.Hide();
            TimerLabel.Hide();
            comboBox1.Hide();
            ScoreLabel.Hide();
        }

        private void ShowButtons()
        {
            questionLabel.Show();
            answerButton1.Show();
            answerButton2.Show();
            answerButton3.Show();
            answerButton4.Show();
            button1.Show();
            ScoreLabel.Show();
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();
            button3.Hide();
            button4.Hide();
            label1.Hide();
        }

        private void SpeedMode_Click(object sender, EventArgs e)
        {
            SpeedMode();
            button3.Hide();
            button4.Hide();
            label1.Hide();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Choose how many questions you wish to\nanswer without time limit!";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "See how many questions you can answer\ncorrect in 30 seconds!";
        }

    }
}
