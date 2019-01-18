using System;
using System.Collections.Generic;

namespace SortingAlgorithmLibrary
{
    public class MergeSort<T> where T : IComparable
    {
        public static void Sort(IList<T> collection)
        {
            Sort(collection, 0, collection.Count - 1);
        }
        public static void Sort(IList<T> collection, int left, int right)
        {
            if (left < right)
            {
                int mid = (int)Math.Floor((left + right) / 2.0);
                Sort(collection, left, mid);
                Sort(collection, mid + 1, right);
                MergeSortAux(collection, left, mid, right);

            }
        }

        private static void MergeSortAux(IList<T> collection, int left, int mid, int right)
        {
            int arr_1_len = mid - left + 1;
            int arr_2_len = right - mid;

            IList<T> arr_1 = new List<T>();
            IList<T> arr_2 = new List<T>();

            for (int i = 0; i < arr_1_len; i++)
            {
                arr_1.Add(collection[left + i]);
            }

            for (int i = 0; i < arr_2_len; i++)
            {
                arr_2.Add(collection[mid + i + 1]);
            }


            int arr_1_index = 0;
            int arr_2_index = 0;
            int collection_index = left;


            // The following algorithm was modified from the Geeks for Geeks algorithm
            // I was 'this' close to getting it right... but alas I just could figure out
            // how to manipulate the final arrays perfectly so credit goes to them.

            while (arr_1_index < arr_1.Count && arr_2_index < arr_2.Count)
            {

                if (arr_1[arr_1_index].CompareTo(arr_2[arr_2_index]) <= 0)
                {
                    collection[collection_index] = arr_1[arr_1_index];
                    arr_1_index++;
                }
                else
                {
                    collection[collection_index] = arr_2[arr_2_index];
                    arr_2_index++;
                }
                collection_index++;

            }

            // Copies remaining elements from first temp array
            while (arr_1_index < arr_1.Count)
            {
                collection[collection_index] = arr_1[arr_1_index];
                arr_1_index++;
                collection_index++;
            }
            // Copies remaining elements from second temp array
            while (arr_2_index < arr_2.Count)
            {
                collection[collection_index] = arr_2[arr_2_index];
                arr_2_index++;
                collection_index++;
            }
        }

    }
}
