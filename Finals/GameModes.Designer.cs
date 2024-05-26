
namespace Finals
{
	partial class GameModes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameModes));
            this.btnGM1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGM1
            // 
            this.btnGM1.BackColor = System.Drawing.Color.Transparent;
            this.btnGM1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGM1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGM1.FlatAppearance.BorderSize = 0;
            this.btnGM1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGM1.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGM1.ForeColor = System.Drawing.Color.Khaki;
            this.btnGM1.Location = new System.Drawing.Point(97, 148);
            this.btnGM1.Name = "btnGM1";
            this.btnGM1.Size = new System.Drawing.Size(211, 113);
            this.btnGM1.TabIndex = 0;
            this.btnGM1.Text = "PLAY";
            this.btnGM1.UseVisualStyleBackColor = false;
            this.btnGM1.Click += new System.EventHandler(this.Button1Click);
            // 
            // GameModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 403);
            this.Controls.Add(this.btnGM1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameModes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameModes";
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnGM1;
    }
}
