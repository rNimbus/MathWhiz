
namespace Finals
{
	partial class Result
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.button1 = new System.Windows.Forms.Button();
            this.lblYHS = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblScoreLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(225, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // lblYHS
            // 
            this.lblYHS.AutoSize = true;
            this.lblYHS.BackColor = System.Drawing.Color.Transparent;
            this.lblYHS.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYHS.ForeColor = System.Drawing.Color.Khaki;
            this.lblYHS.Location = new System.Drawing.Point(225, 165);
            this.lblYHS.Name = "lblYHS";
            this.lblYHS.Size = new System.Drawing.Size(124, 14);
            this.lblYHS.TabIndex = 3;
            this.lblYHS.Text = "Current High Score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Khaki;
            this.lblHighScore.Location = new System.Drawing.Point(270, 196);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 23);
            this.lblHighScore.TabIndex = 4;
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalScore.Font = new System.Drawing.Font("Perpetua", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.Color.Khaki;
            this.lblFinalScore.Location = new System.Drawing.Point(205, 67);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(0, 46);
            this.lblFinalScore.TabIndex = 6;
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreLetter
            // 
            this.lblScoreLetter.AutoSize = true;
            this.lblScoreLetter.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreLetter.Font = new System.Drawing.Font("Monotype Corsiva", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLetter.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblScoreLetter.Location = new System.Drawing.Point(43, 34);
            this.lblScoreLetter.Name = "lblScoreLetter";
            this.lblScoreLetter.Size = new System.Drawing.Size(0, 97);
            this.lblScoreLetter.TabIndex = 7;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 347);
            this.Controls.Add(this.lblScoreLetter);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblYHS);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblYHS;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblScoreLetter;
    }
}
