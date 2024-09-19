using System;

namespace Project_Program_104
{
    class Array
    {
        public static void Main(string[] args)
        {


            string[] fruits = { "Lanzones", "Peach", "Grapes", "Apple", "Orange" };
            Console.WriteLine(fruits[0]);

            // for loop through an array

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //output Volvo BMW Ford Mazda

            // foreach loop 

            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            //output Volvo BMW Ford Mazda


            

            // Sort an array

            // Sort a string
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars2);
            foreach (string i in cars2)
            {
                Console.WriteLine(i);
            }

            // Can only be used in PUBLIC STATIV VOID SORT (STRING[] mynumber)

            // Sort an int
            int[] num1 = { 5, 1, 8, 9 };
            Array.Sort(num1);
            foreach (int i in num1)
            {
                Console.WriteLine(i);
            }
            

            // output BMW ford Mazda Volvo 1 5 8 9
    
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // largest value
            Console.WriteLine(myNumbers.Min());  // smallest value
            Console.WriteLine(myNumbers.Sum());  // sum of myNumbers

            //output 9 1 23

            // can work on System.Linq;
            int[] myNumber1s = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements




            //TWO DIMENTIONAL ARRAYS

            //Good to know: The single comma [,] specifies that the array is two-dimensional.
            //A three-dimensional array would have two commas: int[,,].

            // access elements of a 2D Array 

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2



            // Change elements of a 2D Array

            int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5;  // Change value to 5  // rows, column
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1  // rows, coloumns 




            //Loop Through a 2D Array 
            // foreach

            int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            // multidimensional Arrays (forloop)

            int[,] numbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);

                }
            }
        }
    }
}
*/
