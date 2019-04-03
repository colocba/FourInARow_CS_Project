using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGame
{
    class Game
    {
        public int GameId { get; set; }
        public string YellowPlayer { get; set; }
        public string RedPlayer { get; set; }
        public string Winner { get; set; }
        public int GamePoints { get; set; }
        public DateTime? GameStarted { get; set; }
        public bool Active { get; set; }
    }
}
