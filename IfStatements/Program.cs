using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userInput = int.Parse(Console.ReadLine());
            

            if ((userInput % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year", userInput);
            }

            if ((userInput % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year", userInput);
            }

            if ((userInput % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year", userInput);
            }

            else
            {
                Console.WriteLine("{0} is not a leap year", userInput);
            }

        }
    }
}
