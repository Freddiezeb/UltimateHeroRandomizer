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
        UploadHighscore upLoadHighscore;

        ChooseGame gameSelected;
        public static int quizScore = 0;
        int comboBoxValue;

        int ticks = 30;

        int questionInterval = 3;

        int correctAnswer;
        int questionCount;

        Image image;
        ImageManager imageManager;

        public static bool leagueQuestions, dotaQuestions, isQuizPlaying;

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
                    this.questionLabel.Location = new System.Drawing.Point(60, 160);
                    this.answerButton1.Location = new System.Drawing.Point(100, 220);
                    this.answerButton2.Location = new System.Drawing.Point(100, 260);
                    this.answerButton3.Location = new System.Drawing.Point(100, 300);
                    this.answerButton4.Location = new System.Drawing.Point(100, 340);
                    this.ScoreLabel.Location = new System.Drawing.Point(220, 370);
                    this.AnswerButton.Location = new System.Drawing.Point(100, 380);
                    this.pictureBox1.Location = new System.Drawing.Point(270, 200);
                    this.TimerLabel.Location = new System.Drawing.Point(220, 420);

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
                quizScore = quizScore + 10;
                ScoreLabel.Text = "Score: " + quizScore.ToString() + " points";
                CheckReset();
                correctButton.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
                correctButton.ForeColor = System.Drawing.Color.Green;
                CheckWrongMarker();
                if (quizScore > 0)
                {
                    quizScore = quizScore - 5;
                }
                ScoreLabel.Text = "Score: " + quizScore.ToString() + " points";
                CheckReset();
            }

            timer2.Start();

            questionCount++;
            ResetQuiz();


        }


        private void CheckWrongMarker()
        {
            if (answerButton1.Checked == true && answerButton1 != correctButton)
            {
                answerButton1.ForeColor = System.Drawing.Color.Red;
            }
            if (answerButton2.Checked == true && answerButton2 != correctButton)
            {
                answerButton2.ForeColor = System.Drawing.Color.Red;
            }
            if (answerButton3.Checked == true && answerButton3 != correctButton)
            {
                answerButton3.ForeColor = System.Drawing.Color.Red;
            }
            if (answerButton4.Checked == true && answerButton4 != correctButton)
            {
                answerButton4.ForeColor = System.Drawing.Color.Red;
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
            if (image != null)
            {
                this.pictureBox1.Image = image;
                pictureBox1.Show();
            }
            else
            {
                pictureBox1.Hide();
            }
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

            timer1.Stop();
            timer2.Stop();

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
                pictureBox1.Hide();
                MessageBox.Show("Well Done, The Quiz Is Finished!\nYour Score:" + quizScore);
                isQuizPlaying = true;
                HideButtons();
                NormalModeButton.Show();
                SpeedModeButton.Show();
                ticks = 30;
                questionCount = 0;
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
                ResetQuiz();
                upLoadHighscore = new UploadHighscore();
                upLoadHighscore.Show();
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
            quizScore = 0;
            ScoreLabel.Text = "Score: " + quizScore.ToString() + " points";
        }

        private void SpeedMode_Click(object sender, EventArgs e)
        {
            SpeedMode();
            NormalModeButton.Hide();
            SpeedModeButton.Hide();
            label1.Hide();
            quizScore = 0;
            comboBoxValue = 1000;
            ScoreLabel.Text = "Score: " + quizScore.ToString() + " points";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Choose how many questions you wish to\nanswer without time limit!";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "See how many questions you can answer\ncorrect in 30 seconds!";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            questionInterval--;


            if (questionInterval < 0)
            {
                LoadQuestions();
                timer2.Stop();
                questionInterval = 3;
                answerButton1.ForeColor = System.Drawing.Color.White;
                answerButton2.ForeColor = System.Drawing.Color.White;
                answerButton3.ForeColor = System.Drawing.Color.White;
                answerButton4.ForeColor = System.Drawing.Color.White;
            }
        }


    }
}

