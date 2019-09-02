using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    /// Represents the awesome Quick Sort sorting algorithm. This algorithm is sickly
    /// efficient and has a run time of O( n log n ) at best and O( n^2 ) at worst.
    /// </summary>
    public class QuickSort<T>: ISortingBehavior<T> where T : IComparable<T>
    {
        public void Sort( IList<T> collection )
        {
            // Sort( collection, 0, collection.Count - 1);
        }

        public void Sort( IList<T> collection, int low, int high )
        {
            int partition;

            if( low < high )
            {
                partition = Partition( collection, low, high );
                Sort( collection, low, partition - 1);
                Sort( collection, partition + 1, high );
            }
        }

        public int Partition( IList<T> collection, int low, int high )
        {
            T temp;
            T pivot = collection[high];
            int i = low;

            for( int x = low; x < high - 1; x++ )
            {
                if( collection[x].CompareTo(pivot) < 0 )
                {
                    temp = collection[i];
                    collection[i] = collection[x];
                    collection[x] = temp;
                    i++;
                }
            }

            temp = collection[i];
            collection[i] = collection[high];
            collection[high] = temp;

            return i;
        }
    }
}
