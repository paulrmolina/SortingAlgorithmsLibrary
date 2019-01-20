using System;
using System.Collections.Generic;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// This class represents Insertion Sort. It mimics sorting as one would with a stack of cards.
    /// </summary>
    /// <typeparam name="T">generic object to sort</typeparam>
    public class InsertionSort<T> : ISortingBehavior<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int j = 1; j < collection.Count; j++)
            {
                // Grab a key starting from second index to place
                // into the correct place
                T key = collection[j];

                // Start comparing from the index right before the current key
                int i = j - 1;

                // Keep moving all values that are greater than this key to the right
                // until we get to the end or the key is found to be greater than the
                // number it's being compared to
                while( i > -1 && (collection[i].CompareTo(key) > 0))
                {
                    collection[i + 1] = collection[i];
                    i = i - 1;
                }
                // We either got to the end or we found a number that's smaller than or equal
                // to the key. Let's put the key right after this number to put it in the right place.
                // NOTE: The key will be overwriting a number that's already been moved to the right
                //       so we are not actually losing any values
                collection[i + 1] = key;
            }
        }
    }
}
