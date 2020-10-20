using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefenen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userinput = new string [10];
            Array.Sort(userinput);

            for (int i = 0; i < userinput.Length; i++)
            {
                userinput[i] = Console.ReadLine();
                
            }
            foreach (string item in userinput)
            {
                Console.WriteLine(item);
            }

        }
    }
}
