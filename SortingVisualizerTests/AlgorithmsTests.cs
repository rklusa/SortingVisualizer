using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingVisualizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer.Tests
{
    [TestClass()]
    public class AlgorithmsTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            // arrange
            int[] testArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            // act
            int[] sortedTestArray = Algorithms.BubbleSort(testArray, 0, 0);
            // assert
            CollectionAssert.AreEqual(testArray, sortedTestArray);
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            // arrange
            int[] testArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // act
            int[] sortedTestArray = Algorithms.QuickSort(testArray, 0, testArray.Length - 1);
            // assert
            CollectionAssert.AreEqual(testArray, sortedTestArray);
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            // arrange
            int[] testArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // act
            int[] sortedTestArray = Algorithms.SelectionSort(testArray, 0, 0);
            // assert
            CollectionAssert.AreEqual(testArray, sortedTestArray);
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // arrange
            int[] testArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // act
            int[] sortedTestArray = Algorithms.HeapSort(testArray, 0, 0);
            // assert
            CollectionAssert.AreEqual(testArray, sortedTestArray);
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            int[] testArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            // act
            int[] sortedTestArray = Algorithms.ShellSort(testArray, 0, 0);
            // assert
            CollectionAssert.AreEqual(testArray, sortedTestArray);
        }
    }
}