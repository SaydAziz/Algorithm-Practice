using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment_1.AddNameToStack("John"); 
            Assignment_1.AddNameToStack("Sarah"); 
            Assignment_1.AddNameToStack("Bob"); 

            Assignment_1.AddNameToStack("Vanya"); // O(1)
            Assignment_1.PrintNameStack(); // O(n)
            Assignment_1.PrintSquare(); // O(n^2)
        }
    }
}