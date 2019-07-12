using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// Represents the infamous Bubble Sort algorithm. It is by far one
    /// of the most inefficient algorithms known to man but... it works..
    /// It's running time is in O(pow(n, 2)). My implementation is about
    /// as ugly as it gets and truly inefficient.
    /// </summary>
    /// <typeparam name="T">generic object to sort</typeparam>
    public class BubbleSort<T> : ISortingBehavior<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts a collection of items using bubble sort. Truly a marvel to behold.
        /// </summary>
        /// <param name="collection"></param>
        public void Sort( IList<T> collection )
        {
            // Holds the index of the lowest value in the remainder of the collection
            // not yet sorted.
            // TODO: add a loop invariant in docs to show why this sorting method is valid
            var nextLowestValueIndex = 0;

            for( int x = 0; x < collection.Count - 1; x++ )
            {
                nextLowestValueIndex = x;
                for( int y = x + 1; y < collection.Count; y++ )
                {
                    if(collection[nextLowestValueIndex].CompareTo(collection[y]) >= 0)
                    {
                        // If a value in the unordered part of the collection is found to
                        // be lower than that of the value at index x, its index will
                        // be stored for the swapping process.
                        nextLowestValueIndex = y;
                    }

                }

                // If the current value at index x of the collection is the lowest,
                // it will be swapped with itself. Otherwise, the current value at
                // index x will be replaced by the appropriate value which is larger
                // than or equal to x - 1 but less than what is supposed to be in x + 1
                Swap(collection, x, nextLowestValueIndex);
            }
        }

        /// <summary>
        /// Swaps two values in a collection of items based on their index positions.
        /// </summary>
        /// <param name="collection">the collection which will be modified</param>
        /// <param name="index_1">the index of the first value to be swapped</param>
        /// <param name="index_2">the index of the second value to be swapped</param>
        private void Swap( IList<T> collection, int index_1, int index_2 )
        {
            var temp = collection[index_1];
            collection[index_1] = collection[index_2];
            collection[index_2] = temp;
        }
    }
}
