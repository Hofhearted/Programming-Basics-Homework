using System;



class House
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        

        var numberOfRows = n / 2 + n % 2;
        var numberofStars = 0;
        if (n % 2 == 0)
        {
            numberofStars = 2;
        }
        else
        {
            numberofStars = 1;
        }
        for (int i = 0; i < numberOfRows; i++)
        {
            var numberOfDashes = (n - numberofStars) / 2;
            Console.Write(new string('-', numberOfDashes));
            Console.Write(new string('*', numberofStars));
            Console.WriteLine(new string('-', numberOfDashes));

            numberofStars += 2;
        }
            






            numberOfRows = n / 2;
            for (int row = 0; row < numberOfRows; row++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));

                Console.WriteLine('|');
            }


            



        }
    }