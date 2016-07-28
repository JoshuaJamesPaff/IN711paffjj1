using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    /// <summary>
    /// contains different sorting classes and a function to generate random array
    /// </summary>
    public class ArraySorter
    {
        // maximum value for each value in array
        public const int MAX_ARRAY_VALUE = 999;

        /// <summary>
        /// generates array of random numbers between 0 and 999 of a specified size 
        /// </summary>
        /// <param name="arraySize">size of array to be returned</param>
        /// <returns>array of random integers</returns>
        public int[] CreateRandomArray(int arraySize)
        {
            Random rand = new Random();

            int[] randArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                randArray[i] = rand.Next(MAX_ARRAY_VALUE);
            }

            return randArray;
        }

        /// <summary>
        /// swaps 2 elements in an array of ints
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="index1">index of first item to swap</param>
        /// <param name="index2">index of second item to swap</param>
        public void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        /// <summary>
        /// Bubble sort method
        /// </summary>
        /// <param name="array">unsorted array</param>
        /// <returns>sorted array</returns>
        public int[] BubbleSort(int[] array)
        {
            //loops the array swapping elements
            for (int j = 0; j < array.Length; j++)
            {                
                for (int i = 1; i < array.Length; i++)
                {
                    //swaps adjacent elements so they are in order
                    if (array[i] < array[i - 1])
                    {
                        Swap(array, i, i - 1);
                    }
                }
            }               
            return array;
        }

        /// <summary>
        /// Selection sort method
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>sorted array</returns>
        public int[] SelectionSort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int highestIndex = 0;
                int highestValue = 0;

                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[i] > highestValue)
                    {
                        highestValue = array[i];
                        highestIndex = i;
                    }
                }
                Swap(array, array.Length - j -1, highestIndex);
            }
            return array;
        }

        /// <summary>
        /// Insertion sort method
        /// </summary>
        /// <param name="array">input array</param>
        /// <returns>sorted array</returns>
        public int[] InsertionSort(int[] array) 
        {
            //holds number being moved to sorted portion of the list
            int temp = 0;

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                array[i] = array[i - 1];

                for (int j = i; j >= 0; j--)
                {

                    if (j!=0 && temp < array[j -1])
                    {
                        array[j] = array[j-1];
                    }
                    else
                    {
                        array[j] = temp;
                        j = 0;
                    }
                }
            }
            return array;
        }


        public int[] MergeSort(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int groupSize = 1;
            while (groupSize < array.Length)
            {
                for (int i = 0; i < array.Length / groupSize; i += groupSize+1)
                {
                    //int[] temp1 = array[i];
                }
                    groupSize *= 2;
            }
            return array;
        }


        /// <summary>
        /// combines two sorted arrays into one sorted array
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns>sorted array</returns>
        public void MergeSortedArrays(int[] array, int lb1, int ub1, int lb2, int ub2){

            //new array of combined length
            int halfLength = ub1 - lb1;
            int length = halfLength *2;
            int[] newArray = new int[length];

            //loop counters
            int a1Counter = 0;
            int a2Counter = 0;
            int index = 0;

            //loops both arrays until one of them is ended
            while (a1Counter < halfLength && a2Counter < halfLength)
            {
                if (array[lb1 + a1Counter] <= array[lb2 + a2Counter])
                {
                    newArray[index] = array[lb1 + a1Counter];
                    index++;
                    a1Counter++;
                }

                if (array[lb1 + a1Counter] > array[lb2 + a2Counter])
                {
                    newArray[index] = array[lb2 + a2Counter];
                    index++;
                    a2Counter++;
                }
            }

            //adds remaining items from the array with the lowest counter
            if (a1Counter > a2Counter)
            {
                for (int i = a2Counter; i < a1Counter; i++)
                {
                    newArray[index] = array[lb2 +i];
                    index++;
                }
            }
            else
            {
                for (int i = a1Counter; i < a2Counter; i++)
                {
                    newArray[index] = array[lb1 + i];
                    index++;
                }
            }

            //adds sorted array in position of unsorted portion
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i + lb1] = newArray[i];
            }

        }
    }
}
