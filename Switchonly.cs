using System;
using System.Numerics;
/*
namespace Program_103_1
{
    class Program_103
    {
        public static void Main(string[] args)
        {
            int num1, num2, result;
            string operation;
            bool isValid;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter first number: ");
                isValid = int.TryParse(Console.ReadLine(), out num1);
            }
            while (isValid == false);

            do
            {
                Console.Clear();
                Console.WriteLine("Enter second number: ");
                isValid = int.TryParse(Console.ReadLine(), out num2);
            }
            while (isValid == false);

            do
            {
                Console.Clear();
                Console.WriteLine("Choose an operator ex. +, *, -,/");
                operation = Console.ReadLine();
                isValid = operation == "+" || operation == "*" || operation == "-" || operation == "/";
            }
            while (isValid == false);


            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;


            }
            Console.ReadKey();
        }
    }
}
*/