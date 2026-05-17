using System;

namespace CalculatorApp
{
    // 1) Interface
    public interface ICalculation
    {
        double Calculate(double a, double b, string operation);
    }

    // 2) Class (interface-i implement edir)
    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("0-a bölmek olmaz");
                        return 0;
                    }
                    return a / b;

                default:
                    Console.WriteLine("Yanlış emeliyyatdir");
                    return 0;
            }
        }
    }

    // 3) Main proqram
    class Program
    {
        static void Main(string[] args)
        {
            ICalculation calc = new Calculation();

            Console.Write("1-ci ededi daxil et: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emeliyyatı daxil edin (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("2-ci ededi daxil et: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = calc.Calculate(a, b, op);

            Console.WriteLine("Netice: " + result);

            Console.ReadKey();
        }
    }
}