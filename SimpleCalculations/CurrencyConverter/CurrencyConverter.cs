using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inputcurrency = Console.ReadLine();
            var outputcurrency = Console.ReadLine();
            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            switch (inputcurrency)
            {
                case "BGN":
                    break;
                case "USD":
                    value = value * usd;
                    break;
                case "EUR":
                    value = value * eur;
                    break;
                case "GBP":
                    value = value * gbp;
                    break;
                default:
                    break;
            }
            switch (outputcurrency)
            {
                case "BGN":
                    value = value / bgn;
                    break;
                case "USD":
                    value = value / usd;
                    break;
                case "EUR":
                    value = value / eur;
                    break;
                case "GBP":
                    value = value / gbp;
                    break;
                default:
                    break;
            }
            Console.WriteLine(Math.Round(value, 2) + " " + outputcurrency);
        }
    }
}
