using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameLogic
    {
        //private by defualt
        //Variables
        public List<string> Hand;
        public User player1;
        public User player2;
        public int rounds = 0;
        public GameLogic()
        {
            Hand = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            string input = AskForGameType("");
                     rounds = AskForRounds();
            if (input == "multiplayer")
            {
                player1 = new Player("Darkham", 0,Hand);
                player2 = new Player("Logan", 0,Hand);
            }
            else if(input == "ai")
            {
                player1 = new AI(Hand);
                player2 = new AI(Hand);
            }
            else
            {
                player1 = new Player("Darkham", 0, Hand);
                player2 = new AI(Hand);
            }
        }

        public void PlayGame()
        {
           
            while (player1.score < rounds && player2.score < rounds)
            {
                GameScore(player1, player2);
                Console.WriteLine("\n" + player1.name + " Turn.\n");
                string input =player1.IsVaildChoice(player1.AskForInput());
                Console.WriteLine("\n" + player2.name + " Turn.\n");
                string aiInput = player2.IsVaildChoice(player2.AskForInput());
                Console.Clear();
                CheckAgainstList(input, aiInput);
            }
            GameScore(player1, player2);
            GameOver(player1, player2, rounds);
            string result = PlayAgain().ToLower();
            PlayAgain(result);
        }
        private void PlayAgain(string result)
        {
            switch (result)
            {
                case "yes":
                    Console.Clear();
                    GameLogic LetsPay = new GameLogic();
                    LetsPay.PlayGame();
                    break;
                default:
                    break;
            }
        }

        public void CheckAgainstList(string p1, string p2)
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
                    ShortCheck(p2, Hand[2], Hand[0], Hand[3], Hand[1]);
                    break;
            }
        }
        public void ShortCheck(string p2, string Win, string win, string Lose, string lose)
        {
            if (p2 == Win || p2 == win)
            {
                Console.WriteLine($"{player1.name} Beats: { player2.name}");
                player1.score++;
            }
            else if (p2 == Lose || p2 == lose)
            {
                Console.WriteLine($"{player2.name} Beats: { player1.name}");
                player2.score++;
            }
            else
            {
                Console.WriteLine($"{player1.name} Ties: { player2.name}");
            }
        }
        public void GameScore(User user, User test)
        {
            Console.WriteLine($"{player1.name} score: { player1.score}");
            Console.WriteLine($"{player2.name} score: { player2.score}");
        }
        public void GameOver(User user, User test, int rounds)
        {
            if (user.score == rounds && test.score == rounds)
            {
                Console.WriteLine("There is no Winner!");
            }
            else if (user.score == rounds)
            {
                Console.WriteLine($"IS the Winner!!!: {user.name}");
            }
            else if (test.score == rounds)
            {
                Console.WriteLine($"IS the Winner!!!: {test.name}");
            }
        }
        public string PlayAgain()
        {
            Console.WriteLine("Would you like to play agian?");
            string result = Console.ReadLine();
            return result;
        }

        private string AskForGameType(string input)
        {
            List<string> options = new List<string>() { "multiplayer", "singleplayer", "ai" };
            Console.WriteLine("What game mode would you like to play?(singleplayer , multiplayer , ai)");
            string output = Console.ReadLine().Trim().ToLower();
            while (!options.Contains(output))
            {
                Console.Clear();
                Console.WriteLine("Not a Vaild Input.");
                output = AskForGameType(output);
            }
            return output;
        }
        private int AskForRounds()
        {
            int rounds;
            do
            {
                Console.Clear();
                Console.WriteLine("How many rounds would you like to play to min is 3?");
                int.TryParse(Console.ReadLine(), out rounds);
            } while (rounds < 3);
            return rounds;
        }
    }
}
