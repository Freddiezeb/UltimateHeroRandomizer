namespace WindowsFormsApplication1
{
    partial class LeagueRandomize
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
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ChampionSelected = new System.Windows.Forms.PictureBox();
            this.ChampionsImage = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broken Detroit", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 3;
            // 
            // ChampionSelected
            // 
            this.ChampionSelected.BackColor = System.Drawing.Color.Transparent;
            this.ChampionSelected.Image = global::WindowsFormsApplication1.Properties.Resources.Transparent;
            this.ChampionSelected.Location = new System.Drawing.Point(-3, 1);
            this.ChampionSelected.Name = "ChampionSelected";
            this.ChampionSelected.Size = new System.Drawing.Size(101, 100);
            this.ChampionSelected.TabIndex = 2;
            this.ChampionSelected.TabStop = false;
            // 
            // ChampionsImage
            // 
            this.ChampionsImage.BackColor = System.Drawing.Color.Transparent;
            this.ChampionsImage.Image = global::WindowsFormsApplication1.Properties.Resources.LoLChampsCollage2;
            this.ChampionsImage.Location = new System.Drawing.Point(-3, 1);
            this.ChampionsImage.Name = "ChampionsImage";
            this.ChampionsImage.Size = new System.Drawing.Size(607, 599);
            this.ChampionsImage.TabIndex = 0;
            this.ChampionsImage.TabStop = false;
            this.ChampionsImage.Click += new System.EventHandler(this.ChampionsImage_Click);
            this.ChampionsImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChampionsImage_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LeagueRandomize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChampionSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChampionsImage);
            this.Name = "LeagueRandomize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.LeagueRandomize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChampionSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChampionsImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox ChampionSelected;
        private System.Windows.Forms.PictureBox ChampionSelected2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}