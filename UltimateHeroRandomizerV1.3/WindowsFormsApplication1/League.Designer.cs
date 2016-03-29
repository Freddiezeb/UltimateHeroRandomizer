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
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.MinigamesButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.BackColor = System.Drawing.Color.Transparent;
            this.RandomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RandomizeButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomizeButton.ForeColor = System.Drawing.Color.White;
            this.RandomizeButton.Location = new System.Drawing.Point(761, 219);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(231, 80);
            this.RandomizeButton.TabIndex = 0;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = false;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // MinigamesButton
            // 
            this.MinigamesButton.BackColor = System.Drawing.Color.Transparent;
            this.MinigamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinigamesButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinigamesButton.ForeColor = System.Drawing.Color.White;
            this.MinigamesButton.Location = new System.Drawing.Point(761, 316);
            this.MinigamesButton.Name = "MinigamesButton";
            this.MinigamesButton.Size = new System.Drawing.Size(231, 80);
            this.MinigamesButton.TabIndex = 1;
            this.MinigamesButton.Text = "Minigames";
            this.MinigamesButton.UseVisualStyleBackColor = false;
            this.MinigamesButton.Click += new System.EventHandler(this.MinigamesButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(761, 413);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(231, 80);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // League
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.lolmeny3;
            this.ClientSize = new System.Drawing.Size(1195, 803);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.MinigamesButton);
            this.Controls.Add(this.RandomizeButton);
            this.Name = "League";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League";
            this.Load += new System.EventHandler(this.League_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button MinigamesButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}