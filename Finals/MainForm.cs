
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Finals;


namespace Finals
{
	public partial class MainForm : Form
	{
        public string UsersFilePath = @"C:\Users\User\Documents\MathWhiz.json";
        public List<User> users;
        public User currentUser;
        public string gmUsername;

        public MainForm()
        {
            InitializeComponent();
            LoadUsers();
            
        }

        public void LoadUsers()
        {
            if (File.Exists(UsersFilePath))
            {
                string json = File.ReadAllText(UsersFilePath);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            else
            {
                users = new List<User>();
            }
        }

        public void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users);
            File.WriteAllText(UsersFilePath, json);
        }
      
        public void lklblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			pbBlock.Location = new Point(1,-1); ;
            pbBlock.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\wizardfliped.png");
            lblBWN.Visible = true;
            lblHAW.Visible = false;

        }

        private void lklblBacktoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbBlock.Location = new Point(301, -1);
            pbBlock.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\Untitled_design__2_-removebg-preview.png");
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            lblBWN.Visible = false;
            lblHAW.Visible = true;
        }

        public void btnLogIN_Click_1(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;
            
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                currentUser = user;
                GameModes gameModes = new GameModes(currentUser,users);
                gameModes.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        public void btnSignup_Click_1(object sender, EventArgs e)
        {
            string username = txtUsernameSignup.Text;
            string password = txtPasswordSignup.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (users.Any(u => u.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose another one.");
                return;
            }
            if (txtPasswordSignup.Text.Length < 8 || txtUsernameSignup.Text.Length < 8 || txtPasswordSignup.Text.Length > 16 || txtUsernameSignup.Text.Length > 16) 
            {
                MessageBox.Show("Please enter 8 to 16 character only");
                return;
            }
            if (txtPasswordSignup.Text != txtConfirmPassword.Text) 
            {
                MessageBox.Show("The entered password doed not match");
                return;
            }
           

            var newUser = new User { Username = username, Password = password };
            users.Add(newUser);
            SaveUsers();
            pbBlock.Location = new Point(301, -1);
            pbBlock.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\Untitled_design__2_-removebg-preview.png");
            txtUsernameSignup.Clear();
            txtPasswordSignup.Clear();
            lblBWN.Visible = false;
            lblHAW.Visible = true;
            MessageBox.Show("Sign up successful!");
            

        }

        private void cbShowPassLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPasswordLogin.UseSystemPasswordChar == false)
            {
                txtPasswordLogin.UseSystemPasswordChar = true;
            }
            else {
                txtPasswordLogin.UseSystemPasswordChar = false;
            }   
            


        }

        private void cbShowPassSignup_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPasswordSignup.UseSystemPasswordChar == false)
            {
                txtPasswordSignup.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordSignup.UseSystemPasswordChar = false;
            }
        }

       

        
    }
}
