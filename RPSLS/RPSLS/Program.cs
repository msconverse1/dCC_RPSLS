using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What game mode would you like to play?(singleplayer or multiplayer)");
            string gameType = Console.ReadLine();
            if (gameType == "singleplayer")
            {
                GameLogic LetsPay = new GameLogic();
                while (LetsPay.player1.score < 3 && LetsPay.player2.score < 3)
                {
                    LetsPay.player1.Guestures(LetsPay.Hand);
                    LetsPay.player2.Guestures(LetsPay.Hand);
                    Console.WriteLine(LetsPay.player1.name + " score: " + LetsPay.player1.score);
                    Console.WriteLine(LetsPay.player2.name + " score: " + LetsPay.player2.score);
                    Console.WriteLine("\n");
                    Console.WriteLine(LetsPay.player1.name + " Turn.");
                    Console.WriteLine("\n");
                    string input = LetsPay.player1.AskForInput();
                    LetsPay.player1.IsVaildChoice(input);
                    Console.WriteLine("\n");
                    Console.WriteLine(LetsPay.player2.name + " Turn.");
                    string aiInput = LetsPay.player2.AiInput();
                    Console.Clear();
                    LetsPay.CheckAgainstList(input, aiInput);
                }
            }
            else
            {
                GameLogic LetsPay = new GameLogic();
                while (LetsPay.player1.score < 3 && LetsPay.player2.score < 3)
                {
                    LetsPay.player1.Guestures(LetsPay.Hand);
                    LetsPay.player2.Guestures(LetsPay.Hand);
                    Console.WriteLine(LetsPay.player1.name + " score: " + LetsPay.player1.score);
                    Console.WriteLine(LetsPay.player2.name + " score: " + LetsPay.player2.score);
                    Console.WriteLine("\n");
                    Console.WriteLine(LetsPay.player1.name + " Turn.");
                    Console.WriteLine("\n");
                    string input = LetsPay.player1.AskForInput();
                    LetsPay.player1.IsVaildChoice(input);
                    Console.WriteLine("\n");
                    Console.WriteLine(LetsPay.player2.name + " Turn.");
                    Console.WriteLine("\n");
                    string aiInput = LetsPay.player2.AskForInput();
                    LetsPay.player2.IsVaildChoice(aiInput);
                    Console.Clear();
                    LetsPay.CheckAgainstList(input, aiInput);
                }
            }
        }
    }
}
