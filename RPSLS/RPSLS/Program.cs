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
            LetsPay.player1.Guestures(LetsPay.Hand);
            string input = LetsPay.player1.AskForInput();
            LetsPay.player1.IsVaildChoice(input);
        }
    }
}
