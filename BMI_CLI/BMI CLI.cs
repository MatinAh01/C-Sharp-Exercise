using System;

namespace BMI_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Accredit(args);
            Perform(args);

        }
        static void Perform(string[] args)
        {
            var switch1 = args[1];
            var switch2 = args[3];
            var arg1 = args[2];
            var arg2 = args[4];
            double height, weight;
            switch (switch1)
            {
                case "height":

                    if (switch2 != "weight")
                    {
                        InvalidInput();
                        break;
                    }
                    height = Convert.ToDouble(args[2]);
                    weight = Convert.ToDouble(args[4]);
                    BmiCalculate(height, weight);
                    break;
                case "weight":

                    if (switch2 != "height")
                    {
                        InvalidInput();
                        break;
                    }
                    weight = Convert.ToDouble(args[2]);
                    height = Convert.ToDouble(args[4]);
                    BmiCalculate(height, weight);

                    break;
                default:
                    InvalidInput();
                    break;
            }
        }
        static void Accredit(string[] args)
        {
            if (args.Length == 0 || args[0] != "bmi")
            {
                InvalidInput();
                Environment.Exit(0);
                
            }
            else if (args[1] == "--helps")
            {
                ShowHelp();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                ControlVersion();
                Environment.Exit(0);
            }
                

        }
        static void BmiCalculate(double height, double weight)
        {
            var bmi = weight / (Math.Pow(height, 2));
            height = height / 100;
            Console.WriteLine($"your bmi is {bmi}");


            if (bmi <= 18.5)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Your status is underweight");
                Console.ResetColor();
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Your status is normal");
                Console.ResetColor();
            }
            else if (bmi > 24.9 && bmi <= 29.9)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your status is overweight");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("your status is obesity");
                Console.ResetColor();
            }
        }
        static void ShowHelp()
        {
            Console.WriteLine("\nUse these switch to run program:");
            Console.WriteLine("--height\tYour height (centimeters)");
            Console.WriteLine("--weight\tYour weight (kilograms)");
            Console.WriteLine("--version\tShow current version");
            Console.WriteLine("--helps\t\tShow command list");

        }
        static void ControlVersion()
        {
            Console.WriteLine("\nCurrent version is: 1.0");
        }
        static void InvalidInput()
        {
            Console.WriteLine("\nInvalid command :(");
            Console.WriteLine("Use --helps switch to show help");
        }
    }
}

















