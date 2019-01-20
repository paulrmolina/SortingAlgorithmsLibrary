using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithmLibrary
{
    /// <summary>
    ///  Implements a common interface for all sorting algorithms. In this case
    ///  all sorting algorithms should be able to at least do one thing: 
    ///  sort a collection of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISortingBehavior<T>
    {
        void Sort(IList<T> collection);
    }
}
