using System;

namespace InsertionSort
{
    class Program
    {
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int ri = i - 1;
                while (ri >= 0 && arr[ri] > key)
                {
                    arr[ri + 1] = arr[ri];
                    ri--;
                }

                arr[ri + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort Example");
            int[] arrToSort = new int[] { 3, 4, 1, 2, 10, 5 };
            Console.WriteLine(string.Join(", ", arrToSort));
            InsertionSort(arrToSort);
            Console.WriteLine(string.Join(", ", arrToSort));
        }
    }
}
