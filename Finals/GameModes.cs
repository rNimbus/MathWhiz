
using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Finals;
using System.Media;

namespace Finals
{
	public partial class GameModes : Form
	{
		public User currentUser;
		public List<User> users;
		
		public GameModes(User user, List<User> userList)
		{
			InitializeComponent();
			currentUser = user;
			users = userList;
		}

   
        
		void Button1Click(object sender, EventArgs e)
		{
			Difficuties_ChoicesGM1 diffChoiceGM1 = new Difficuties_ChoicesGM1(currentUser, users);
			diffChoiceGM1.Show();
			this.Hide();
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			HowToPlay howToPlay = new HowToPlay(currentUser,users);
			howToPlay.Show();
			SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
			HighScoreList highScoreList = new HighScoreList();
			highScoreList.Show();
        }
    }
}
