using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   public class Player : User
    {
        public Player(string name, int score,List<string> Guestures)
        {
            this.name = name;
            this.score = score;
            this.guesture = Guestures;
        }
    }
}
