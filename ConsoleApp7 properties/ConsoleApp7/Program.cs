using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Frankenstein") { Score = 100, LivesLeft = 7 };
        }
        private int score;

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}
