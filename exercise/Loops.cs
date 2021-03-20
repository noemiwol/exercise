using System;
using System.Collections.Generic;
using System.Text;

namespace exercise
{
    class Loops
    {
        static void LoopsApp(string[] args)
        {
            do
            {
                Console.WriteLine("1. Prime Numbers");
                Console.WriteLine("2. Looking for even numbers");
                Console.WriteLine("3. Fibonacci sequence");





                var choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        primeNumbers();
                        break;
                    case 2:
                        evenNumbers();
                        break;
                    case 3:
                        fibonacciSequence();
                    default:
                        Console.WriteLine("Nie rozpoznano komendy.");
                        break;
                }

                Console.WriteLine("Wcisnij <Escape> aby zakonczyc...");

            } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));
            }
        private static void fibonacciSequence()
        {

        }
        private static void evenNumbers()
        {
            var a = 100;
            do
            {
                Console.WriteLine($"The number of even numbers in the range of 0 to 100 is: {a}");
                a++;
            }
            while (a % 2 == 0);
                

        }

        private static void primeNumbers()
        {
            var a = 100;
            for(var i = 2; i < a; i++)
            {
                if(a % i == 0)
                {
                    a++;
                    Console.WriteLine($"count first in range 0 - 100 is {a} ");
                }
            }
        }
    }
}
