using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 0;
            float secondNumber = 0; 

            Console.WriteLine("Please enter the first number:");

            while (!float.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter the first number:");
            }

            Console.WriteLine("Please enter the second number:");

            while (!float.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Please enter a valid numerical value!");
                Console.WriteLine("Please enter the second number:");
            }

            Console.WriteLine(firstNumber + secondNumber);
            Console.ReadLine(); 
        }
    }
}
