using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //add logic here
            // array for rooms
            string[] room = { "Single", "Double", "Luxury", "Penthouse" };
         
            // array for price
            double[] rates = { 45.50, 99.99, 165.25, 1095.50 };
            
                Console.WriteLine("Room Types");
                Console.WriteLine();


            for(int i = 0; i < room.Length; i++)
            {
                Console.WriteLine($"{i+1}. {room[i]} {rates[i]:c} per night");
            }
            Console.WriteLine();

            Console.Write("Please select a room type 1, 2, 3 or 4 :");
            int roomType = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of nights :");
            int nights = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Thank you, the total cost for staying in the {room[roomType-1]} room for {nights} nights is {rates[roomType-1]*nights:c}");
            Console.ReadLine();

        }
    }
}
