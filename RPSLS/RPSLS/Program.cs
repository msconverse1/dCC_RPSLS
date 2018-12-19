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
            GameLogic LetsPay = new GameLogic();
            while (LetsPay.player1.score < 3 && LetsPay.player2.score < 3)
            {
                LetsPay.player1.Guestures(LetsPay.Hand);
                LetsPay.player2.Guestures(LetsPay.Hand);
                string input = LetsPay.player1.AskForInput();
                LetsPay.player1.IsVaildChoice(input);
                string aiInput = LetsPay.player2.AiInput();
                LetsPay.CheckAgainstList(input, aiInput);
                Console.WriteLine($"Player1: ${ LetsPay.player1.score}");
                Console.WriteLine($"Player2: ${ LetsPay.player2.score}");
            }
        }
    }
}
