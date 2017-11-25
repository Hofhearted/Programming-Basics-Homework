using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
                var sum1 = double.Parse(Console.ReadLine());
                var metric = Console.ReadLine();
                var destination = Console.ReadLine();
                var interMediateMeters = 0.00;
                var finalMetric = 0.00;
                // input
                if (metric == "mm")
                {
                    interMediateMeters = sum1 / 1000;
                }
                else if (metric == "cm")
                {
                    interMediateMeters = sum1 / 100;
                }
                else if (metric == "mi")
                {
                    interMediateMeters = sum1 / 0.000621371192;
                }
                else if (metric == "in")
                {
                    interMediateMeters = sum1 / 39.3700787;
                }
                else if (metric == "km")
                {
                    interMediateMeters = sum1 / 0.001;
                }
                else if (metric == "ft")
                {
                    interMediateMeters = sum1 / 3.2808399;
                }
                else if (metric == "yd")
                {
                    interMediateMeters = sum1 / 1.0936133;
                }
                else if (metric == "m")
                {
                    interMediateMeters = sum1;
                }

                // output

                if (destination == "mm")
                {
                    finalMetric = interMediateMeters * 1000;
                }
                else if (destination == "m")
                {
                    finalMetric = interMediateMeters;
                }
                else if (destination == "cm")
                {
                    finalMetric = interMediateMeters * 100;
                }
                else if (destination == "mi")
                {
                    finalMetric = interMediateMeters * 0.000621371192;
                }
                else if (destination == "in")
                {
                    finalMetric = interMediateMeters * 39.3700787;
                }
                else if (destination == "km")
                {
                    finalMetric = interMediateMeters * 0.001;
                }
                else if (destination == "ft")
                {
                    finalMetric = interMediateMeters * 3.2808399;
                }
                else if (destination == "yd")
                {
                    finalMetric = interMediateMeters * 1.0936133;
                }

                Console.WriteLine($"{finalMetric} {destination}");
        }
    }
}
