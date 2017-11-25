using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2} leva", r * c * 12);
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2} leva", r * c * 7.50);
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2} leva", r * c * 5);
                    break;
            }
        }
    }
}
