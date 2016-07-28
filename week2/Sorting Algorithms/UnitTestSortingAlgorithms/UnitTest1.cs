using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting_Algorithms;

namespace UnitTestSortingAlgorithms
{
    [TestClass]
    public class UnitTestSorting
    {

        //sorting object
        public ArraySorter sorter = new ArraySorter();

        /// <summary>
        /// tests the swap function
        /// </summary>
        [TestMethod]
        public void SwapTest()
        {
            int[] testArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 8, 9, 7, 6, 5, 4, 3, 2, 1, 0 };

            sorter.Swap(testArray, 0, 1);

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

        [TestMethod]
        public void BubbleTest()
        {
            int[] testArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.BubbleSort(testArray);

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

        [TestMethod]
        public void SelectionTest()
        {
            int[] testArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.SelectionSort(testArray);

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

        [TestMethod]
        public void InsertionTest()
        {
            int[] testArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.InsertionSort(testArray);

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

        [TestMethod]
        public void MergeTest()
        {
            int[] testArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            sorter.MergeSort(testArray);

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

        [TestMethod]
        public void MergeSortedArraysTest()
        {
            int[] testArray = { 1, 3, 5, 7, 9, 0, 2, 4, 6, 8,};
            sorter.MergeSortedArrays(testArray, 0, 4, 5, 9);

            int[] expectedArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            CollectionAssert.AreEqual(testArray, expectedArray);
        }

    }
}
