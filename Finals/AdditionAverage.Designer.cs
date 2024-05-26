
namespace Finals
{
	partial class AdditionAverage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionAverage));
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbAnswer = new System.Windows.Forms.TextBox();
            this.EqualSign = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.TimerEasy = new System.Windows.Forms.Timer(this.components);
            this.AdditionSign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.ForeColor = System.Drawing.Color.Khaki;
            this.lblAnswer.Location = new System.Drawing.Point(282, -1);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(207, 96);
            this.lblAnswer.TabIndex = 26;
            this.lblAnswer.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Khaki;
            this.lblTimer.Location = new System.Drawing.Point(678, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(132, 85);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "10";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Khaki;
            this.lblScore.Location = new System.Drawing.Point(31, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(161, 85);
            this.lblScore.TabIndex = 24;
            this.lblScore.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(489, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // txbAnswer
            // 
            this.txbAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(48)))), ((int)(((byte)(165)))));
            this.txbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnswer.ForeColor = System.Drawing.Color.Khaki;
            this.txbAnswer.Location = new System.Drawing.Point(480, 171);
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.Size = new System.Drawing.Size(201, 83);
            this.txbAnswer.TabIndex = 22;
            this.txbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbAnswerKeyDown);
            // 
            // EqualSign
            // 
            this.EqualSign.BackColor = System.Drawing.Color.Transparent;
            this.EqualSign.Font = new System.Drawing.Font("Viner Hand ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualSign.ForeColor = System.Drawing.Color.Khaki;
            this.EqualSign.Location = new System.Drawing.Point(410, 171);
            this.EqualSign.Name = "EqualSign";
            this.EqualSign.Size = new System.Drawing.Size(72, 86);
            this.EqualSign.TabIndex = 21;
            this.EqualSign.Text = "=";
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Viner Hand ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Khaki;
            this.lblNum1.Location = new System.Drawing.Point(93, 171);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(114, 86);
            this.lblNum1.TabIndex = 18;
            this.lblNum1.Text = "0";
            // 
            // lblNum2
            // 
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Viner Hand ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Khaki;
            this.lblNum2.Location = new System.Drawing.Point(277, 171);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(167, 86);
            this.lblNum2.TabIndex = 19;
            this.lblNum2.Text = "0";
            // 
            // TimerEasy
            // 
            this.TimerEasy.Enabled = true;
            this.TimerEasy.Interval = 1000;
            this.TimerEasy.Tick += new System.EventHandler(this.TimerEasyTick);
            // 
            // AdditionSign
            // 
            this.AdditionSign.BackColor = System.Drawing.Color.Transparent;
            this.AdditionSign.Font = new System.Drawing.Font("Viner Hand ITC", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionSign.ForeColor = System.Drawing.Color.Khaki;
            this.AdditionSign.Location = new System.Drawing.Point(199, 171);
            this.AdditionSign.Name = "AdditionSign";
            this.AdditionSign.Size = new System.Drawing.Size(72, 86);
            this.AdditionSign.TabIndex = 20;
            this.AdditionSign.Text = "+";
            // 
            // AdditionAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 403);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbAnswer);
            this.Controls.Add(this.EqualSign);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.AdditionSign);
            this.Name = "AdditionAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdditionAverage";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label AdditionSign;
		private System.Windows.Forms.Timer TimerEasy;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label EqualSign;
		private System.Windows.Forms.TextBox txbAnswer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Label lblAnswer;
	}
}
