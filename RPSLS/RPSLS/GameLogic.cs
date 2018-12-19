using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameLogic
    {
        public List<string> Hand;
        public Player player1;
        public GameLogic()
        {
            Hand = new List<string>() { "Rock", "Paper", "Scissors","Lizard","Spock" };
            player1 = new Player("Darkham", 0);

        }

        
    }
}
