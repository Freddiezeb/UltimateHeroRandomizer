using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    public partial class Quiz : Form
    {
        RadioButton correctButton;
        QuestionManager qManager;
        Submenu subMenu;

        ChooseGame gameSelected;
        int score = 0;
        int comboBoxValue;

        int ticks = 30;

        int correctAnswer;
        int questionCount;

        Image image;
        ImageManager imageManager;

        public static bool leagueQuestions, dotaQuestions;

        string qText, answer1, answer2, answer3, answer4;

        public Quiz(ref ChooseGame gameSelected)
        {
            imageManager = new ImageManager();
            InitializeComponent();


            switch (gameSelected)
            {
                case ChooseGame.League:
                    leagueQuestions = true;
                    dotaQuestions = false;
                    break;
                case ChooseGame.Dota:
                    dotaQuestions = true;
                    leagueQuestions = false;
                    this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.dota2_menu3;
                    this.questionLabel.Location = new System.Drawing.Point(103, 186);
                    this.answerButton1.Location = new System.Drawing.Point(133, 226);
                    this.answerButton2.Location = new System.Drawing.Point(133, 245);
                    this.answerButton3.Location = new System.Drawing.Point(133, 264);
                    this.answerButton4.Location = new System.Drawing.Point(133, 283);
                    this.ScoreLabel.Location = new System.Drawing.Point(125, 350);
                    this.AnswerButton.Location = new System.Drawing.Point(135, 310);

                    this.StartQuizButton.Location = new System.Drawing.Point(140, 250);
                    this.questionAmountBox.Location = new System.Drawing.Point(140, 220);

                    this.NormalModeButton.Location = new System.Drawing.Point(80, 250);
                    this.SpeedModeButton.Location = new System.Drawing.Point(220, 250);
                    this.label1.Location = new System.Drawing.Point(80, 300);
                    break;
                default:
                    break;
            }

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

            if (image != null)
            {
                this.questionLabel.Location = new System.Drawing.Point(514, 165);
                this.answerButton1.Location = new System.Drawing.Point(514, 316);
                this.answerButton2.Location = new System.Drawing.Point(514, 335);
                this.answerButton3.Location = new System.Drawing.Point(514, 354);
                this.answerButton4.Location = new System.Drawing.Point(514, 373);
                this.ScoreLabel.Location = new System.Drawing.Point(514, 450);
                this.AnswerButton.Location = new System.Drawing.Point(514, 410);
            }
            else
            {
                this.questionLabel.Location = new System.Drawing.Point(474, 198);
                this.answerButton1.Location = new System.Drawing.Point(514, 244);
                this.answerButton2.Location = new System.Drawing.Point(514, 263);
                this.answerButton3.Location = new System.Drawing.Point(514, 282);
                this.answerButton4.Location = new System.Drawing.Point(514, 301);
                this.ScoreLabel.Location = new System.Drawing.Point(483, 416);
                this.AnswerButton.Location = new System.Drawing.Point(523, 335);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxValue != 0)
            {
                LoadQuestions();
                ShowButtons();

                questionAmountBox.Hide();
                StartQuizButton.Hide();
            }

        }

        private void GetStringInfo()
        {
            this.questionLabel.Text = qText;
            this.answerButton1.Text = answer1;
            this.answerButton2.Text = answer2;
            this.answerButton3.Text = answer3;
            this.answerButton4.Text = answer4;
            this.pictureBox1.Image = image;
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

            if (dotaQuestions)
            {
                gameSelected = ChooseGame.Dota;
            }
            if (leagueQuestions)
            {
                gameSelected = ChooseGame.League;
            }

            subMenu = new Submenu(ref gameSelected);
            subMenu.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxValue = (int)this.questionAmountBox.SelectedItem;
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
                NormalModeButton.Show();
                SpeedModeButton.Show();
                ticks = 30;
                questionCount = 0;
                score = 0;
                label1.Show();
                label1.Text = "";
                qManager.ReviveQuestions();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;

            this.TimerLabel.Text = "Time Left: " + ticks;

            if (ticks < 1)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! Your score: " + score);
                ResetQuiz();
            }
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
            questionAmountBox.Show();
            StartQuizButton.Show();
        }

        private void LoadQuestions()
        {
            qManager.LoadQuestion(ref qText, ref answer1, ref answer2, ref answer3, ref answer4, ref correctAnswer, ref image);
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
            AnswerButton.Hide();
            StartQuizButton.Hide();
            TimerLabel.Hide();
            questionAmountBox.Hide();
            ScoreLabel.Hide();
        }

        private void ShowButtons()
        {
            questionLabel.Show();
            answerButton1.Show();
            answerButton2.Show();
            answerButton3.Show();
            answerButton4.Show();
            AnswerButton.Show();
            ScoreLabel.Show();
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            NormalMode();
            NormalModeButton.Hide();
            SpeedModeButton.Hide();
            label1.Hide();
        }

        private void SpeedMode_Click(object sender, EventArgs e)
        {
            SpeedMode();
            NormalModeButton.Hide();
            SpeedModeButton.Hide();
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

