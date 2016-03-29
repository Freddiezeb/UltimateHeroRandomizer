namespace WindowsFormsApplication1
{
    partial class DotaQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotaQuiz));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxq1 = new System.Windows.Forms.GroupBox();
            this.DontTouch = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.WrongAnswer2 = new System.Windows.Forms.RadioButton();
            this.WrongAnswer1 = new System.Windows.Forms.RadioButton();
            this.CorrectAnswer = new System.Windows.Forms.RadioButton();
            this.groupBoxq1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxq1
            // 
            this.groupBoxq1.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxq1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxq1.BackgroundImage")));
            this.groupBoxq1.Controls.Add(this.DontTouch);
            this.groupBoxq1.Controls.Add(this.ScoreLabel);
            this.groupBoxq1.Controls.Add(this.WrongAnswer2);
            this.groupBoxq1.Controls.Add(this.WrongAnswer1);
            this.groupBoxq1.Controls.Add(this.CorrectAnswer);
            this.groupBoxq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxq1.ForeColor = System.Drawing.Color.White;
            this.groupBoxq1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxq1.Name = "groupBoxq1";
            this.groupBoxq1.Size = new System.Drawing.Size(344, 287);
            this.groupBoxq1.TabIndex = 2;
            this.groupBoxq1.TabStop = false;
            this.groupBoxq1.Text = "What kind of damage is Witch doctors ultimate?";
            this.groupBoxq1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DontTouch
            // 
            this.DontTouch.AutoSize = true;
            this.DontTouch.BackColor = System.Drawing.Color.Transparent;
            this.DontTouch.ForeColor = System.Drawing.Color.White;
            this.DontTouch.Location = new System.Drawing.Point(7, 257);
            this.DontTouch.Name = "DontTouch";
            this.DontTouch.Size = new System.Drawing.Size(80, 25);
            this.DontTouch.TabIndex = 4;
            this.DontTouch.Text = "Score:";
            this.DontTouch.Click += new System.EventHandler(this.DontTouch_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(84, 257);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 25);
            this.ScoreLabel.TabIndex = 3;
            // 
            // WrongAnswer2
            // 
            this.WrongAnswer2.AutoSize = true;
            this.WrongAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.WrongAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswer2.ForeColor = System.Drawing.Color.White;
            this.WrongAnswer2.Location = new System.Drawing.Point(16, 158);
            this.WrongAnswer2.Name = "WrongAnswer2";
            this.WrongAnswer2.Size = new System.Drawing.Size(157, 29);
            this.WrongAnswer2.TabIndex = 2;
            this.WrongAnswer2.TabStop = true;
            this.WrongAnswer2.Text = "True damage";
            this.WrongAnswer2.UseVisualStyleBackColor = false;
            // 
            // WrongAnswer1
            // 
            this.WrongAnswer1.AutoSize = true;
            this.WrongAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.WrongAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswer1.ForeColor = System.Drawing.Color.White;
            this.WrongAnswer1.Location = new System.Drawing.Point(16, 123);
            this.WrongAnswer1.Name = "WrongAnswer1";
            this.WrongAnswer1.Size = new System.Drawing.Size(171, 29);
            this.WrongAnswer1.TabIndex = 1;
            this.WrongAnswer1.TabStop = true;
            this.WrongAnswer1.Text = "Magic damage";
            this.WrongAnswer1.UseVisualStyleBackColor = false;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.AutoSize = true;
            this.CorrectAnswer.BackColor = System.Drawing.Color.Transparent;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.ForeColor = System.Drawing.Color.White;
            this.CorrectAnswer.Location = new System.Drawing.Point(16, 88);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Size = new System.Drawing.Size(194, 29);
            this.CorrectAnswer.TabIndex = 0;
            this.CorrectAnswer.TabStop = true;
            this.CorrectAnswer.Text = "Physical damage";
            this.CorrectAnswer.UseVisualStyleBackColor = false;
            // 
            // DotaQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(343, 423);
            this.Controls.Add(this.groupBoxq1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DotaQuiz";
            this.Text = "League of Quiz";
            this.Load += new System.EventHandler(this.DotaQuiz_Load);
            this.groupBoxq1.ResumeLayout(false);
            this.groupBoxq1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxq1;
        private System.Windows.Forms.RadioButton WrongAnswer2;
        private System.Windows.Forms.RadioButton WrongAnswer1;
        private System.Windows.Forms.RadioButton CorrectAnswer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label DontTouch;

        #endregion
    }
}