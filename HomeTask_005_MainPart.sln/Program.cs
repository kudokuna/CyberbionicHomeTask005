using System;
using System.Threading;

namespace HomeTask_005_MainPart.sln
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
                Console.WriteLine("Hi, Please choose task (2-4) or type exit for exit...");
                string userChoise = Console.ReadLine();

                switch (userChoise)
                {
                    case "2":
                        ParityChecking();
                        break;
                    case "3":
                        OperationsResultCheck();
                        break;
                    case "4":
                        PremiumCalculation();
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
        // Task1 logic 
        public static void ParityChecking() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool isCorrectNumber = false;
            int userInputValue = default(int);

            while (!isCorrectNumber) 
            {
                Console.WriteLine("Please enter an even integer...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out userInputValue);
                if (isConvertCorrect)
                {
                    userInputValue = int.Parse(userInputString);
                    isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

            // Variannt 1  --- using logical AND
            Console.WriteLine("According to check via Logical AND  your");
            if ((userInputValue & 1) == 0)
            { 
                Console.WriteLine($"Value {userInputValue} is even");
            }
            else Console.WriteLine($"Value {userInputValue} is NOT even");


            // Varian 2 --- using bit shift
            Console.WriteLine("According to check via shifting to 31 bit your");
            if ((userInputValue << 31) == 0)
            {
                Console.WriteLine($"Value {userInputValue} is even");
            }
            else Console.WriteLine($"Value {userInputValue} is NOT even");
            Console.ReadKey();
        }
        // Task2 logic
        public static void OperationsResultCheck() 
        {
            int x = 5, y = 10, z = 15;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"We have three variables x = {x}, y = {y} and z = {z} \n");
            Thread.Sleep(250);
            Console.WriteLine("Lets solve some examples...\n");
            x += y >> x++ * z;
            Console.WriteLine($"x += y >> x++ * z AND x = {x}");
            z = ++x & y * 5;
            Console.WriteLine($"z = ++x & y * 5 AND z = {z}");
            y /= x + 5 | z;
            Console.WriteLine($"y /= x + 5 | z AND y = {y}");
            z = x++ & y * 5;
            Console.WriteLine($"z = x++ & y * 5 AND z = {z}");
            x = y << x++ ^ z;
            Console.WriteLine($"x = y << x++ ^ z AND x = {x}");

            Console.ReadLine();
        }
        // Task3 logic
        public static void PremiumCalculation() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            bool isCorrectNumber = false;
            int empoyeeYears = default(int);
            double userSalary = default(double);

            while (!isCorrectNumber)
            {
                Console.WriteLine("Hi, Please select amount of full working years for employee...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = int.TryParse(userInputString, out empoyeeYears);
                if (isConvertCorrect)
                {
                    empoyeeYears = int.Parse(userInputString);
                    if (empoyeeYears < 0) { Console.WriteLine("Input error, please try again "); } else isCorrectNumber = true;        
                }
                else  Console.WriteLine("Input error, please try again ");
            }

            isCorrectNumber = false;
            while (!isCorrectNumber)
            {
                Console.WriteLine("Please Enter salary in $...");
                String userInputString = Console.ReadLine();
                bool isConvertCorrect = double.TryParse(userInputString, out userSalary);
                if (isConvertCorrect)
                {
                    userSalary = double.Parse(userInputString);
                    if (userSalary <= 0) { Console.WriteLine("Input error, please try again "); } else isCorrectNumber = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }

                 if (empoyeeYears >= 0 & empoyeeYears < 5) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.1)} $"); }
            else if (empoyeeYears >= 5 & empoyeeYears < 10) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.15)} $"); }
            else if (empoyeeYears >= 10 & empoyeeYears < 15) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.25)} $"); }
            else if (empoyeeYears >= 15 & empoyeeYears < 20) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.35)} $"); }
            else if (empoyeeYears >= 20 & empoyeeYears < 25) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.45)} $"); }
            else if (empoyeeYears >= 25) { Console.WriteLine($"You working {empoyeeYears} year(s), your salary + premium = {userSalary += (userSalary * 0.5)} $"); }
            
            Console.ReadLine();
        }
    }
}
