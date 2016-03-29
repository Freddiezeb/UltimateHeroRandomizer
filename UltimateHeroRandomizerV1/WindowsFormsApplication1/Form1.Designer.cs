namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.LeagueButton = new System.Windows.Forms.Button();
            this.DotaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeagueButton
            // 
            this.LeagueButton.BackColor = System.Drawing.SystemColors.Window;
            this.LeagueButton.Image = ((System.Drawing.Image)(resources.GetObject("LeagueButton.Image")));
            this.LeagueButton.Location = new System.Drawing.Point(236, 198);
            this.LeagueButton.Name = "LeagueButton";
            this.LeagueButton.Size = new System.Drawing.Size(175, 42);
            this.LeagueButton.TabIndex = 0;
            this.LeagueButton.Text = "League";
            this.LeagueButton.UseVisualStyleBackColor = false;
            this.LeagueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DotaButton
            // 
            this.DotaButton.Image = ((System.Drawing.Image)(resources.GetObject("DotaButton.Image")));
            this.DotaButton.Location = new System.Drawing.Point(236, 266);
            this.DotaButton.Name = "DotaButton";
            this.DotaButton.Size = new System.Drawing.Size(175, 45);
            this.DotaButton.TabIndex = 1;
            this.DotaButton.Text = "Dota";
            this.DotaButton.UseVisualStyleBackColor = true;
            this.DotaButton.Click += new System.EventHandler(this.DotaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(156, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(236, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 40);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(236, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DotaButton);
            this.Controls.Add(this.LeagueButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeagueButton;
        private System.Windows.Forms.Button DotaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
    }
}

