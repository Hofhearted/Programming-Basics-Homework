using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var ha = double.Parse(Console.ReadLine());
            var area = (a * ha) / 2.0;
            Console.WriteLine("Triangle area = " + area);
        }
    }
}
