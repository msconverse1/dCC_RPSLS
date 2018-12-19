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
        public AI player2;
        public GameLogic()
        {
            Hand = new List<string>() { "Rock", "Paper", "Scissors","Lizard","Spock" };
            player1 = new Player("Darkham", 0);
            player2 = new AI();
        }
        public void CheckAgainstList(string p1,string p2)
        {
            switch (p1)
            {
                case "Rock":
                    ShortCheck(p2, Hand[2], Hand[3], Hand[1], Hand[4]);
                    break;
                case "Paper":
                    ShortCheck(p2, Hand[0], Hand[4], Hand[2], Hand[3]);
                    break;
                case "Scissors":
                    ShortCheck(p2, Hand[1], Hand[3], Hand[0], Hand[4]);
                    break;
                case "Lizard":
                    ShortCheck(p2, Hand[4], Hand[1], Hand[2], Hand[0]);
                    break;
                case "Spock":
                    ShortCheck(p2, Hand[2], Hand[0],Hand[3],Hand[1]);
                    break;
            }
        }
        public void ShortCheck(string p2, string Win,string win, string Lose, string lose)
        {
            if (p2 == Win || p2 == win)
            {
                Console.WriteLine(player1.name + " Beats " + player2.name);
                player1.score++;
            }
            else if (p2 == Lose || p2 == lose)
            {
                Console.WriteLine(player2.name + " Beats " + player1.name);
                player2.score++;
            }
            else
            {
                Console.WriteLine(player1.name + " Ties " + player2.name);
            }
        }
    }
}
