
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Finals;
namespace Finals
{
	/// <summary>
	/// Description of Difficuties_ChoicesGM1.
	/// </summary>
	public partial class Difficuties_ChoicesGM1 : Form
	{
		public User currentUser;
		public List<User> users;
		public const string UsersFilePath = @"C:\Users\User\Documents\MathWhiz.json";
		public Difficuties_ChoicesGM1(User user, List<User> userList)
		{
			
			InitializeComponent();
			currentUser = user;
			users = userList;

		}

        

        void Difficuties_ChoicesGM1FormClosed(object sender, FormClosedEventArgs e)
		{
			GameModes GM = new GameModes(currentUser, users);
			GM.Show();
			SetVisibleCore(false);
		}
		// Addition Events//
		void BtnAddtionClick(object sender, EventArgs e)
		{
			lblAddBlk.Visible = false;
			lblSubBlk.Visible = true;
			lblMultiBlk.Visible = true;
			lblDivBlk.Visible =true;
			pnlBigWiz.Visible = false;
			
		}
		
		void BtnAdditionEasyClick(object sender, EventArgs e)
		{
			Addition addForm = new Addition(currentUser, users, "Easy");
			addForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnAdditionAverageClick(object sender, EventArgs e)
		{
			AdditionAverage addAform = new AdditionAverage(currentUser, users, "Average");
			addAform.Show();
			SetVisibleCore(false);
		}
	
		void BtnAdditionHardClick(object sender, EventArgs e)
		{
			AdditionHard addHform = new AdditionHard(currentUser, users, "Hard");
			addHform.Show();
			SetVisibleCore(false);
		}
		
		//////////////////////////////////////////////////////////////////////////
		
		//Subtraction Events
		
		void BtnSubtractionClick(object sender, EventArgs e)
		{
			lblSubBlk.Visible = false;
			lblAddBlk.Visible = true;
			lblMultiBlk.Visible = true;
			lblDivBlk.Visible =true;
			pnlBigWiz.Visible = false;
		}
		
		
		void BtnSubEasyClick(object sender, EventArgs e)
		{
			SubtractionEasy subForm = new SubtractionEasy(currentUser, users, "Easy");
			subForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnSubAveClick(object sender, EventArgs e)
		{
			SubtractionAverage subForm = new SubtractionAverage(currentUser, users, "Average");
			subForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnSubHardClick(object sender, EventArgs e)
		{
			SubtractionHArd subForm = new SubtractionHArd(currentUser, users, "Hard");
			subForm.Show();
			SetVisibleCore(false);
		}
		//////////////////////////////////////////////////////////////////////////////
	
		//Multiplication Events
		
		
		
		void BtnMultiplicationClick(object sender, EventArgs e)
		{
			lblMultiBlk.Visible = false;
			lblSubBlk.Visible = true;
			lblAddBlk.Visible = true;
			lblDivBlk.Visible =true;
			pnlBigWiz.Visible = false;
		}
		
		void BtnMultiEasyClick(object sender, EventArgs e)
		{
			MultiplicationEasy multiForm = new MultiplicationEasy(currentUser, users, "Easy");
			multiForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnMultiAveClick(object sender, EventArgs e)
		{
			MultiplicationAverage multiForm = new MultiplicationAverage(currentUser, users, "Average");
			multiForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnMultiHardClick(object sender, EventArgs e)
		{
			MultiplicationHard multiForm = new MultiplicationHard(currentUser, users, "Hard");
			multiForm.Show();
			SetVisibleCore(false);
		}
		//////////////////////////////////////////////////////////////////////////////
		
		//Division Events
		
		void BtnDivisionClick(object sender, EventArgs e)
		{
			lblDivBlk.Visible = false;
			lblSubBlk.Visible = true;
			lblAddBlk.Visible = true;
			lblMultiBlk.Visible = true;
			pnlBigWiz.Visible = false;

		}
		
		void BtnDivEasyClick(object sender, EventArgs e)
		{
			DivisionEasy divForm = new DivisionEasy(currentUser, users, "Easy");
			divForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnDivAveClick(object sender, EventArgs e)
		{
			DivisionAverage divForm = new DivisionAverage(currentUser, users, "Average");
			divForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnDivHardClick(object sender, EventArgs e)
		{
			DivisionHard divForm = new DivisionHard(currentUser, users, "Hard");
			divForm.Show();
			SetVisibleCore(false);
		}

        






        /////////////////////////////////////////////////////////////////////////////////
    }
}
