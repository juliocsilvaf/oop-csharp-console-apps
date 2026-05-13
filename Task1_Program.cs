using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
            Console.Write("Enter an integer value: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter an operator [Subtract - , Plus + , Multiply * or Division /]: ");
            string ops = Console.ReadLine();
            Console.Write("Enter another integer value: ");
            int secondNum = int.Parse(Console.ReadLine());

            if (ops == "-")
            {
                Console.WriteLine($"{firstNum} minus {secondNum} equals {firstNum - secondNum}");
            }
            else if (ops == "+")
            {
                Console.WriteLine($"{firstNum} plus {secondNum} equals {firstNum + secondNum}");
            }
            else if (ops == "*")
            {
                Console.WriteLine($"{firstNum} multiply {secondNum} equals {firstNum * secondNum}");
            }
            else if(ops == "/")
            {
                Console.WriteLine($"{firstNum} division {secondNum} equals {firstNum / secondNum}");
            }

            Console.ReadLine();

        }
    }
}
