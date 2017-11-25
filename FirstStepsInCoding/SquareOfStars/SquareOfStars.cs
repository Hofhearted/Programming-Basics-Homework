using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', number));
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("*{0}*", new string(' ', number - 2));
            }
            Console.WriteLine(new string('*', number));
        }
    }
}
