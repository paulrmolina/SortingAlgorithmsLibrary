using System;
using System.Collections.Generic;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// This class represents John von Neumann's Merge Sort algorithm which runs in
    /// O(n * lg(n)) time in every single instance. This algorithm sorts a collection of 
    /// values recursively. It accomplishes this by splitting a deck into two halves
    /// and then simply continuing this process until it gets to the bottom. Once it is 
    /// donesplitting, it will trivially sort the single value left at the bottom of the 
    /// recursive call as it is already sorted. One level higher and it creates two arrays 
    /// and it will start sorting based on which values is smaller in both arrays at the time. 
    /// This process will continue in higher and higher levels until the left side of the 
    /// collection has been sorted before the process begins on the right hand side.
    /// </summary>
    /// <typeparam name="T">generic object to sort</typeparam>
    public class MergeSort<T> : ISortingBehavior<T> where T : IComparable<T>
    {
        /// <summary>
        /// Generic implementation to ensure it fits the ISortBehavior interface.
        /// </summary>
        /// <param name="collection">collection of items to be sorted</param>
        public void Sort(IList<T> collection)
        {
            Sort(collection, 0, collection.Count - 1);
        }

        /// <summary>
        /// Recursive Merge Sort call. Solves in O(n * lg(n)) time in every
        /// instance but Quicksort tends to be a little quesicker.
        /// </summary>
        /// <param name="collection">collection of items to be sorted</param>
        /// <param name="left">leftmost index of the current collection to sort</param>
        /// <param name="right">rightmost index of the current collection to sort</param>
        private static void Sort(IList<T> collection, int left, int right)
        {
            if (left < right)
            {
                // Find midpoint of current collection of values to be sorted.
                int mid = (int)Math.Floor((left + right) / 2.0);
                // Recursively call method on left half
                Sort(collection, left, mid);
                // Recursively call method on right half
                Sort(collection, mid + 1, right);
                // Start merging at the bottom of the call sorting in bottom-up fashion
                MergeSortAux(collection, left, mid, right);

            }
        }


        private static void MergeSortAux(IList<T> collection, int left, int mid, int right)
        {
            // Grabs the length of both halves of the deck based on index positions
            int temp_arr_1_len = mid - left + 1;
            int temp_arr_2_len = right - mid;

            // Create two temporary arrays to hold both halves of the current deck to organize
            IList<T> temp_arr_1 = new List<T>();
            IList<T> temp_arr_2 = new List<T>();

            // Add all values from left side of deck to the first array
            for (int i = 0; i < temp_arr_1_len; i++)
            {
                temp_arr_1.Add(collection[left + i]);
            }

            // Add all values from right side of the deck to the second array
            for (int i = 0; i < temp_arr_2_len; i++)
            {
                temp_arr_2.Add(collection[mid + i + 1]);
            }

            // Initialize the counters which begin at the beginning of the first and
            // second array as well as at the beginning of the deck. As the smallest value
            // of both arrays is found, we will overwrite the value of the original deck
            // and increase that array's position by one imagining we have removed that
            // value from the array and placed it in its correct position in the original deck.
            // The collection index will start on the left side of the deck as this indiciates
            // the beginning of the deck to start overwriting.
            int temp_arr_1_index = 0;
            int temp_arr_2_index = 0;
            int collection_index = left;


            // The following algorithm was modified from the Geeks for Geeks algorithm
            // I was 'this' close to getting it right... but alas I just could figure out
            // how to manipulate the final arrays perfectly so credit goes to them.
            while (temp_arr_1_index < temp_arr_1.Count && temp_arr_2_index < temp_arr_2.Count)
            {
                // The value on the left array is smaller. Take it out, put it in the deck
                // and continue.
                if (temp_arr_1[temp_arr_1_index].CompareTo(temp_arr_2[temp_arr_2_index]) <= 0)
                {
                    collection[collection_index] = temp_arr_1[temp_arr_1_index];
                    temp_arr_1_index++;
                }
                // The value on the right array is smaller. Take it out, put it in the deck
                // and continue
                else
                {
                    collection[collection_index] = temp_arr_2[temp_arr_2_index];
                    temp_arr_2_index++;
                }
                collection_index++;

            }

            // Copies remaining elements from first temp array
            while (temp_arr_1_index < temp_arr_1.Count)
            {
                collection[collection_index] = temp_arr_1[temp_arr_1_index];
                temp_arr_1_index++;
                collection_index++;
            }
            // Copies remaining elements from second temp array
            while (temp_arr_2_index < temp_arr_2.Count)
            {
                collection[collection_index] = temp_arr_2[temp_arr_2_index];
                temp_arr_2_index++;
                collection_index++;
            }

            // Done. This recursive call should have organized everything
            // bottom-up.
        }

    }
}
