using System;
using NUnit.Framework;
using Task3;
//using NUnit.Framework;

namespace Task3.Test
{
    //[TestFixture]
    public class NUnitTask3Test
    {
        //[Test]
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        [TestCase(10, -1)]
        [TestCase(20, -1)]

        public void Test_NextBiggerNumber_Method( int number, int ExpectedResult)
        {
            Assert.AreEqual(ExpectedResult, Task3.NextBiggerNumber(number));
        }
    }
}