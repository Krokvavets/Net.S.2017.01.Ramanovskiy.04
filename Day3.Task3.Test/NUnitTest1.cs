using System;
using NUnit.Framework;
using Task3;

namespace Day3.Task3.Test
{
    //[TestFixture]
    public class NUnit_Task3_Test
    {

        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(0, 15, 30, 30, 1073741824)]
        [TestCase(0, 15, 0, 30, 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, 63)]
        [TestCase(15, 15, 1, 3, 15)]
        [TestCase(15, 15, 1, 4, 31)]
        [TestCase(15, -15, 0, 4, 31)]

        public void Insertion_PositiveTest( int targetNumber, int insert, int i, int j, int  ExpectedResult)
        {
            Assert.AreEqual(global::Task3.Task3.Insertion(targetNumber, insert, i, j), ExpectedResult);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 31, 5)]
        [TestCase(8, 15, 5, 31)]
        public void Insertion_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => global::Task3.Task3.Insertion(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void Insertion_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => global::Task3.Task3.Insertion(first, second, startPosition, finishPosition));
        }
    }


}
