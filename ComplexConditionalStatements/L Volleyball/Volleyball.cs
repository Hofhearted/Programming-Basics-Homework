using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            
                string leap = Console.ReadLine();
                var p = int.Parse(Console.ReadLine());
                var h = int.Parse(Console.ReadLine());
                double days = 0;
                days += h;
                double normalWeekendPlays = ((48 - h) / 4.00) * 3;
                days += normalWeekendPlays;
                double holidayPlays = (p / 3.00) * 2;
                days += holidayPlays;
                if (leap == "leap")
                {
                    days += (days / 100.00) * 15;
                }
                Console.WriteLine(Math.Truncate(days));
            
        }
    }
}
