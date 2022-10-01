using AlgorithmsLibrary.Models;
using AlgorithmsLibrary.Sort;

namespace AlgorithmsTest
{
    public class InsertSortTests
    {
        SortBase sorter;
        [SetUp]
        public void Setup()
        {
            sorter = new Insertion();
        }

        [Test]
        public void Test1()
        {
            var seq = new int[]
            {
                2, 6, 4
            };

            sorter.Sort(seq);

            CollectionAssert.AreEqual(new int[]
            {
                2, 4, 6
            }, seq);
        }

        [Test]
        public void Test2()
        {
            var seq = new int[]
            {
                2, 4, 6, 7, 1, 3, 5
            };

            sorter.Sort(seq);

            CollectionAssert.AreEqual(new int[]
            {
                1, 2, 3, 4, 5, 6, 7
            }, seq);
        }

        [Test]
        public void Test3()
        {
            var seq = new int[]
            {
                2, 2, 6, 7, 1, 3, 5
            };

            sorter.Sort(seq);

            CollectionAssert.AreEqual(new int[]
            {
                1, 2, 2, 3, 5, 6, 7
            }, seq);
        }
    }
}