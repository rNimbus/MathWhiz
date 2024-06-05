
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Finals;
using System.Media;

namespace Finals
{
	/// <summary>
	/// Description of DivisionEasy.
	/// </summary>
	public partial class DivisionEasy : Form
	{
		public User currentUser;
		public List<User> users;
		public const string UsersFilePath = @"C:\Users\User\Documents\MathWhiz.json";
		public Random random;
		public int score = 0;
		public int scoreLimit = 100;
		public int changeTime = 10;

		public string gameMode = "Division";
		public string difficulty = "Easy";

		public SoundPlayer rightAns = new SoundPlayer(@"C:\Users\User\Downloads\success_02-68338 (1).wav");
		public SoundPlayer wrongAns = new SoundPlayer(@"C:\Users\User\Downloads\wronganswer-37702.wav");

		public DivisionEasy(User user, List<User> userList, string difficulty)
		{
			InitializeComponent();
			random = new Random();
			currentUser = user;
			users = userList;
			RandomGen();
		}

        

        void Button1Click(object sender, EventArgs e)
		{
			ValidateAnswer();
			txbAnswer.Focus();
		}
		
		void TxbAnswerKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				ValidateAnswer();
				e.SuppressKeyPress = true;
			}
		}
		
		public void ValidateAnswer(){
			string correctAnswer = lblAnswer.Text;
		    string userAnswer = txbAnswer.Text;
		
		    if (correctAnswer == userAnswer)
		        {
					rightAns.Play();
		            RandomGen();
		        	txbAnswer.ResetText();
		        	ScoreAdd();
		        	lblTimer.Text = Convert.ToString(changeTime);
		        }
		        else
		        {
					wrongAns.Play();
		            txbAnswer.ResetText();
		        }
		}
		public void RandomGen(){
	        int num1val = random.Next(1, 20);
		    int num2val = random.Next(1, 10);
		    
		    while (num1val % num2val != 0)
		    {
		        num1val = random.Next(1, 30);
		        num2val = random.Next(1, 10);
  			}

			    lblNum1.Text = num1val.ToString();
			    lblNum2.Text = num2val.ToString();
			
			    int answer = num1val / num2val;
			
			    lblAnswer.Text = answer.ToString();
			
		}
		public void ScoreAdd(){
			int prevLimit = 0;
			int addto = scoreLimit/10;
			if(score<scoreLimit && score>=prevLimit){
				int addScore = addto + score ;
				lblScore.Text= Convert.ToString(addScore);
				score = addScore;
			}
			
			if (score >= scoreLimit){
					prevLimit= prevLimit+ scoreLimit;
					scoreLimit= scoreLimit + 100;
					
					if (changeTime>2){
						changeTime = changeTime - 1;
					}
				}
		}
		
		void TimerEasyTick(object sender, EventArgs e)
		{
			switch (lblTimer.Text) {
				case "10" :lblTimer.Text ="9"; break;
				case "9" :lblTimer.Text ="8"; break;
				case "8" :lblTimer.Text ="7"; break;
				case "7" :lblTimer.Text ="6"; break;
				case "6" :lblTimer.Text ="5"; break;
				case "5" :lblTimer.Text ="4"; break;
				case "4" :lblTimer.Text ="3"; break;
				case "3" :lblTimer.Text ="2"; break;
				case "2" :lblTimer.Text ="1"; break;
				case "1" :lblTimer.Text ="0"; break;
			}
			if (lblTimer.Text == "0"){
				TimerEasy.Stop();
				SaveHighScore();
				Result result = new Result(currentUser, users, gameMode, difficulty, score);
				result.Show();
				Close();
			}
		}
		public void BackgroundMusic()
		{
			SoundPlayer bgMUsic = new SoundPlayer(@"C:\Users\User\Downloads\suits-you-69233.wav");
			bgMUsic.Play();
		}
		private void SaveHighScore()
		{
			if (!currentUser.HighScores.ContainsKey("Division") ||
					!currentUser.HighScores["Division"].ContainsKey(difficulty) ||
					score > currentUser.HighScores["Division"][difficulty])
			{
				currentUser.HighScores["Division"][difficulty] = score;
				SaveUsers();
			}
		}

		private void SaveUsers()
		{
			string json = JsonConvert.SerializeObject(users, Formatting.Indented);
			File.WriteAllText(UsersFilePath, json);
		}
	}
}
