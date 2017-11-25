using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCondition_Side_
{
    class SimpleCondition
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Bira!");
            }
            else
            {
                Console.WriteLine("Sokche.");
            }
        }
    }
}