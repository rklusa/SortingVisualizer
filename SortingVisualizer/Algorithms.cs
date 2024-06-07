﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Spectre.Console;

namespace SortingVisualizer
{
    public static class Algorithms
    {
        public static int[] BubbleSort(int[] arr)
        {
            int temp;
            bool doBreak;

            for (int i = 0; i < arr.Length; i++)
            {
                doBreak = true;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        doBreak = false;
                    }
                }
                if (doBreak)
                {
                    break;
                }
            }
            return arr;
        }

        public static int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            var left = leftIndex;
            var right = rightIndex;
            var pivot = arr[left];

            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            if (leftIndex < right)
            {
                QuickSort(arr, leftIndex, right);
            }

            if (left < rightIndex)
            {
                QuickSort(arr, left, rightIndex);
            }

            return arr;
        }
    }
}
