using System;
using System.Linq;

namespace pow__max__min
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\n\t welcome to POW function!! \n\n Enter a number");
            Console.WriteLine("The number: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("POWER to: ");
            var y = Convert.ToDouble(Console.ReadLine());
            var result = Pow(x, y);
            Console.WriteLine($"{x} power {y}: {result}");
            Console.WriteLine("Pres enter please to run other function");
            Console.ReadLine();
            Console.Clear();

            ExecuteMaxMin();
        }
        static double Pow(double x, double y)
        {
            var pow = Math.Pow(x, y);
            return pow;
        }
        static void ExecuteMaxMin()
        {
            Console.WriteLine("please enter 5 numbers");
            var numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            var maxNumber = FindMax(numbers);
            Console.WriteLine($"the max number is: {maxNumber}");
            var minNumber = FindMin(numbers);
            Console.WriteLine($"the min number is: {minNumber}");
        }
        static double FindMax(double[] numbers)
        {
            var max = numbers.Max();
            return max;
        }
        static double FindMin(double[] numbers)
        {
            var min = numbers.Min();
            return min;
        }
    }
}
