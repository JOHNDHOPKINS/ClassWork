using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }
    }
}
