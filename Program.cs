using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            Math();
        }
        static void Math()
        {
            int result;

            var dictionary = new Dictionary<long, string>();
            #region
            dictionary.Add(1, "One");
            dictionary[10] = "Ten";
            dictionary[100] = "1 Hundred";
            dictionary[1_000] = "1 thousand";
            dictionary[10_000] = "10 thousands";
            dictionary[100_000] = "100 thousands";
            dictionary[100_000_0] = "1 million";
            dictionary[100_000_00] = "10 millions";
            dictionary[100_000_000] = "100 millions";
            dictionary[1_000_000_000] = "1 billion";
            dictionary[10_000_000_000] = "10 billions";
            dictionary[100_000_000_000] = "100 billions";
            dictionary[1_000_000_000_000] = "1 trillion";
            dictionary[10_000_000_000_000] = "10 trillions";
            dictionary[100_000_000_000_000] = "100 trillions";
            dictionary[1_000_000_000_000_000] = "1 quadrillion";
            dictionary[10_000_000_000_000_000] = "10 quadrillions";
            dictionary[100_000_000_000_000_000] = "100 quadrillions";
            #endregion числа

            WriteLine("Введи первое число");
            int digit = int.Parse(ReadLine());

            WriteLine("Введи операцию");
            string operation = ReadLine();

            WriteLine("Введи второе число");
            int digitTwo = int.Parse(ReadLine());

            switch (operation)
            {
                case "-":
                    result = digit - digitTwo;
                    WriteLine($"{dictionary[digit]} {operation} {dictionary[digitTwo]} = {result}");
                    break;
                case "+":
                    result = digit + digitTwo;
                    WriteLine($"{dictionary[digit]} {operation} {dictionary[digitTwo]} = {result}");
                    break;
                case "*":
                    result = digit * digitTwo;
                    WriteLine($"{dictionary[digit]} {operation} {dictionary[digitTwo]} = {result}");
                    break;
                case "/":
                    result = digit / digitTwo;
                    WriteLine($"{dictionary[digit]} {operation} {dictionary[digitTwo]} = {result}");
                    break;
                default:
                    WriteLine("Нажми корректеный знак операции");
                    break;
            }
        }
    }
}
