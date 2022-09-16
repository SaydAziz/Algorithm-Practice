using System;
using System.Collections;

namespace Algorithms
{
    static class Assignment_1
    {
        static Stack names = new Stack() {};
        static string[,] nameSquareArray = new string[,] { {"Sarah", "Sanjar", "Sam"}, {"Bob", "Beth", "Ben"}, {"Amy", "Arnold", "Anthony"} };   

        public static void AddNameToStack(string name)
        {
            //O(1) because no matter what input you use, it will still only do one operation and will not ever take longer.
            names.Push(name);
            Console.WriteLine(name + " has been added.\n");
        }

        
        public static void PrintNameStack()
        {
            //O(n) because the size of the array is equal to the amount of times it will perform the opperation so the time it takes 
            //to complete the algorithm will scale linearly.
            Console.WriteLine("Printing list of names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void PrintSquare()
        {
            //O(n^2) because each time the operation goes through an element, it actually has to go through the same amount
            //of elements within said element, the time will quadratically increase. If there are 9 elements, each one of those will
            //have 9 elements inside. This means that the size of the array n will always be multiplied by the amount of elements
            //inside one element n (n*n). This gives us O(n*n) or O(n^2). 
            Console.WriteLine("\nPrinting square array.");
            foreach (string name in nameSquareArray)
            {
                Console.WriteLine(name);
            }
        }
    }
}