using System;
using System.Collections.Generic;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// Represents selection sort which has a complexity of O(n^2) in the best and worst
    /// case. This sorting algorithm is not good for large items.
    /// </summary>
    public class SelectionSort<T> : ISortingBehavior<T> where T : IComparable<T>
    {
        public void Sort( IList<T> collection )
        {
            int smallestMemberIndex;
            T temp;

            for( int x = 0; x < collection.Count - 1; x++ )
            {
                // The smallest member in the remaining set is the following number
                // for now
                smallestMemberIndex = x;
                
                // Iterate through the array and find the next smallest number
                for( int y = x + 1; y < collection.Count; y++ )
                {
                    if( collection[y].CompareTo(collection[smallestMemberIndex]) < 0 )
                    {
                        smallestMemberIndex = y;
                    }
                }

                // Do the swap now that we've found the lowest member
                temp = collection[x];
                collection[x] = collection[smallestMemberIndex];
                collection[smallestMemberIndex] = temp;
            }


        }
    }
}
