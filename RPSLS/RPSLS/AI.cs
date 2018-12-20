using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        public  AI() 
        {
            name = "Peter ";
            score = 0;
        }
      public  override string AskForInput()
        {
            int num = new Random().Next(0, guesture.Count());
            string input = guesture.ElementAt(num);
            return input;
        }
    }
}
