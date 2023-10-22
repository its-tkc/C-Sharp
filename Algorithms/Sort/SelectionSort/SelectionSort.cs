using System;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    // This Method Implements the Selection Sort Algorithm to Sort Integer Array in Ascending Order.

    public class SelectionSort
    {
        static public void sort(int[] arr)
        {
            int temp, smallestElement = 0, index = 0;

            smallestElement = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[i])
                    {
                        smallestElement = arr[j];
                        index = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
            return;
        }
    }
}

