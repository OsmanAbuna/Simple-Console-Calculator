using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //init int num
            int num1 = 0;
            int num2 = 0;
            //getting user inputs
            Console.WriteLine("Type a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            //chossing operator
            Console.WriteLine("In what method you want to calculate");
            Console.WriteLine("\n");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\n");
            Console.WriteLine("Choose");

            //Switch statments

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            //printing the answer
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
