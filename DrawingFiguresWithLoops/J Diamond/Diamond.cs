﻿using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        #region firstLine
        if (n == 1)
        {
            Console.WriteLine('*');
        }
        else
        {
            if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                if (n % 2 == 0)
                {
                    var numberOfStars = 2;
                    var numberOfDashes = (n - numberOfStars) / 2;
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write(new string('*', numberOfStars));
                    Console.WriteLine(new string('-', numberOfDashes));
                }
                else
                {
                    var numberOfStars = 1;
                    var numberOfDashes = (n - numberOfStars) / 2;
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write(new string('*', numberOfStars));
                    Console.WriteLine(new string('-', numberOfDashes));
                }


                #endregion



                var numberOfDashesInMiddle = 0;
                if (n % 2 == 0)
                {
                    numberOfDashesInMiddle = 2;
                }
                else
                {
                    numberOfDashesInMiddle = 1;
                }


                var numberOfRows = (n - 1) / 2;
                for (int i = 0; i < numberOfRows; i++)
                {
                    var numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
                    Console.Write(new string('-', numberOfDashesInEnd));
                    Console.Write('*');
                    Console.Write(new string('-', numberOfDashesInMiddle));
                    Console.Write('*');
                    Console.WriteLine(new string('-', numberOfDashesInEnd));

                    numberOfDashesInMiddle += 2;

                }

                numberOfRows--;
                numberOfDashesInMiddle -= 2;
                for (int i = numberOfRows - 1; i >= 0; i--)
                {
                    numberOfDashesInMiddle -= 2;
                    var numberOfDashesInEnd = (n - 2 - numberOfDashesInMiddle) / 2;
                    Console.Write(new string('-', numberOfDashesInEnd));
                    Console.Write('*');
                    Console.Write(new string('-', numberOfDashesInMiddle));
                    Console.Write('*');
                    Console.WriteLine(new string('-', numberOfDashesInEnd));


                }



                #region lastline


                if (n % 2 == 0)
                {
                    var numberOfStars = 2;
                    var numberOfDashes = (n - numberOfStars) / 2;
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write(new string('*', numberOfStars));
                    Console.WriteLine(new string('-', numberOfDashes));
                }
                else
                {
                    var numberOfStars = 1;
                    var numberOfDashes = (n - numberOfStars) / 2;
                    Console.Write(new string('-', numberOfDashes));
                    Console.Write(new string('*', numberOfStars));
                    Console.WriteLine(new string('-', numberOfDashes));
                }


                #endregion








            }
        }

           
        }
       
    }
