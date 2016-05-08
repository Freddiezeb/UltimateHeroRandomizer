namespace UltimateHeroRandomizerV3
{
    partial class MainMenu
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
            this.LeagueButton = new System.Windows.Forms.Button();
            this.DotaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.highscoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeagueButton
            // 
            this.LeagueButton.BackColor = System.Drawing.Color.Transparent;
            this.LeagueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LeagueButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeagueButton.ForeColor = System.Drawing.Color.White;
            this.LeagueButton.Location = new System.Drawing.Point(504, 291);
            this.LeagueButton.Name = "LeagueButton";
            this.LeagueButton.Size = new System.Drawing.Size(175, 42);
            this.LeagueButton.TabIndex = 0;
            this.LeagueButton.Text = "League";
            this.LeagueButton.UseVisualStyleBackColor = false;
            this.LeagueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DotaButton
            // 
            this.DotaButton.BackColor = System.Drawing.Color.Transparent;
            this.DotaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DotaButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotaButton.ForeColor = System.Drawing.Color.White;
            this.DotaButton.Location = new System.Drawing.Point(504, 359);
            this.DotaButton.Name = "DotaButton";
            this.DotaButton.Size = new System.Drawing.Size(175, 45);
            this.DotaButton.TabIndex = 1;
            this.DotaButton.Text = "Dota";
            this.DotaButton.UseVisualStyleBackColor = false;
            this.DotaButton.Click += new System.EventHandler(this.DotaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(327, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ultimate Hero Randomizer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(504, 491);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 40);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.Color.Transparent;
            this.highscoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highscoreButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreButton.ForeColor = System.Drawing.Color.White;
            this.highscoreButton.Location = new System.Drawing.Point(504, 421);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(175, 49);
            this.highscoreButton.TabIndex = 4;
            this.highscoreButton.Text = "Highscore";
            this.highscoreButton.UseVisualStyleBackColor = false;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UltimateHeroRandomizerV3.Properties.Resources.mainBackground;
            this.ClientSize = new System.Drawing.Size(1200, 805);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DotaButton);
            this.Controls.Add(this.LeagueButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MainMenu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeagueButton;
        private System.Windows.Forms.Button DotaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button highscoreButton;
    }
}