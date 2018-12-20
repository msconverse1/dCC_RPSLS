using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class User
    {
        public string name;
        public int score;
        public List<string> guesture;
        public User()
        {

        }
        public void Guestures(List<string> hand)
        {
            this.guesture = hand;
        }
        public virtual string AskForInput()
        {
            string input;
            Console.WriteLine("Choose a gesture");
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Not a Vaild Input.");
               input = AskForInput();
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }
        public string IsVaildChoice(string input)
        {
            while (!guesture.Contains(input))
            {
                Console.WriteLine("Not a Vaild Input.");

              input = AskForInput();
            }
            return input;
        }
    }
}
