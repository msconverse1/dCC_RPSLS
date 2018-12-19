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
        public Player player2;
        public GameLogic()
        {
            Hand = new List<string>() { "Rock", "Paper", "Scissors","Lizard","Spock" };
            player1 = new Player("Darkham", 0);
            player2 = new Player("Frank", 0);
        }
        public void CheckAgainstList(string p1,string p2)
        {
            
            switch (p1)
            {
                case "Rock":
                    if(p2 == "Scissors"|| p2 == "Lizard")
                    {
                        Console.WriteLine(player1.name + "Beats" + player2.name);
                        player1.score++;
                    }
                    else if(p2 == "Paper"|| p2 == "Spock")
                    {
                        Console.WriteLine(player2.name + " Beats " + player1.name);
                        player2.score++;
                    }
                    else
                    {
                        Console.WriteLine(player1.name + "Ties" + player2.name);
                    }
                    break;
                case "Paper":
                    break;
                case "Scissors":
                    break;
                case "Lizard":
                    break;
                case "Spock":
                    break;
                    
                    
            }
        }

        
    }
}
