namespace UltimateHeroRandomizerV3
{
    partial class Highscore
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
            this.sp_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sp_label = new System.Windows.Forms.Label();
            this.sp_buttonUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_dataGridView1
            // 
            this.sp_dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sp_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.sp_dataGridView1.Name = "sp_dataGridView1";
            this.sp_dataGridView1.Size = new System.Drawing.Size(241, 296);
            this.sp_dataGridView1.TabIndex = 0;
            // 
            // sp_label
            // 
            this.sp_label.AutoSize = true;
            this.sp_label.Location = new System.Drawing.Point(56, 123);
            this.sp_label.Name = "sp_label";
            this.sp_label.Size = new System.Drawing.Size(61, 13);
            this.sp_label.TabIndex = 1;
            this.sp_label.Text = "SlidePuzzle";
            // 
            // sp_buttonUpdate
            // 
            this.sp_buttonUpdate.Location = new System.Drawing.Point(43, 450);
            this.sp_buttonUpdate.Name = "sp_buttonUpdate";
            this.sp_buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.sp_buttonUpdate.TabIndex = 2;
            this.sp_buttonUpdate.Text = "Update";
            this.sp_buttonUpdate.UseVisualStyleBackColor = true;
            this.sp_buttonUpdate.Click += new System.EventHandler(this.sp_buttonUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sp_buttonUpdate);
            this.Controls.Add(this.sp_label);
            this.Controls.Add(this.sp_dataGridView1);
            this.Name = "Highscore";
            this.Text = "Highscore";
            ((System.ComponentModel.ISupportInitialize)(this.sp_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sp_dataGridView1;
        private System.Windows.Forms.Label sp_label;
        private System.Windows.Forms.Button sp_buttonUpdate;
        private System.Windows.Forms.Button button1;
    }
}