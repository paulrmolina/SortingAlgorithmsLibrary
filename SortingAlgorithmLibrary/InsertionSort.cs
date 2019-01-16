using System;
using System.Collections.Generic;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// This class represents Insertion Sort. It mimics sorting as one would with a stack of cards.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertionSort<T> where T : IComparable<T>
    {
        public static void Sort(IList<T> collection)
        {
            for (int j = 1; j < collection.Count; j++)
            {
                T key = collection[j];

                int i = j - 1;
                while( i > -1 && (collection[i].CompareTo(key) > 0))
                {
                    collection[i + 1] = collection[i];
                    i = i - 1;
                }
                collection[i + 1] = key;
            }
        }
    }
}
