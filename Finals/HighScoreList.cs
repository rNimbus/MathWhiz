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
using Finals;

namespace Finals
{
    public partial class HighScoreList : Form
    {
        public string UsersFilePath = @"C:\Users\User\Documents\MathWhiz.json";
        public List<User> users;
        public User currentUser;
        public HighScoreList()
        {
            InitializeComponent();
            LoadHighScores();
            PopulateComboBoxes();
            CBChoicesOperations.SelectedIndexChanged += (s, e) => DisplayHighScores();
            CBDifficulties.SelectedIndexChanged += (s, e) => DisplayHighScores();
        }
        private void LoadHighScores()
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

        private void PopulateComboBoxes()
        {
            CBChoicesOperations.Items.AddRange(new string[] { "Addition", "Subtraction", "Multiplication", "Division" });
            CBChoicesOperations.SelectedIndex = 0;

            CBDifficulties.Items.AddRange(new string[] { "Easy", "Average", "Hard" });
            CBDifficulties.SelectedIndex = 0;
        }

        private void DisplayHighScores()
        {
            ClearLabels();

            string selectedOperation = CBChoicesOperations.SelectedItem.ToString();
            string selectedDifficulty = CBDifficulties.SelectedItem.ToString();

            var highScores = users
                .Select(u => new
                {
                    u.Username,
                    Score = u.HighScores.ContainsKey(selectedOperation) &&
                            u.HighScores[selectedOperation].ContainsKey(selectedDifficulty)
                            ? u.HighScores[selectedOperation][selectedDifficulty]
                            : 0
                })
                .OrderByDescending(u => u.Score)
                .ToList();

            for (int i = 0; i < 10; i++)
            {
                
                
                Label lblUsernameEntry = new Label
                {
                    Text = (i+1)+". "+highScores[i].Username,
                    ForeColor = Color.DarkMagenta,
                    Font = new Font("Viner Hand ITC", 12),
                    AutoSize = false,
                    Width = pnlUsername.Width,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(1, lblUsername.Bottom + 25 * (i + 1))
                };
                pnlUsername.Controls.Add(lblUsernameEntry);

                Label lblScoreEntry = new Label
                {
                    Text = highScores[i].Score.ToString(),
                    ForeColor = Color.DarkMagenta,
                    Font = new Font("Viner Hand ITC", 12),
                    AutoSize = false,
                    Width = pnlScore.Width,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(1, lblScore.Bottom + 25 * (i + 1))
                };
                if (i < 0)
                {
                    lblUsernameEntry.Location = new Point(1, lblUsername.Bottom);
                }
                pnlScore.Controls.Add(lblScoreEntry);
                
            }
            
        }

        private void ClearLabels()
        {
            foreach (var control in pnlUsername.Controls.OfType<Label>().ToArray())
            {
                if (control != lblUsername)
                {
                    pnlUsername.Controls.Remove(control);
                }
            }

            foreach (var control in pnlScore.Controls.OfType<Label>().ToArray())
            {
                if (control != lblScore)
                {
                    pnlScore.Controls.Remove(control);
                }
            }
        }

        
    }


}

