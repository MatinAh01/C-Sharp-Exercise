using System;

namespace Calculator_with_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            do
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Calculator program");
                Console.WriteLine("------------------");
                GetNumbers(calculator);
                calculator.Options();
                try
                {    
                calculator.Process();   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("would you like to continue?(y/n)");
            } while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("good luck!");
        }
        private static void GetNumbers(Calculator calculator)
        {
            Console.Write("Enter number1: ");
            calculator.FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number2: ");
            calculator.SecondNumber = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}
