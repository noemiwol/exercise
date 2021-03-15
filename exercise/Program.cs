using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 5;
            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else
            {
                Console.WriteLine("a is not equal to b");
            }

            var ab = 15;
            if (ab % 2 == 0)
            {
                Console.WriteLine(ab + " is an even number.");
            }
            else
            {
                Console.WriteLine(ab + " number is odd");
            }
        }
    }
}
