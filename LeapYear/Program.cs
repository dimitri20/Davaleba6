using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randYear = rand.Next(2021);
            if(randYear % 4 == 0)
            {
                Console.WriteLine($"{randYear} iyo nakiani weli");
            } else
            {
                Console.WriteLine($"{randYear} ar iyo nakiani weli");
            }
        }
    }
}
