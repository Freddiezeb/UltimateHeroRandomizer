namespace WindowsFormsApplication1
{
    partial class League
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(League));
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.MinigamesButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(209, 136);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
            this.RandomizeButton.TabIndex = 0;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // MinigamesButton
            // 
            this.MinigamesButton.Location = new System.Drawing.Point(209, 180);
            this.MinigamesButton.Name = "MinigamesButton";
            this.MinigamesButton.Size = new System.Drawing.Size(75, 23);
            this.MinigamesButton.TabIndex = 1;
            this.MinigamesButton.Text = "Minigames";
            this.MinigamesButton.UseVisualStyleBackColor = true;
            this.MinigamesButton.Click += new System.EventHandler(this.MinigamesButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(209, 227);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // League
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(488, 432);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MinigamesButton);
            this.Controls.Add(this.RandomizeButton);
            this.Name = "League";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button MinigamesButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}