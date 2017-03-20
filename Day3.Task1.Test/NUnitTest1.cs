using System;
using NUnit.Framework;
using Task1;

namespace Day3.Task1.Test
{
    //[TestFixture]
    public class NUnit_Task1_Test
    {
        //[Test]
        [TestCase(3, 1, 2, 3, 4, 3, 2, 1)]
        [TestCase(1, 1, 100, 50, -51, 1, 1)]
        public void Test_Calculation_Method(int ExpectedResult, params int[] args)
        {
            int[] secondArray = (int[])args.Clone();
            Array.Sort(secondArray);
            Assert.AreEqual(ExpectedResult, args.Calculation());
        }
    }
}