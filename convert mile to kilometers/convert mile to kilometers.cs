using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in mile ");
            var km = ConvertMile();
            Console.WriteLine(km);
        }
        static double ConvertMile()
        {

            var convert = Convert.ToDouble(Console.ReadLine()) * 1.6093;

            return convert;
        }
    }
}
