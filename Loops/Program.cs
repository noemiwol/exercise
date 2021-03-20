using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("1. Prime Numbers");
                Console.WriteLine("2. Looking for even numbers");
                Console.WriteLine("3. Fibonacci sequence");
                Console.WriteLine("4. Pyramid of stars");
                Console.WriteLine("5. Pyramid of numbers");
                Console.WriteLine("6. Numbers to the power of 3");
                Console.WriteLine("7. Calculating the sum according to the formula 1 + ½ + 1/3 + ¼ ");
                Console.WriteLine("8. Reverse word");
                Console.WriteLine("9. Convert a decimal number to a binary number");
                Console.WriteLine("10. Looking for least common divisor for two numbers");


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
                        break;
                    case 4:
                        pyramidOfStars();
                        break;
                    case 5:
                        pyramidOfNumbers();
                        break;
                    case 6:
                        numbersToThePower();
                        break;
                    case 7:
                        accordingToTheFormulaers();
                        break;
                    case 8:
                        reverseString();
                        break;
                    case 9:
                        convertDecimalToBinary();
                        break;
                    case 10:
                        leastCommonDivisor();
                        break;
                    default:
                        Console.WriteLine("Command not recognized.");
                        break;
                }

                Console.WriteLine("Press <Escape> to finish...");

            } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));
        }
        private static void fibonacciSequence()
        {
            //variable initialization
            long a = 0;
            long b = 1;
            long c;

            //start display
            Console.WriteLine(a);
            Console.WriteLine(b);

            //counting loop
            for (var i = 0; i < 50; i++)
            {
                //computing sequence order
                c = a + b;

                //shifting the thrust
                a = b;
                b = c;

                //displaying the current value
                Console.WriteLine(c);
            }

            //end of program
            Console.ReadKey();
        }
        private static void evenNumbers()
        {
            var a = 0;
            do
            {
                Console.WriteLine($"Finds all even numbers in the range 0 - 1000 is {a}");
                a++;
            }
            while (a++ < 1000 && a % 2 == 0);

            Console.ReadKey();

        }

        private static void primeNumbers()
        {
            int count = 0;

            for (var i = 2; i <= 100; i++)
            {
                var isPrime = 1;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (i % j == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                }

                count += isPrime;
            }
            Console.WriteLine($"The range from 0 to 100 is  {count} prime");
            Console.ReadKey();

        }

        private static void pyramidOfStars()
        {
            Console.WriteLine("Enter the number and see the pyramid of stars");

            string input = Console.ReadLine();

            int.TryParse(input, out var number);

            char ch = '*';


            for (var i = 0; i < number; i++)
            {
                Console.Write(" ");
                for (var j = 0; j < i + 1; j++)
                {

                    Console.Write(ch);

                }
                Console.Write(" ");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        private static void pyramidOfNumbers()
        {
            Console.WriteLine("Enter the number and see the pyramid of digits");

            string input = Console.ReadLine();

            int.TryParse(input, out var number);

            for (var i = 0; i < number; i++)
            {
                for (var j = 0; j < i + 1; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        private static void numbersToThePower()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            int value = 3;
            for (int power = 0; power <= 20; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0}");

            Console.ReadKey();

        }
        private static void accordingToTheFormulaers()
        {
            //calculating the sum according to the formula 1 + ½ + 1/3 + ¼ i
            double i, s = 0.0;
            for (i = 1; i <= 20; i++)
            {
                s = s + 1 / i;
                Console.WriteLine($"Sum is {s}");
            }
            Console.ReadKey();
        }

        private static void reverseString()
        {
            Console.WriteLine("Enter word:");

            string stringInput;
            var reversestring = "";

            int Length;

            stringInput = Console.ReadLine();

            Length = stringInput.Length - 1;

            while (Length >= 0)
            {
                reversestring = reversestring + stringInput[Length];
                Length--;
            }
            Console.WriteLine("Reverse  word is  {0}", reversestring);
            Console.ReadLine();
        }
        private static void convertDecimalToBinary()
        {
            Console.WriteLine("Enter a decimal number");

            string input = Console.ReadLine();

            int.TryParse(input, out var number);

            int k;
            int i;

            string str = "";
            string bin = "";

            while (number >= 1)
            {
                k = number / 2;
                str = str + (number % 2).ToString();
                number = k;
            }
            for (i = str.Length - 1; i >= 0; i--)
            {
                bin = bin + str[i];
            }
            Console.WriteLine($"The binary format is: {bin}");


        }
        private static void leastCommonDivisor()
        {
            //least common divisor for two numbers

            }

        }
    }
}

        
    


