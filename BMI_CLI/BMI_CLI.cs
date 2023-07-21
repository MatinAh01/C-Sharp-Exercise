using System;

namespace BMI_CLI
{
    class Program
    {
        static void Main(string[] args)
        {


            FalseInput(args);
            Perform(args);



        }
        static void Perform(string[] args)
        {
            var switch1 = args[1];
            var switch2 = args[3];
            var args1 = args[2];
            var args2 = args[4];
            double weight, height;

            switch (switch2)
            {
                case "--height":
                    if (switch2 != "--weight")
                    {
                        InvalidInput();
                        break;
                    }
                    height = Convert.ToDouble(args1);
                    weight = Convert.ToDouble(args2);
                    CalculateBmi(height, weight);
                    break;

                case "--weight":
                    if (switch2 != "--height")
                    {
                        InvalidInput();
                        break;
                    }
                    weight = Convert.ToDouble(args1);
                    height = Convert.ToDouble(args2);
                    CalculateBmi(height, weight);
                    break;
                    default:
                    InvalidInput();
                    break;


            }

        }
        static void FalseInput(string[] args)
        {
            
            if (args.Length == 0)
            {
                InvalidInput();
                Environment.Exit(0);
            }

            else if (args[0] != "bmi")
            {
                InvalidInput();
                Environment.Exit(0);
            }
            else if (args[1] == "--helps")
            {
                HelpList();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                ControlVersion();
                Environment.Exit(0);
            }
        }
        static void InvalidInput()
        {
            Console.WriteLine("invalid input :(");
            Console.WriteLine("Use --helps switch to help you");
        }
        static void CalculateBmi(double height, double weight)
        {
            var status = "";
            var bmi = Math.Round(weight / (height * height));
            
            Console.WriteLine("your bmi is:");
            if (bmi <= 18.5)
            {

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                status = "underweight";
                Console.ResetColor();

            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {

                Console.BackgroundColor = ConsoleColor.Green;
                status = "normal";
                Console.ResetColor();

            }
            else if (bmi > 24.9 && bmi <= 29.9)
            {

                Console.BackgroundColor = ConsoleColor.Yellow;
                status = "over wheight";
                Console.ResetColor();

            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Red;
                status = "obesity";
                Console.ResetColor();

            }
            Console.WriteLine(bmi);
            Console.WriteLine($"Your Status is: {status}");


        }
        static void ControlVersion()
        {
            Console.WriteLine("Current version is: 1.0 ");
        }
        static void HelpList()
        {
            Console.WriteLine("Use these switch to run program:");
            Console.WriteLine("--height \t Your height (centimeters)");
            Console.WriteLine("--weight \t Your weight (kilograms)");
            Console.WriteLine("--version\t Show current version");
            Console.WriteLine("--helps  \t Show command list");
        }

















    }
}
