﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "others":
                    Console.WriteLine("unknown");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
