using System;

namespace QuickSort
{
    class Program
    {
        static int Pivot(int[]arr, int l, int r)
        {
            int key = arr[r];

            int i = l-1;

            for (int j = l; j < r; j++)
            {
                if (arr[j] < key)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            i = i + 1;
            Swap(arr, i, r);
            return i;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void QuickSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int pi = Pivot(arr, l, r);
                QuickSort(arr, l, pi - 1);
                QuickSort(arr, pi + 1, r);
            }            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort Example");
            int[] arrToSort = new int[] { 3, 4, 1, 2, 10, 5 };
            Console.WriteLine(string.Join(", ", arrToSort));
            QuickSort(arrToSort, 0, arrToSort.Length -1);
            Console.WriteLine(string.Join(", ", arrToSort));
        }
    }
}
