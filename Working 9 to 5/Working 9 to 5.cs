using System;

namespace LiveCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Infos:");
            var salary = new double[4];
            for (int i = 0; i < salary.Length; i++)
            {
                salary[i] = Convert.ToDouble(Console.ReadLine());
            }
            var regularHours = 17 - salary[0];
            regularHours = regularHours * salary[2];
            double overTime = 0;
            if (salary[1] > 17)
            {
             overTime = (salary[1] - 17) * salary[2] * salary[3];   
            }
            var result = regularHours + overTime;
            Console.WriteLine($"your salary is: ${result}");
        }
    }
}
