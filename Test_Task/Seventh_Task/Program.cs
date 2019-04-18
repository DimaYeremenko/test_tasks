using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var arrayLength = 500000;

            var initArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                initArray[i] = random.Next(i);
            }

            Stopwatch watch = new Stopwatch();
            var forBubble = initArray.Clone() as int[];
            watch.Start();
            BubbleSort(forBubble);
            watch.Stop();

            Console.WriteLine($"Bubble sort for {arrayLength} items - {watch.Elapsed.TotalSeconds} sec");

            watch.Reset();
            watch.Start();
            MergeSort(initArray);
            watch.Stop();

            Console.WriteLine($"MergeSort sort for {arrayLength} items - {watch.Elapsed.TotalSeconds} sec");

            Console.ReadKey();
        }

        private static void BubbleSort(int[] arr)
        {
            int left = 0,
                right = arr.Length - 1,
                count = 0;

            while (left <= right)
            {
                for (int i = left; i < right; i++)  
                {
                    count++;
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1); 
                    }
                }
                right--;

                for (int i = right; i > left; i--) 
                {
                    count++;
                    if (arr[i - 1] > arr[i])
                    {
                        Swap(arr, i - 1, i);
                    }
                }
                left++; 
            }
        }

        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        private static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middle = array.Length / 2;
            return Merge(MergeSort(array.Take(middle).ToArray()), MergeSort(array.Skip(middle).ToArray()));
        }

        static int[] Merge(int[] arr1, int[] arr2)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; ++i)
            {
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }

            return merged;
        }
    }
}
