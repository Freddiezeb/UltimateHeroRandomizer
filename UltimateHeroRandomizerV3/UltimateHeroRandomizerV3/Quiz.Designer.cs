namespace UltimateHeroRandomizerV3
{
    partial class Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.answerButton1 = new System.Windows.Forms.RadioButton();
            this.answerButton2 = new System.Windows.Forms.RadioButton();
            this.answerButton3 = new System.Windows.Forms.RadioButton();
            this.answerButton4 = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.questionAmountBox = new System.Windows.Forms.ComboBox();
            this.StartQuizButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.NormalModeButton = new System.Windows.Forms.Button();
            this.SpeedModeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton1
            // 
            this.answerButton1.AutoSize = true;
            this.answerButton1.BackColor = System.Drawing.Color.Transparent;
            this.answerButton1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton1.ForeColor = System.Drawing.Color.White;
            this.answerButton1.Location = new System.Drawing.Point(514, 244);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(14, 13);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.UseVisualStyleBackColor = false;
            // 
            // answerButton2
            // 
            this.answerButton2.AutoSize = true;
            this.answerButton2.BackColor = System.Drawing.Color.Transparent;
            this.answerButton2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton2.ForeColor = System.Drawing.Color.White;
            this.answerButton2.Location = new System.Drawing.Point(514, 263);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(14, 13);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.UseVisualStyleBackColor = false;
            this.answerButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // answerButton3
            // 
            this.answerButton3.AutoSize = true;
            this.answerButton3.BackColor = System.Drawing.Color.Transparent;
            this.answerButton3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton3.ForeColor = System.Drawing.Color.White;
            this.answerButton3.Location = new System.Drawing.Point(514, 282);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(14, 13);
            this.answerButton3.TabIndex = 2;
            this.answerButton3.UseVisualStyleBackColor = false;
            // 
            // answerButton4
            // 
            this.answerButton4.AutoSize = true;
            this.answerButton4.BackColor = System.Drawing.Color.Transparent;
            this.answerButton4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton4.ForeColor = System.Drawing.Color.White;
            this.answerButton4.Location = new System.Drawing.Point(514, 301);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(14, 13);
            this.answerButton4.TabIndex = 3;
            this.answerButton4.UseVisualStyleBackColor = false;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(474, 198);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 20);
            this.questionLabel.TabIndex = 4;
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnswerButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton.ForeColor = System.Drawing.Color.White;
            this.AnswerButton.Location = new System.Drawing.Point(523, 335);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(69, 33);
            this.AnswerButton.TabIndex = 5;
            this.AnswerButton.Text = "Answer";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(483, 416);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(50, 20);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(1083, 28);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 36);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(987, 28);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(77, 36);
            this.ReturnButton.TabIndex = 8;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // questionAmountBox
            // 
            this.questionAmountBox.FormattingEnabled = true;
            this.questionAmountBox.Items.AddRange(new object[] {
            5,
            10,
            15});
            this.questionAmountBox.Location = new System.Drawing.Point(557, 201);
            this.questionAmountBox.Name = "questionAmountBox";
            this.questionAmountBox.Size = new System.Drawing.Size(83, 21);
            this.questionAmountBox.TabIndex = 9;
            this.questionAmountBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StartQuizButton
            // 
            this.StartQuizButton.BackColor = System.Drawing.Color.Transparent;
            this.StartQuizButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartQuizButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartQuizButton.ForeColor = System.Drawing.Color.White;
            this.StartQuizButton.Location = new System.Drawing.Point(557, 228);
            this.StartQuizButton.Name = "StartQuizButton";
            this.StartQuizButton.Size = new System.Drawing.Size(83, 29);
            this.StartQuizButton.TabIndex = 10;
            this.StartQuizButton.Text = "Start Quiz";
            this.StartQuizButton.UseVisualStyleBackColor = false;
            this.StartQuizButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimerLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(483, 461);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(70, 20);
            this.TimerLabel.TabIndex = 11;
            this.TimerLabel.Text = "Time Left:";
            // 
            // NormalModeButton
            // 
            this.NormalModeButton.BackColor = System.Drawing.Color.Transparent;
            this.NormalModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NormalModeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalModeButton.ForeColor = System.Drawing.Color.White;
            this.NormalModeButton.Location = new System.Drawing.Point(487, 270);
            this.NormalModeButton.Name = "NormalModeButton";
            this.NormalModeButton.Size = new System.Drawing.Size(116, 44);
            this.NormalModeButton.TabIndex = 12;
            this.NormalModeButton.Text = "Normal Mode\r\n";
            this.NormalModeButton.UseVisualStyleBackColor = false;
            this.NormalModeButton.Click += new System.EventHandler(this.NormalMode_Click);
            this.NormalModeButton.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // SpeedModeButton
            // 
            this.SpeedModeButton.BackColor = System.Drawing.Color.Transparent;
            this.SpeedModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpeedModeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedModeButton.ForeColor = System.Drawing.Color.White;
            this.SpeedModeButton.Location = new System.Drawing.Point(619, 271);
            this.SpeedModeButton.Name = "SpeedModeButton";
            this.SpeedModeButton.Size = new System.Drawing.Size(116, 44);
            this.SpeedModeButton.TabIndex = 13;
            this.SpeedModeButton.Text = "Speed Mode";
            this.SpeedModeButton.UseVisualStyleBackColor = false;
            this.SpeedModeButton.Click += new System.EventHandler(this.SpeedMode_Click);
            this.SpeedModeButton.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.lolquiz;
            this.ClientSize = new System.Drawing.Size(1196, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedModeButton);
            this.Controls.Add(this.NormalModeButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StartQuizButton);
            this.Controls.Add(this.questionAmountBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton answerButton1;
        private System.Windows.Forms.RadioButton answerButton2;
        private System.Windows.Forms.RadioButton answerButton3;
        private System.Windows.Forms.RadioButton answerButton4;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox questionAmountBox;
        private System.Windows.Forms.Button StartQuizButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button NormalModeButton;
        private System.Windows.Forms.Button SpeedModeButton;
        private System.Windows.Forms.Label label1;

    }
}