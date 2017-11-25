using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            {
                var number = double.Parse(Console.ReadLine());
                var bonusPoints = 0.0;

                if (number <= 100)
                {
                    bonusPoints = bonusPoints + 5;
                }
                else if (number > 100 && number <= 1000)
                {
                    bonusPoints = number * 0.20;
                }
                else if (number > 1000)
                {
                    bonusPoints = number * 0.10;
                }
                if (number % 2 == 0)
                {
                    bonusPoints = bonusPoints + 1;
                }
                else if (number % 10 == 5)
                {
                    bonusPoints = bonusPoints + 2;
                }
                Console.WriteLine(bonusPoints);
                Console.WriteLine(number + bonusPoints);
            }
        }
    }
}
