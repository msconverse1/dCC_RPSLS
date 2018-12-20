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
        public GameLogic(string gameMode)
        {
            Hand = new List<string>() { "Rock", "Paper", "Scissors","Lizard","Spock" };
            player1 = new Player("Darkham", 0);
            if(gameMode == "multiplayer")
            {
                player2 = new Player("Logan",0);
            }
            else
            {
                player2 = new AI();
            }
            player1.Guestures(Hand);
            player2.Guestures(Hand);
        }
        public void CheckAgainstList(string p1,string p2)
        {
            switch (p1)
            {
                case "Rock":
                    //other player choose,what guesture wins against Rock,what guesture wins against Rock,what loses against Rock,what loses against Rock
                    ShortCheck(p2, Hand[2], Hand[3], Hand[1], Hand[4]);
                    break;
                case "Paper":
                    //other player choose,what guesture wins against Paper,what guesture wins against Paper,what loses against Paper,what loses against Paper
                    ShortCheck(p2, Hand[0], Hand[4], Hand[2], Hand[3]);
                    break;
                case "Scissors":
                    //other player choose,what guesture wins against Scissors,what guesture wins against Scissors,what loses against Scissors,what loses against Scissors
                    ShortCheck(p2, Hand[1], Hand[3], Hand[0], Hand[4]);
                    break;
                case "Lizard":
                    //other player choose,what guesture wins against Lizard,what guesture wins against Lizard,what loses against Lizard,what loses against Lizard
                    ShortCheck(p2, Hand[4], Hand[1], Hand[2], Hand[0]);
                    break;
                case "Spock":
                    //other player choose,what guesture wins against Spock,what guesture wins against Spock,what loses against Spock,what loses against Spock
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
        public void GameScore(Player user,Player test)
        {
            Console.WriteLine(player1.name + " score: " + player1.score);
            Console.WriteLine(player2.name + " score: " + player2.score);
        }
        public void GameOver(Player user,Player test, int rounds)
        {
            if(user.score == rounds && test.score == rounds)
            {
                Console.WriteLine("There is no Winner!");
            }
           else if (user.score == rounds)
            {
                Console.WriteLine($"IS the Winner!!!: {user.name}");
            }
            else if(test.score == rounds)
            {
                Console.WriteLine($"IS the Winner!!!: {test.name}");
            }
        }
    }
}
