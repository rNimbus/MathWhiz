
using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Finals;

namespace Finals
{
	/// <summary>
	/// Description of Result.
	/// </summary>
	public partial class Result : Form
	{
		private User currentUser;
        public List<User> users;
        private string gameMode;
		private string difficulty;
		private int finalScore;
		public Result(User user, List<User> userList, string gameMode, string difficulty, int score)
		{
			InitializeComponent();
			InitializeComponent();
			currentUser = user;
            users = userList;
            this.gameMode = gameMode;
			this.difficulty = difficulty;
			this.finalScore = score;
			DisplayScores();
			



		}


        public void DisplayScores()
		{
			// Display the final score
			lblFinalScore.Text =  $"Score: {finalScore}";

			// Display the high score for the current game mode and difficulty
			if (currentUser.HighScores.ContainsKey(gameMode) &&
				currentUser.HighScores[gameMode].ContainsKey(difficulty))
			{
				lblHighScore.Text = $" {currentUser.HighScores[gameMode][difficulty]}";
			}
			else
			{
				lblHighScore.Text = "High Score: 0";
			}

			if (finalScore > 800)
			{
				lblScoreLetter.Text = "S";
			}
			else if (finalScore > 600)
			{
				lblScoreLetter.Text = "A";
			}
			else if (finalScore > 500)
			{
				lblScoreLetter.Text = "B";
			}
			else if (finalScore > 400)
			{
				lblScoreLetter.Text = "C";
			}
			else if (finalScore > 300)
			{
				lblScoreLetter.Text = "D";
			}
			else if (finalScore > 200)
			{
				lblScoreLetter.Text = "E";
			}
			else if (finalScore < 200)
			{
				lblScoreLetter.Text = "F";
			}
		}

	
		void Button1Click(object sender, EventArgs e)
		{
			GameModes gmReturn = new GameModes(currentUser, users);
			gmReturn.Show();
			Close();
		}

        
    }
}
