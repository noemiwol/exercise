using System;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. simpleCalculator");
                Console.WriteLine("2. triangle");
                Console.WriteLine("3. admissionToCollege");
                Console.WriteLine("4. changeFromGradeToDescription");
                Console.WriteLine("5. daysOfWeek");
                Console.WriteLine("6. temperature");
                Console.WriteLine("7. checkingIfVariablesAreEquald");
                Console.WriteLine("8. checkingIfTheNumberIsEven");
                Console.WriteLine("9. leapYear");
                Console.WriteLine("10. checkingIfBecomeAMemberOfParliament");
                Console.WriteLine("11. height");
                Console.WriteLine("12. biggestNumber");
                Console.WriteLine("13. checkingIfTheNumberIsPositiveOrNegative");

                var choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        simpleCalculator();
                        break;
                    case 2:
                        triangle();
                        break;
                    case 3:
                        admissionToCollege();
                        break;
                    case 4:
                        changeFromGradeToDescription();
                        break;
                    case 5:
                        daysOfWeek();
                        break;
                    case 6:
                        temperature();
                        break;
                    case 7:
                        checkingIfVariablesAreEquald();
                        break;
                    case 8:
                        checkingIfTheNumberIsEven();
                        break;
                    case 9:
                        leapYear();
                        break;
                    case 10:
                        checkingIfBecomeAMemberOfParliament();
                        break;
                    case 11:
                        height();
                        break;
                    case 12:
                        biggestNumber();
                        break;
                    case 13:
                        checkingIfTheNumberIsPositiveOrNegative();
                        break;
                    default:
                        Console.WriteLine("Nie rozpoznano komendy.");
                        break;
                }

                Console.WriteLine("Wcisnij <Escape> aby zakonczyc...");

            } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));
        }

        private static void changeFromGradeToDescription()
        {
            int choose = 0;
            int a = 0;

            Console.WriteLine("1. niedostaeczny");
            Console.WriteLine("2. dopuszczający");
            Console.WriteLine("3. dostateczny");
            Console.WriteLine("4. dobry");
            Console.WriteLine("5. bardzo dobry");
            Console.WriteLine("6. celujący");

            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("niedostateczny ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("dopuszczjący ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("dostateczny ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("dobry ");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("bardzo dobry ");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("celujący ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                    }
            }
        }
        private static void daysOfWeek()
        {
            int choose = 0;
            int a = 0;

            Console.WriteLine("1. poniedziałek");
            Console.WriteLine("2. wtorek");
            Console.WriteLine("3. środa");
            Console.WriteLine("4. czwartek");
            Console.WriteLine("5. piątek");
            Console.WriteLine("6. sobota");
            Console.WriteLine("7. niedziela");

            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("poniedziałek ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("wtorek ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("środa ");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("czwartek ");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("piątek");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("sobota");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("niedziela");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiego dnia");
                        break;
                    }
            }
        }

        private static void simpleCalculator()
        {
            int choose = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = int.Parse(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine($"Wynik to: {c}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = int.Parse(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine($"Wynik to: {c}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = int.Parse(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine($"Wynik to: {c}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Podaj 1 liczbe: ");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj 2 liczbe: ");
                        b = double.Parse(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine($"Wynik to: {c}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                    }
            }
        }

        private static void checkingIfTheNumberIsEven()
        {
            var ab = 15;
            if (ab % 2 == 0)
            {
                Console.WriteLine($"{ab} is an even number.");
            }
            else
            {
                Console.WriteLine($"{ab} number is odd");
            }
        }

        private static void checkingIfVariablesAreEquald()
        {
            var a = 5;
            var b = 5;
            if (a == b)
            {
                Console.WriteLine($"{nameof(a)} is equal to {nameof(b)}");
            }
            else
            {
                Console.WriteLine($"{nameof(a)} is not equal to {nameof(b)}");
            }
        }

        private static void checkingIfTheNumberIsPositiveOrNegative()
        {
            Console.WriteLine("Enter a digit and the program will check if it is negative or positive");

            string input = Console.ReadLine();
            int.TryParse(input, out var number);

            if (number > 0)
            {
                Console.WriteLine($"The digit entered is a number: {number} positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The digit entered is a number: {number} negative");
            }
            else
            {
                Console.WriteLine("The digit entered is zero");
            }
        }

        private static void leapYear()
        {
            Console.WriteLine("Enter a year and the program will check if it is leap");

            string input = Console.ReadLine();
            int.TryParse(input, out var year);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is not leap");
            }
        }
        private static void checkingIfBecomeAMemberOfParliament()
        {
            Console.WriteLine("Check can you become a member of parliament. Enter you age");

            string input = Console.ReadLine();
            int.TryParse(input, out var age);

            if (age >= 21)
            {
                Console.WriteLine("Yes you can");
            }
            else
            {
                Console.WriteLine("you cannot");
            }

        }

        private static void height()
        {
            Console.WriteLine("enter your height in cm");

            string input = Console.ReadLine();
            int.TryParse(input, out var cm);

            if (cm >= 140)
            {
                Console.WriteLine("you are an ant.");
            }
            else
            {
                Console.WriteLine(" you are an elephant");
            }
        }

        private static void biggestNumber()
        {
            Console.WriteLine("enter three numbers");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            int.TryParse(input1, out var number1);
            int.TryParse(input2, out var number2);
            int.TryParse(input3, out var number3);

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"The largest number entered is: {number1}");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"The largest number entered is: {number2}");
            }
            else
            {
                Console.WriteLine($"The largest number entered is: {number3}");
            }
        }

        private static void temperature()
        {
            Console.WriteLine("Enter how many degrees it is outside");

            string input = Console.ReadLine();
            int.TryParse(input, out var temp);

            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ ");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine(" zimno ");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine(" chłodno ");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine(" w sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine(" zaczyna być słabo, bo gorąco ");
            }
            else
            {
                Console.WriteLine(" a weź wyprowadzam się na Alaskę");
            }
        }
        private static void triangle()
        {
            //Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych.
            Console.WriteLine("wprowadz 3 długości boków trójkąta");
            string input = Console.ReadLine();
            int.TryParse(input, out var a);
            int.TryParse(input, out var b);
            int.TryParse(input, out var c);

            if (a > b)
            {
                if (a > c)
                {
                    if (b + c < a)
                    {
                        Console.WriteLine("można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("nie można zbudować trójkąt");
                    }
                }
                else
                {
                    if (a + b < c)
                    {
                        Console.WriteLine("można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("nie można zbudować trójkąt");
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (c + a < b)
                    {
                        Console.WriteLine("można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("nie można zbudować trójkąt");
                    }
                }
                else
                {
                    if (a + b < c)
                    {
                        Console.WriteLine("można zbudować trójkąt");
                    }
                    else
                    {
                        Console.WriteLine("nie można zbudować trójkąt");
                    }
                }
            }
        }

        private static void admissionToCollege()
        {

            Console.WriteLine("wprowadz punkty z przedmiotów");

            string input = Console.ReadLine();
            int.TryParse(input, out var maths);
            int.TryParse(input, out var physics);
            int.TryParse(input, out var chemistry);

            if (maths > 70 && physics > 55 && chemistry > 45 && maths + physics + chemistry > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (maths + physics > 150 || maths + chemistry > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji ");
            }
            else
            {
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji ");
            }
        }
    }
}