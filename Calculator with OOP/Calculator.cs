using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator_with_OOP
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        private double _result;
        private string _operand;
        public string Operand
        {
            set
            {
                if (value == "+" ||
                    value == "-" ||
                    value == "*" ||
                    value == "/")
                { _operand = value ; }
            }
        }
        public void Options()
            {
                Console.WriteLine("Options: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");
                Operand = Console.ReadLine();
            }
            public void Process()
            {
                switch (_operand)
                {
                    case "+":
                    _result = FirstNumber + SecondNumber;
                    Console.WriteLine($"your result:{_result}");
                    break;
                    case "-":
                    _result = FirstNumber - SecondNumber;
                    Console.WriteLine($"your result:{_result}");
                    break;
                    case "*":
                    _result = FirstNumber * SecondNumber;
                    Console.WriteLine($"your result:{_result}");
                    break;
                    case "/":
                    _result = FirstNumber / SecondNumber;
                    Console.WriteLine($"your result:{_result}");
                    break;
                    default:
                    throw new Exception("invalid input");
                }
            }
    }
}