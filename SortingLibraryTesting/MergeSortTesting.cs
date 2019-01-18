﻿using System;
using SortingAlgorithmLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingLibraryTesting
{
    [TestClass]
    public class MergeSortTesting
    {
        [TestMethod]
        public void TestSort()
        {
            var emptySet = new int[] { };
            var singleSet = new int[] { 1 };
            var dualSet = new int[] { 1, 3 };
            var disorderedSet = new int[] { 9, 3, 15, 2 };

            MergeSort<int>.Sort(emptySet);
            MergeSort<int>.Sort(singleSet);
            MergeSort<int>.Sort(dualSet);
            MergeSort<int>.Sort(disorderedSet);

            CollectionAssert.AreEqual(emptySet, new int[] { }, "I expect this set to be empty");
            CollectionAssert.AreEqual(singleSet, new int[] { 1 }, "I expect this set to be { 1 }");
            CollectionAssert.AreEqual(dualSet, new int[] { 1, 3 }, "I expect this set to be { 1, 3}");
            CollectionAssert.AreEqual(disorderedSet, new int[] { 2, 3, 9, 15 }, "I expect this set to be { 2, 3, 9, 15 }");
        }
    }
}
