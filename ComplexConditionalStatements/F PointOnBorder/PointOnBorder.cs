using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_PointOnBorder
{
    class PointOnBorder
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());   //granicite na pravougulnika
            var y1 = double.Parse(Console.ReadLine());   //granicite na pravougulnika
            var x2 = double.Parse(Console.ReadLine());   //granicite na pravougulnika
            var y2 = double.Parse(Console.ReadLine());   //granicite na pravougulnika
            var xOfPoint = double.Parse(Console.ReadLine()); //vuvejdam x
            var yOfPoint = double.Parse(Console.ReadLine()); //vuvejdam y

            if (yOfPoint >= y1 && yOfPoint == y2 && xOfPoint >= x1 && xOfPoint <= x2)
            {
                Console.WriteLine("Border");
            }
            else if (xOfPoint >= x1 && xOfPoint == x2 && yOfPoint >= y1 && yOfPoint <= y2)
            {
                Console.WriteLine("Border");
            }
            else if (xOfPoint == x1 && xOfPoint <= x2 && yOfPoint >= y1 && yOfPoint <= y2)
            {
                Console.WriteLine("Border");
            }
            else if (yOfPoint == y1 && yOfPoint <= y2 && xOfPoint >= x1 && xOfPoint <= x2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
