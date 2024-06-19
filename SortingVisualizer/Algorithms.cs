using System;
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
        // Bubble Sort avg O(N2)
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

        // Quick Sort avg O(N * logN)
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

        // Selection Sort avg O(N2)
        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int lowestVal = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[lowestVal])
                    {
                        lowestVal = j;
                    }
                }

                int holder = arr[lowestVal];
                arr[lowestVal] = arr[i];
                arr[i] = holder;
            }
            return arr;
        }

        // Heap sort Avg O(NLogN)
        public static int[] HeapSort(int[] arr)
        {
            int size = arr.Length;
            
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heap(arr, size, i);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                var temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heap(arr, i, 0);
            }
            
            return arr;
        }

        static void Heap(int[] arr, int size, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < size && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < size && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heap(arr, size, largest);
            }
        }
    }
}
