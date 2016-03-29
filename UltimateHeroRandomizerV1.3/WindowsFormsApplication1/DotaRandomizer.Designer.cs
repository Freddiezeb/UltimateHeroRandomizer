namespace WindowsFormsApplication1
{
    partial class DotaRandomizer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HeroSelected = new System.Windows.Forms.PictureBox();
            this.HeroesImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeroSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hero Name";
            // 
            // HeroSelected
            // 
            this.HeroSelected.Image = global::WindowsFormsApplication1.Properties.Resources.Transparent;
            this.HeroSelected.Location = new System.Drawing.Point(-1, 0);
            this.HeroSelected.Name = "HeroSelected";
            this.HeroSelected.Size = new System.Drawing.Size(45, 50);
            this.HeroSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeroSelected.TabIndex = 1;
            this.HeroSelected.TabStop = false;
            this.HeroSelected.Click += new System.EventHandler(this.HeroSelected_Click);
            // 
            // HeroesImage
            // 
            this.HeroesImage.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.dota2test6;
            this.HeroesImage.Location = new System.Drawing.Point(-1, 0);
            this.HeroesImage.Name = "HeroesImage";
            this.HeroesImage.Size = new System.Drawing.Size(271, 311);
            this.HeroesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroesImage.TabIndex = 0;
            this.HeroesImage.TabStop = false;
            this.HeroesImage.Click += new System.EventHandler(this.HeroesImage_Click);
            this.HeroesImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HeroesImage_MouseClick);
            // 
            // DotaRandomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HeroSelected);
            this.Controls.Add(this.HeroesImage);
            this.Name = "DotaRandomizer";
            this.Text = "DotaRandomizer";
            ((System.ComponentModel.ISupportInitialize)(this.HeroSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroesImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeroSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HeroesImage;
    }
}