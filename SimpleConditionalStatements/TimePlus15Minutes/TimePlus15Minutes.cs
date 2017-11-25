using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var sum = ((hours * 60) + minutes + 15);
            var finalhour = sum / 60;
            if (finalhour >= 24)
            {
                finalhour -= 24;
            }
            var finalminutes = sum % 60;
            Console.WriteLine("{0}:{1:00}", finalhour, finalminutes);
        }
    }
}
