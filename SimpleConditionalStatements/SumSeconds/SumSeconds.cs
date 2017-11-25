using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var totalSeconds = firstSeconds + secondSeconds + thirdSeconds;
            var minutes = totalSeconds / 60;
            var leftSeconds = totalSeconds % 60;

            if (leftSeconds >= 10)
            {
                Console.WriteLine($"{minutes}:{leftSeconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:0{leftSeconds}");
            }
        }
    }
}
