using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings 
            // interprets as string input, i.e. 5 will not throw an exception

            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            // ints 
            // if given a float without error handling, throws an exception
            
            int number1, number2;
            Console.WriteLine("Please enter a whole number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you. One more:");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (number1 + number2));

            // floats
            // negatives. decimals, whole numbers
            // strings throw exceptions

            float number3, number4;
            Console.WriteLine("Please enter any number:");
            number3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Thank you. One more:");
            number4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (number3 + number4));

            Console.ReadLine();
        }
    }
}
