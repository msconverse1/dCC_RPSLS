using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public class Player
    {
        string name;
        int score;
        GameLogic happening;
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;

        }
        public string AskForInput()
        {
            string input;
            input = Console.ReadLine();
            return input;
        }
        public string AiInput()
        {
           int num = new Random().Next(0, happening.Hand.Count());
           string input = happening.Hand.ElementAt(num);
           return input;
        }
        public void IsVaildChoice(string input)
        {
            for (int i = 0; i < happening.Hand.Count(); i++)
            {
                if(!happening.Hand.Contains(input))
                {
                    Console.WriteLine("Not a Vaild Input.");
                }
            }
        }
    }
}
