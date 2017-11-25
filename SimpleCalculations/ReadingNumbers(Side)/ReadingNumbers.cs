using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumbers_Side_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number:");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.Write("The sum of the two numbers is: ");
            var sum = firstNumber + secondNumber;
            Console.WriteLine(sum);
        }
    }
}
