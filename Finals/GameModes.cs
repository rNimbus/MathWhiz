
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
		public SoundPlayer bgmusic = new SoundPlayer(@"C:\Users\User\Downloads\suits-you-69233.wav");
		public GameModes(User user, List<User> userList)
		{
			InitializeComponent();
			currentUser = user;
			users = userList;
			bgmusic.Play();
		}

   
        
		void Button1Click(object sender, EventArgs e)
		{
			Difficuties_ChoicesGM1 diffChoiceGM1 = new Difficuties_ChoicesGM1(currentUser, users);
			diffChoiceGM1.Show();
			this.Hide();
		}
		
		
	}
}
