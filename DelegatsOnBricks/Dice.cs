using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatsOnBricks
{
    class Dice
    {
        int a; //first dice
        int b; //second dice  
        static Random rand = new Random();
        public Dice()
        {
        }
        public void Go()
        {
            a = rand.Next(1, 7);
            b = rand.Next(1, 7);
        }
    }
}
