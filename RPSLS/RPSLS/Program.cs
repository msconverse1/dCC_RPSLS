using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main()
        {
                GameLogic LetsPay = new GameLogic();
                 int rounds = LetsPay.rounds;
                while (LetsPay.player1.score < rounds && LetsPay.player2.score < rounds)
                {
                    LetsPay.GameScore(LetsPay.player1, LetsPay.player2);
                    Console.WriteLine("\n" + LetsPay.player1.name + " Turn.\n");
                    string input = LetsPay.player1.AskForInput();
                   input = LetsPay.player1.IsVaildChoice(input);
                    Console.WriteLine("\n" + LetsPay.player2.name + " Turn.\n");
                    string aiInput = LetsPay.player2.AskForInput();
                    aiInput = LetsPay.player2.IsVaildChoice(aiInput);
                    Console.Clear();
                    LetsPay.CheckAgainstList(input, aiInput);
                }           
                LetsPay.GameScore(LetsPay.player1, LetsPay.player2);
                LetsPay.GameOver(LetsPay.player1, LetsPay.player2, rounds);
                string result =LetsPay.PlayAgain().ToLower();
                 PlayAgain(result);
        }
        static void PlayAgain(string result)
        {
            switch (result)
            {
                case "yes":
                    Console.Clear();
                    Main();
                    break;
                case "no":
                    break;
                default:
                    break;
            }
        }
    }
}
