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
                Console.WriteLine("How many rounds would you like to play to?");
               
                 int.TryParse(Console.ReadLine(), out int rounds);
                GameLogic LetsPay = new GameLogic(gameType);
                while (LetsPay.player1.score < rounds && LetsPay.player2.score < rounds)
                {
                    LetsPay.GameScore(LetsPay.player1, LetsPay.player2);
                    Console.WriteLine("\n" + LetsPay.player1.name + " Turn.\n");
                    string input = LetsPay.player1.AskForInput();
                    LetsPay.player1.IsVaildChoice(input);
                    Console.WriteLine("\n" + LetsPay.player2.name + " Turn.\n");
                    string aiInput = LetsPay.player2.AskForInput();
                    LetsPay.player2.IsVaildChoice(aiInput);
                    Console.Clear();
                    LetsPay.CheckAgainstList(input, aiInput);
                }           
                LetsPay.GameScore(LetsPay.player1, LetsPay.player2);
                LetsPay.GameOver(LetsPay.player1, LetsPay.player2, rounds);
                Console.Read();
        }
    }
}
