using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 30, Min = 0, Max = 0;
            bool correct = false;
            
            
            while (!correct)
                try
                {
                    Console.WriteLine("Pick the Minimum number of range: ");
                    Min = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Not a valid number.");
                }
            correct = false;
            while (!correct)
                try
                {
                    Console.WriteLine("Pick the Maximum number of range: ");
                    Max = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Not a valid number.");
                }

            while (myNum < Min || myNum > Max)
            {
                Console.WriteLine("Pick a number between " + Min + " and " + Max + ".");
                myNum = int.Parse(Console.ReadLine());
                if (myNum < Min)
                    Console.WriteLine("Too small!");
                else if (myNum > Max)
                    Console.WriteLine("Too big!");
                else
                    break;
                
            }
            Console.WriteLine("You picked the number: " + myNum + "!");
            Console.Read();
        }
    }
}
