﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0To100ToText
{
    class Number0To100ToText
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] rounds = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (n < 0 || n > 100) { Console.WriteLine("invalid number"); }
            else if (n >= 0 && n <= 9) { Console.WriteLine("{0}", digits[n]); }
            else if (n >= 10 && n <= 19) { Console.WriteLine("{0}", tens[n - 10]); }
            else if (n >= 20 && n <= 99)
            {
                if (n % 10 == 0) { Console.WriteLine("{0}", rounds[n / 10 - 2]); }
                else { Console.WriteLine("{0} {1}", rounds[n / 10 - 2], digits[n % 10]); }
            }
            else { Console.WriteLine("one hundred"); }
        }
    }
}
