using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Side_
{
    class Converter
    {
        static void Main(string[] args)
        {
            var leva = int.Parse(Console.ReadLine());
            var euro = leva / 1.95583;
            Console.WriteLine(euro);
        }
    }
}
