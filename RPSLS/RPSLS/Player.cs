using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public class Player
    {
        public string name;
        public int score;
        string input;
        public List<string> guesture;
        
        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
            
        }
        public string AskForInput()
        {
            string input;
            Console.WriteLine("Choose a gesture");
            input = Console.ReadLine();
            
            return char.ToUpper(input[0]) + input.Substring(1); ;
        }
        public string AiInput()
        {
           int num = new Random().Next(0, guesture.Count());
           string input = guesture.ElementAt(num);
           return input;
        }
        public void IsVaildChoice(string input)
        {
                while(!guesture.Contains(input))
                {
                    Console.WriteLine("Not a Vaild Input.");
                    Console.Clear();
                    input = AskForInput();
                }
        }
        public void Guestures(List<string> hand)
        {
            this.guesture = hand;
        }
    }
}
