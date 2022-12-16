using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Formats.Asn1.AsnWriter;

namespace Algorithms
{
    static class Assignment_5
    {
        private static System.Timers.Timer timer;
        private static int elapsedTime;
        private static int a, b, c;
        public static void LinearSearch(int[] array, int value)
        {
            Console.WriteLine("Linear Search:");
            SetTimer();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    a = elapsedTime;
                    timer.Stop();
                    timer.Dispose();
                    Console.WriteLine(value + " is located in array index " + i);
                    return;
                }
            }

            a = elapsedTime;
            timer.Stop();
            timer.Dispose();
            Console.WriteLine(value + " was not found in the array.");
            
        }

        public static void BinarySearch(int[] arr, int value)
        {
            

            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        unsorted = true;
                    }
                }
            }

            Console.WriteLine("Binary Search:");
            SetTimer();
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == value)
                {
                    b = elapsedTime;
                    timer.Stop();
                    timer.Dispose();
                    Console.WriteLine(value + " is located in array index " + mid) ;
                    return;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            b = elapsedTime;
            timer.Stop();
            timer.Dispose();

            Console.WriteLine(value + " was not found in the array.");
        }

        public static void InterpolationSearch(int[] arr, int value)
        {

            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        unsorted = true;
                    }
                }
            }

            Console.WriteLine("Interpolation Search:");
            SetTimer();
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right && value >= arr[left] && value <= arr[right])
            {
                int mid = left + (right - left) * (value - arr[left]) / (arr[right] - arr[left]);
                if (value < arr[mid])
                {
                    right = mid - 1;
                }
                else if (value > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    b = elapsedTime;
                    timer.Stop();
                    timer.Dispose();
                    Console.WriteLine(value + " is located in array index " + mid);
                    return;
                }
            }
            b = elapsedTime;
            timer.Stop();
            timer.Dispose();
            Console.WriteLine(value + " was not found in the array.");
        }



        public static void ShowSummary()
        {
            Console.WriteLine("\nSUMMARY OF ALGORITHM TIMES: \n");
            Console.WriteLine("Linear Search: " + a + " milliseconds.");
            Console.WriteLine("Binary Search: " + b + " milliseconds.");
            Console.WriteLine("Interpolation Search: " + c + " milliseconds.");
        }

        private static void SetTimer()
        {
            elapsedTime = 0;
            timer = new System.Timers.Timer(1);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            elapsedTime++;
        }
    }
}
