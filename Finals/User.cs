using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finals
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, Dictionary<string, int>> HighScores { get; set; }

        public User()
        {
            HighScores = new Dictionary<string, Dictionary<string, int>>
        {
            { "Addition", new Dictionary<string, int> { { "Easy", 0 }, { "Average", 0 }, { "Hard", 0 } } },
            { "Subtraction", new Dictionary<string, int> { { "Easy", 0 }, { "Average", 0 }, { "Hard", 0 } } },
            { "Multiplication", new Dictionary<string, int> { { "Easy", 0 }, { "Average", 0 }, { "Hard", 0 } } },
            { "Division", new Dictionary<string, int> { { "Easy", 0 }, { "Average", 0 }, { "Hard", 0 } } }
        };
        }
    }
}
