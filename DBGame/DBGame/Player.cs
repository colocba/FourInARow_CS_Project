using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGame
{
    class Player
    {
        public int PlayerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public double PercentageOfWins { get; set; }
        public int points { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
