using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class Assignment_3
    {

        public static string[] storeArray() //Sets out a contiguous adjacent set of memory to store multiple elements of the same type. Insertion and deletion can occure at any index.
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "names.txt");
            string[] namesArray = File.ReadAllLines(filePath);
            return namesArray;
        } // Use cases: Arrays can have duplicate values, and can be easily editted and iterrated through at anytime.

        public static void storeDictionary() //Stores elements with a value and a key. The value is accesed by referencing the key that corresponds to it.
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Capitals.txt");

            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(filePath);
            string[] lineSplit = new string[2];

            for (int i = 0; i < lines.Length - 1; i++)
            {
                lineSplit = lines[i].Split(',');
                countryCapitals.Add(lineSplit[0], lineSplit[1]);
            }

            Console.WriteLine("\n\nThe Capital of Uzbekistan is " + countryCapitals["Uzbekistan"]);
        } // Use cases: Dictionaries have very fast lookups and do not have to iterrate in order to find a value.

        public static void storeStack() //A data structure that uses the Last in First out principle. Your most recent entry into the stack is what will be used first. Insertion and deletion can only occur from the top of the list.
        {
            string[] names = storeArray();
            Stack<string> nameStack = new Stack<string>();

            foreach(string name in names)
            {
                nameStack.Push(name);
            }
        } // Use cases: Stacks are great for reversing an order of opperations, keeping track of most recent opperations, etc.
        public static void storeQueue() //A data structure that uses the First in Last out principle. Your most recent entry into the stack is what will be used Last. Insertion and deletion can only occur at the two ends.
        {
            string[] names = storeArray();
            Queue<string> nameQueue = new Queue<string>();

            foreach (string name in names)
            {
                nameQueue.Enqueue(name);
            }
        }
        // Use cases: Queues are very efficient at supplying values in the order that they were added.This is great to preserve the order of certain operations to reference later on, and is super efficient at supplying them.
    }
}
