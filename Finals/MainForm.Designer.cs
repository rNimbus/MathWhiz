
namespace Finals
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLogIN = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.pbBlock = new System.Windows.Forms.PictureBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameSignup = new System.Windows.Forms.TextBox();
            this.txtPasswordSignup = new System.Windows.Forms.TextBox();
            this.lblUsernameSignup = new System.Windows.Forms.Label();
            this.lblPasswoedSignup = new System.Windows.Forms.Label();
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lklblSignup = new System.Windows.Forms.LinkLabel();
            this.cbShowPassLogin = new System.Windows.Forms.CheckBox();
            this.cbShowPassSignup = new System.Windows.Forms.CheckBox();
            this.lblHAW = new System.Windows.Forms.Label();
            this.lblBWN = new System.Windows.Forms.Label();
            this.lklblBacktoLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogIN
            // 
            this.btnLogIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIN.BackgroundImage")));
            this.btnLogIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogIN.FlatAppearance.BorderSize = 0;
            this.btnLogIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIN.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIN.Location = new System.Drawing.Point(68, 255);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(144, 34);
            this.btnLogIN.TabIndex = 0;
            this.btnLogIN.Text = "Log in";
            this.btnLogIN.UseVisualStyleBackColor = true;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click_1);
            // 
            // btnSignup
            // 
            this.btnSignup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignup.BackgroundImage")));
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Location = new System.Drawing.Point(398, 255);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(144, 34);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click_1);
            // 
            // pbBlock
            // 
            this.pbBlock.BackColor = System.Drawing.Color.Transparent;
            this.pbBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBlock.BackgroundImage")));
            this.pbBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBlock.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbBlock.InitialImage")));
            this.pbBlock.Location = new System.Drawing.Point(301, -1);
            this.pbBlock.Name = "pbBlock";
            this.pbBlock.Size = new System.Drawing.Size(316, 432);
            this.pbBlock.TabIndex = 2;
            this.pbBlock.TabStop = false;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.Plum;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLogin.Location = new System.Drawing.Point(68, 183);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(114, 21);
            this.txtPasswordLogin.TabIndex = 3;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.BackColor = System.Drawing.Color.Plum;
            this.txtUsernameLogin.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUsernameLogin.Location = new System.Drawing.Point(68, 137);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(114, 21);
            this.txtUsernameLogin.TabIndex = 4;
            // 
            // txtUsernameSignup
            // 
            this.txtUsernameSignup.BackColor = System.Drawing.Color.Plum;
            this.txtUsernameSignup.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignup.ForeColor = System.Drawing.Color.White;
            this.txtUsernameSignup.Location = new System.Drawing.Point(398, 137);
            this.txtUsernameSignup.Name = "txtUsernameSignup";
            this.txtUsernameSignup.Size = new System.Drawing.Size(114, 21);
            this.txtUsernameSignup.TabIndex = 5;
            // 
            // txtPasswordSignup
            // 
            this.txtPasswordSignup.BackColor = System.Drawing.Color.Plum;
            this.txtPasswordSignup.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignup.ForeColor = System.Drawing.Color.White;
            this.txtPasswordSignup.Location = new System.Drawing.Point(398, 183);
            this.txtPasswordSignup.Name = "txtPasswordSignup";
            this.txtPasswordSignup.Size = new System.Drawing.Size(114, 21);
            this.txtPasswordSignup.TabIndex = 6;
            this.txtPasswordSignup.UseSystemPasswordChar = true;
            // 
            // lblUsernameSignup
            // 
            this.lblUsernameSignup.AutoSize = true;
            this.lblUsernameSignup.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameSignup.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameSignup.ForeColor = System.Drawing.Color.White;
            this.lblUsernameSignup.Location = new System.Drawing.Point(395, 121);
            this.lblUsernameSignup.Name = "lblUsernameSignup";
            this.lblUsernameSignup.Size = new System.Drawing.Size(62, 15);
            this.lblUsernameSignup.TabIndex = 7;
            this.lblUsernameSignup.Text = "Username";
            // 
            // lblPasswoedSignup
            // 
            this.lblPasswoedSignup.AutoSize = true;
            this.lblPasswoedSignup.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswoedSignup.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswoedSignup.ForeColor = System.Drawing.Color.White;
            this.lblPasswoedSignup.Location = new System.Drawing.Point(395, 167);
            this.lblPasswoedSignup.Name = "lblPasswoedSignup";
            this.lblPasswoedSignup.Size = new System.Drawing.Size(57, 15);
            this.lblPasswoedSignup.TabIndex = 8;
            this.lblPasswoedSignup.Text = "Password";
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLogin.ForeColor = System.Drawing.Color.White;
            this.lblUsernameLogin.Location = new System.Drawing.Point(65, 121);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(62, 15);
            this.lblUsernameLogin.TabIndex = 9;
            this.lblUsernameLogin.Text = "Username";
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblPasswordLogin.Location = new System.Drawing.Point(65, 167);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(57, 15);
            this.lblPasswordLogin.TabIndex = 10;
            this.lblPasswordLogin.Text = "Password";
            // 
            // lklblSignup
            // 
            this.lklblSignup.AutoSize = true;
            this.lklblSignup.BackColor = System.Drawing.Color.Transparent;
            this.lklblSignup.Cursor = System.Windows.Forms.Cursors.No;
            this.lklblSignup.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblSignup.LinkColor = System.Drawing.Color.White;
            this.lklblSignup.Location = new System.Drawing.Point(107, 328);
            this.lklblSignup.Name = "lklblSignup";
            this.lklblSignup.Size = new System.Drawing.Size(49, 15);
            this.lklblSignup.TabIndex = 11;
            this.lklblSignup.TabStop = true;
            this.lklblSignup.Text = "Sign up";
            this.lklblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblSignup_LinkClicked);
            // 
            // cbShowPassLogin
            // 
            this.cbShowPassLogin.AutoSize = true;
            this.cbShowPassLogin.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassLogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.cbShowPassLogin.Location = new System.Drawing.Point(68, 207);
            this.cbShowPassLogin.Name = "cbShowPassLogin";
            this.cbShowPassLogin.Size = new System.Drawing.Size(80, 16);
            this.cbShowPassLogin.TabIndex = 12;
            this.cbShowPassLogin.Text = "Show password";
            this.cbShowPassLogin.UseVisualStyleBackColor = false;
            this.cbShowPassLogin.CheckedChanged += new System.EventHandler(this.cbShowPassLogin_CheckedChanged);
            // 
            // cbShowPassSignup
            // 
            this.cbShowPassSignup.AutoSize = true;
            this.cbShowPassSignup.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassSignup.Font = new System.Drawing.Font("Tempus Sans ITC", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassSignup.ForeColor = System.Drawing.Color.Transparent;
            this.cbShowPassSignup.Location = new System.Drawing.Point(399, 207);
            this.cbShowPassSignup.Name = "cbShowPassSignup";
            this.cbShowPassSignup.Size = new System.Drawing.Size(80, 16);
            this.cbShowPassSignup.TabIndex = 13;
            this.cbShowPassSignup.Text = "Show password";
            this.cbShowPassSignup.UseVisualStyleBackColor = false;
            this.cbShowPassSignup.CheckedChanged += new System.EventHandler(this.cbShowPassSignup_CheckedChanged);
            // 
            // lblHAW
            // 
            this.lblHAW.AutoSize = true;
            this.lblHAW.BackColor = System.Drawing.Color.Transparent;
            this.lblHAW.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHAW.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblHAW.Location = new System.Drawing.Point(340, 42);
            this.lblHAW.Name = "lblHAW";
            this.lblHAW.Size = new System.Drawing.Size(208, 31);
            this.lblHAW.TabIndex = 14;
            this.lblHAW.Text = "Hello Aspiring Wizard";
            // 
            // lblBWN
            // 
            this.lblBWN.AutoSize = true;
            this.lblBWN.BackColor = System.Drawing.Color.Transparent;
            this.lblBWN.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBWN.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblBWN.Location = new System.Drawing.Point(68, 42);
            this.lblBWN.Name = "lblBWN";
            this.lblBWN.Size = new System.Drawing.Size(205, 31);
            this.lblBWN.TabIndex = 15;
            this.lblBWN.Text = "Become a Wizard Now";
            this.lblBWN.Visible = false;
            // 
            // lklblBacktoLogin
            // 
            this.lklblBacktoLogin.AutoSize = true;
            this.lklblBacktoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lklblBacktoLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblBacktoLogin.LinkColor = System.Drawing.Color.White;
            this.lklblBacktoLogin.Location = new System.Drawing.Point(444, 328);
            this.lklblBacktoLogin.Name = "lklblBacktoLogin";
            this.lklblBacktoLogin.Size = new System.Drawing.Size(38, 15);
            this.lklblBacktoLogin.TabIndex = 16;
            this.lklblBacktoLogin.TabStop = true;
            this.lklblBacktoLogin.Text = "Login";
            this.lklblBacktoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblBacktoLogin_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 374);
            this.Controls.Add(this.lblBWN);
            this.Controls.Add(this.lblHAW);
            this.Controls.Add(this.pbBlock);
            this.Controls.Add(this.lklblSignup);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblPasswoedSignup);
            this.Controls.Add(this.lblUsernameSignup);
            this.Controls.Add(this.txtPasswordSignup);
            this.Controls.Add(this.txtUsernameSignup);
            this.Controls.Add(this.cbShowPassLogin);
            this.Controls.Add(this.cbShowPassSignup);
            this.Controls.Add(this.lklblBacktoLogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Plum;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.PictureBox pbBlock;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.TextBox txtUsernameSignup;
        private System.Windows.Forms.TextBox txtPasswordSignup;
        private System.Windows.Forms.Label lblUsernameSignup;
        private System.Windows.Forms.Label lblPasswoedSignup;
        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.LinkLabel lklblSignup;
        private System.Windows.Forms.CheckBox cbShowPassLogin;
        private System.Windows.Forms.CheckBox cbShowPassSignup;
        private System.Windows.Forms.Label lblHAW;
        private System.Windows.Forms.Label lblBWN;
        private System.Windows.Forms.LinkLabel lklblBacktoLogin;
    }
}
