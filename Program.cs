using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
            for (int i = 50; i >= 25 ; i--)
            {
               if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} [3 & 5]");
                }
               else if(i % 5 == 0)
                {
                    Console.WriteLine($"{i} [5]");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} [3]");
                }
               else
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadLine();
        }
    }
}
