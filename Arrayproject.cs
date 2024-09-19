using System;
using System.Transactions;

/*
namespace Project_Program_104
{
    internal class Arrayproject
    {

        public static void Main(string[] args)
        {
            // Array always starts at 0

            string name, sec;
            int sub;
            string[] subject;
            decimal grade = 0;
            decimal total = 0;
            decimal average = 0;

   

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Grade & Section: ");
            sec = Console.ReadLine();
            Console.Write("How many subjects do you have to take: ");
            sub = Convert.ToInt32(Console.ReadLine());

            subject = new string[sub]; 

            for (int i = 0; i < sub; i++) 
            {
                Console.Write($"Enter subject number " + (i + 1) + ": ");
                subject[i] = Console.ReadLine();
                
            }


            for (int j = 0; j < sub; j++)
            {
                Console.Write($"Enter your grades in {subject[j]} = ");
                grade = Convert.ToDecimal(Console.ReadLine());

                
                total += grade;
            }

            average = total / sub;
            Console.WriteLine("\nYour average is: " + average);

            Console.WriteLine($"\nHi, {name}. So you're a {sec} taking the following \nsubjects:");
            Console.WriteLine(string.Join(", ", subject) + "." + "\nWe wish you the best in passing all of these!");

            Console.ReadKey();
        }
    }
}
*/