using System;

namespace MergeSort
{
    class Program
    {
        static void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }

        static void Merge(int[] arr, int l, int m, int r)
        {
            int[] leftArr = new int[m-l+1];
            int[] rightArr = new int[r - m];

            int i = 0; int j = 0;
            for (i =0; i < (m-l+1); i++)
            {
                leftArr[i] = arr[l + i];
            }

            for (j = 0; j < (r-m); j++)
            {
                rightArr[j] = arr[m+1+j];
            }

            i = 0; j = 0;int k = l;
            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] < rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            if (i < leftArr.Length)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            if (j < rightArr.Length)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort Example");
            int[] arrToSort = new int[] { 3, 4, 1, 2, 10, 5};
            Console.WriteLine(string.Join(", ", arrToSort));

            Sort(arrToSort, 0, arrToSort.Length - 1);

            Console.WriteLine(string.Join(", ", arrToSort));
        }
    }
}
