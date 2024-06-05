using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Finals
{
    public partial class HowToPlay : Form
    {
        public List<User> users;
        public User currentUser;
        public int incrementTutorial = 0;
        public HowToPlay(User user, List<User> userList)
        {
            InitializeComponent();
            currentUser = user;
            users = userList;
        }
        public void Tutorial()
        {
            switch (incrementTutorial) {
                case 1: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\2.png");
                    btnPrevious.Visible = true;
                    break;
                case 2: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\3.png"); break;
                case 3: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\4.png"); break;
                case 4: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\5.png"); break;
                case 5: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\6.png"); break;
                case 6: pnlTutorial.BackgroundImage = Image.FromFile(@"C:\Users\User\Downloads\7.png");
                    btnNext.Visible = false;
                    btnReturn.Visible = true;
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            incrementTutorial++;
            Tutorial();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            incrementTutorial--;
            Tutorial();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            GameModes gameModes = new GameModes(currentUser,users);
            gameModes.Show();
            Close();
            

        }
        
    } 
}
