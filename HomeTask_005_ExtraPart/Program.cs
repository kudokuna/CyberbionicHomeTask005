using System;
using System.Threading;

namespace HomeTask_005_ExtraPart
{
    class Program
    {
        static void Main(string[] args)
        {
            // user decision select method
            DefineUserInput();
        }
        // user decision select logic method
        public static void DefineUserInput()
        {
            bool isWantToExit = false;

            while (!isWantToExit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hi, Please choose task (1-2) or type exit for exit...");
                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "1":
                        PowerOfTwoCheck();
                        break;
                    case "2":
                        DeMorganCheck();
                        break;

                    case "exit":
                        isWantToExit = true;
                        Console.WriteLine("Thank you for using my program. Have a nice day...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Wrong choise...Please hit enter to try again...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        // Extra Task1 logic
        public static void PowerOfTwoCheck()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            bool isCorrectNumber = false;
            int usersValue = default(int);

            while (!isCorrectNumber)
            {
                Console.WriteLine("Hi, Please type any integer number...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out usersValue);
                if (isConvertCorrect)
                {
                    usersValue = int.Parse(userInputString);
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Wrong input...");
            }

            if ((usersValue != 0) && ((usersValue & (usersValue - 1)) == 0))
            {
                Console.WriteLine($"The number {usersValue} is a power of two");
            }
            else Console.WriteLine($"The number {usersValue} is NOT a power of two");

            Console.ReadKey();
        }
        // Extra Task2 logic
        public static void DeMorganCheck()
        {
            bool firstValue = true;
            bool secondValue = false;
            Console.WriteLine("Lets check DeMorgan Theory");
            Console.WriteLine($"We have two values:  firstValue is {firstValue}, second value is {secondValue}");
            Thread.Sleep(500);
            Console.WriteLine("According to DeMorgan Theory A || B	= !(!A && !B)  so lets check it");

            if ((firstValue || secondValue) == (!(!firstValue && !secondValue))) {
                Console.WriteLine("If you see this message than DeMorgan theorem is proved");
            }

            Console.ReadKey();
        }
    }
}
