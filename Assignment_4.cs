using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Schema;

namespace Algorithms
{
    static class Assignment_4
    {
        private static System.Timers.Timer timer;
        private static int elapsedTime;

        private static int a, b, c, d, e, f;

        public static int[] ParseScores()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "scores.txt");
            string[] scoresString = File.ReadAllLines(filePath);
            int[] scores = Array.ConvertAll(scoresString, int.Parse);
            return scores;
        }

        static void PrintScores(int[] scores)
        {
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        public static void BubbleSort(int[] scores)
        {
            Console.WriteLine("Bubble Sort:");
            SetTimer();

            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 1; i < scores.Length; i++)
                {
                    if (scores[i] < scores[i - 1])
                    {
                        int temp = scores[i];
                        scores[i] = scores[i - 1];
                        scores[i - 1] = temp;
                        unsorted = true;
                    }
                }
            }
            PrintScores(scores);

            a = elapsedTime;
            timer.Stop();
            timer.Dispose();


        }

        public static void InsertionSort(int[] scores)
        {
            Console.WriteLine("Insertion Sort:");
            SetTimer();
            for (int i = 1; i < scores.Length; i++)
            {
                int cache = scores[i];
                int j = i - 1;

                while (j >= 0 && scores[j] > cache)
                {
                    scores[j + 1] = scores[j];
                    j--;
                }

                scores[j + 1] = cache;
            }
            PrintScores(scores);

            b = elapsedTime;
            timer.Stop();
            timer.Dispose();
        }

        public static void SelectionSort(int[] scores)
        {
            Console.WriteLine("Selection Sort:");
            SetTimer();
            int n = scores.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[min])
                    {
                        min = j;
                    }

                }
                int cache = scores[min];
                scores[min] = scores[i];
                scores[i] = cache;
            }
            PrintScores(scores);
            c = elapsedTime;

            timer.Stop();
            timer.Dispose();
        }

        public static void HeapSort(int[] scores)
        {
            Console.WriteLine("Heap Sort:");
            SetTimer();
            int n = scores.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(scores, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = scores[0];
                scores[0] = scores[i];
                scores[i] = temp;
                Heapify(scores, i, 0);
            }
            PrintScores(scores);

            d = elapsedTime;

            timer.Stop();
            timer.Dispose();

        }

        public static void QuickSort(int[] scores)
        {
            Console.WriteLine("Quick Sort:");
            int n = scores.Length;
            SetTimer();
            PrintScores(scores);

            doQuickSort(scores, 0, n - 1);
            timer.Stop();
            timer.Dispose();

            e = elapsedTime;


        }

        public static void MergeSort(int[] scores)
        {
            Console.WriteLine("Merge Sort:");
            int n = scores.Length;
            SetTimer();
            doMergeSort(scores, 0, n - 1);
            PrintScores(scores);

            f = elapsedTime;
            timer.Stop();
            timer.Dispose();

        }

        public static void ShowSummary()
        {
            Console.WriteLine("\nSUMMARY OF ALGORITHM TIMES: \n");
            Console.WriteLine("Bubble Sort: " + a + " milliseconds.");
            Console.WriteLine("Insertion Sort: " + b + " milliseconds.");
            Console.WriteLine("Selection Sort: " + c + " milliseconds.");
            Console.WriteLine("Heap Sort: " + d + " milliseconds.");
            Console.WriteLine("Quick Sort: " + e + " milliseconds.");
            Console.WriteLine("Merge Sort: " + f + " milliseconds.");
            
        }


        private static void doMergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                doMergeSort(arr, l, m);
                doMergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        private static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private static void doQuickSort(int[] scores, int min, int max)
        {
            if (min < max)
            {
                int part = partition(scores, min, max);
                doQuickSort(scores, min, part - 1);
                doQuickSort(scores, part + 1, max);
            }

        }

        static int partition(int[] arr, int min, int max)
        {
            int pivot = arr[max];
            int i = (min - 1);

            for (int j = min; j <= max - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int _cache = arr[i];
                    arr[i] = arr[j];
                    arr[j] = _cache;
                }
            }
            int cache = arr[i + 1];
            arr[i + 1] = arr[max];
            arr[max] = cache;
            return (i + 1);
        }


        private static void Heapify(int[] arr, int N, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < N && arr[l] > arr[largest])
            {
                largest = l;
            }

            if (r < N && arr[r] > arr[largest])
            {
                largest = r;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, N, largest);
            }
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
