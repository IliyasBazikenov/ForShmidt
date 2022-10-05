using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Введите первое число!");
                string firstTermStr  = Console.ReadLine();

                Console.WriteLine("Введите операцию!");
                string operation = Console.ReadLine();

                Console.WriteLine("Введите второе число!");
                string secondTermStr = Console.ReadLine();

                if(!double.TryParse(firstTermStr, out double firstTerm))
                {
                    Console.WriteLine("Вы ввели не число!");
                    continue;
                }

                if (!double.TryParse(secondTermStr, out double secondTerm))
                {
                    Console.WriteLine("Вы ввели не число!");
                    continue;
                }

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = calculator.Sum(firstTerm, secondTerm);
                        break;
                    case "-":
                        result = calculator.Substract(firstTerm, secondTerm);
                        break;
                    case "*":
                        result = calculator.Multiply(firstTerm, secondTerm);
                        break;
                    case "/":
                        result = calculator.Devide(firstTerm, secondTerm);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
