using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithmLibrary;

namespace SortingLibraryTesting
{
    [TestClass]
    public class BubbleSortTesting
    {
        [TestMethod]
        public void TestSort()
        {
            var emptySet = new int[] { };
            var singleSet = new int[] { 1 };
            var dualSet = new int[] { 1, 3 };
            var dualDisorderedSet = new int[] { 38, 3 };
            var disorderedSet = new int[] { 3, 9, 3, 15, 2 };

            var test = new BubbleSort<int>();
            test.Sort(emptySet);
            test.Sort(singleSet);
            test.Sort(dualSet);
            test.Sort(dualDisorderedSet);
            test.Sort(disorderedSet);

            CollectionAssert.AreEqual(emptySet, new int[] { }, "I expect this set to be empty");
            CollectionAssert.AreEqual(singleSet, new int[] { 1 }, "I expect this set to be { 1 }");
            CollectionAssert.AreEqual(dualSet, new int[] { 1, 3 }, "I expect this set to be { 1, 3 }");
            CollectionAssert.AreEqual(dualDisorderedSet, new int[] { 3, 38 }, "I expect this to be { 3, 38 }");
            CollectionAssert.AreEqual(disorderedSet, new int[] { 2, 3, 3, 9, 15 }, "I expect this set to be { 2, 3, 3, 9, 15 }");
        }
    }
}
