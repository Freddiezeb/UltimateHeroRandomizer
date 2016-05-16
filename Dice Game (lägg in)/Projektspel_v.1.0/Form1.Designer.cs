namespace Projektspel_v._1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_p1RollDice = new System.Windows.Forms.Button();
            this.lbl_p1DisplayResults = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_winnerResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_p1Dice5 = new System.Windows.Forms.Label();
            this.lbl_p1Dice4 = new System.Windows.Forms.Label();
            this.lbl_p1Dice3 = new System.Windows.Forms.Label();
            this.lbl_p1Dice2 = new System.Windows.Forms.Label();
            this.lbl_p1Dice1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bossHP = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_p1RollDice
            // 
            this.btn_p1RollDice.Location = new System.Drawing.Point(640, 507);
            this.btn_p1RollDice.Name = "btn_p1RollDice";
            this.btn_p1RollDice.Size = new System.Drawing.Size(200, 122);
            this.btn_p1RollDice.TabIndex = 5;
            this.btn_p1RollDice.Text = "Roll Dice";
            this.btn_p1RollDice.UseVisualStyleBackColor = true;
            this.btn_p1RollDice.Click += new System.EventHandler(this.btn_p1RollDice_Click);
            // 
            // lbl_p1DisplayResults
            // 
            this.lbl_p1DisplayResults.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1DisplayResults.Location = new System.Drawing.Point(289, 492);
            this.lbl_p1DisplayResults.Name = "lbl_p1DisplayResults";
            this.lbl_p1DisplayResults.Size = new System.Drawing.Size(250, 82);
            this.lbl_p1DisplayResults.TabIndex = 6;
            this.lbl_p1DisplayResults.Text = "Roll The Dice";
            this.lbl_p1DisplayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_title.Location = new System.Drawing.Point(165, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(550, 74);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Ultimate Dice Hero MF";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_winnerResult
            // 
            this.lbl_winnerResult.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerResult.Location = new System.Drawing.Point(255, 83);
            this.lbl_winnerResult.Name = "lbl_winnerResult";
            this.lbl_winnerResult.Size = new System.Drawing.Size(350, 50);
            this.lbl_winnerResult.TabIndex = 15;
            this.lbl_winnerResult.Text = "Waiting for roll";
            this.lbl_winnerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projektspel_v._1._0.Properties.Resources.boss11;
            this.pictureBox1.Location = new System.Drawing.Point(234, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 253);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(614, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 10);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_p1Dice5
            // 
            this.lbl_p1Dice5.Image = ((System.Drawing.Image)(resources.GetObject("lbl_p1Dice5.Image")));
            this.lbl_p1Dice5.Location = new System.Drawing.Point(503, 590);
            this.lbl_p1Dice5.Name = "lbl_p1Dice5";
            this.lbl_p1Dice5.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice5.TabIndex = 4;
            // 
            // lbl_p1Dice4
            // 
            this.lbl_p1Dice4.Image = ((System.Drawing.Image)(resources.GetObject("lbl_p1Dice4.Image")));
            this.lbl_p1Dice4.Location = new System.Drawing.Point(447, 590);
            this.lbl_p1Dice4.Name = "lbl_p1Dice4";
            this.lbl_p1Dice4.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice4.TabIndex = 3;
            // 
            // lbl_p1Dice3
            // 
            this.lbl_p1Dice3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_p1Dice3.Image")));
            this.lbl_p1Dice3.Location = new System.Drawing.Point(391, 590);
            this.lbl_p1Dice3.Name = "lbl_p1Dice3";
            this.lbl_p1Dice3.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice3.TabIndex = 2;
            // 
            // lbl_p1Dice2
            // 
            this.lbl_p1Dice2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_p1Dice2.Image")));
            this.lbl_p1Dice2.Location = new System.Drawing.Point(335, 590);
            this.lbl_p1Dice2.Name = "lbl_p1Dice2";
            this.lbl_p1Dice2.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice2.TabIndex = 1;
            // 
            // lbl_p1Dice1
            // 
            this.lbl_p1Dice1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_p1Dice1.Image")));
            this.lbl_p1Dice1.Location = new System.Drawing.Point(279, 590);
            this.lbl_p1Dice1.Name = "lbl_p1Dice1";
            this.lbl_p1Dice1.Size = new System.Drawing.Size(50, 50);
            this.lbl_p1Dice1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Boss";
            // 
            // lbl_bossHP
            // 
            this.lbl_bossHP.AutoSize = true;
            this.lbl_bossHP.Location = new System.Drawing.Point(297, 415);
            this.lbl_bossHP.Name = "lbl_bossHP";
            this.lbl_bossHP.Size = new System.Drawing.Size(0, 13);
            this.lbl_bossHP.TabIndex = 22;
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(300, 442);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(239, 23);
            this.healthBar.TabIndex = 23;
            this.healthBar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.lbl_bossHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_winnerResult);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_p1DisplayResults);
            this.Controls.Add(this.btn_p1RollDice);
            this.Controls.Add(this.lbl_p1Dice5);
            this.Controls.Add(this.lbl_p1Dice4);
            this.Controls.Add(this.lbl_p1Dice3);
            this.Controls.Add(this.lbl_p1Dice2);
            this.Controls.Add(this.lbl_p1Dice1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.Text = "Ultimate Dice Hero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_p1Dice1;
        private System.Windows.Forms.Label lbl_p1Dice2;
        private System.Windows.Forms.Label lbl_p1Dice3;
        private System.Windows.Forms.Label lbl_p1Dice4;
        private System.Windows.Forms.Label lbl_p1Dice5;
        private System.Windows.Forms.Button btn_p1RollDice;
        private System.Windows.Forms.Label lbl_p1DisplayResults;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_winnerResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_bossHP;
        private System.Windows.Forms.ProgressBar healthBar;
    }
}

