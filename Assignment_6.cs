using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Assignment_6
    {
        public static void CreateTree(int[] arr)
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

            Tree tree = new Tree(arr);

            
        }


    }
}
