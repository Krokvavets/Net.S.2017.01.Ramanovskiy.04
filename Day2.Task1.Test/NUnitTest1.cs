using System;
using NUnit.Framework;
using Net.S._2017._01.Ramanovskiy._01;

//using NUnit.Framework;

namespace Day2.Task1.Test
{
    //[TestFixture]
    public class NUnit_Task1_Test
    {
        //[Test]
        [TestCase(1,2,2,1)]
        [TestCase(5,3,6,8,1,2,100)]
        [TestCase(2017,2,3,5,2,0,7,1)]
        [TestCase(4,14,44,1)]
        public void Test_MergeSort_Method( params int[] args)
        {
            int[] secondArray = (int[]) args.Clone();
            Array.Sort(secondArray);
            Assert.AreEqual(secondArray, args.MergeSort());
        }

        [TestCase(1, 2, 2, 1)]
        [TestCase(5, 3, 6, 8, 1, 2, 100)]
        [TestCase(2017, 2, 3, 5, 2, 0, 7, 1)]
        [TestCase(4, 14, 44, 1)]
        public void Test_MergeSort_Method_AreNotEqual(params int[] args)
        {
            int[] secondArray = (int[])args.Clone();
            Assert.AreNotEqual(secondArray, args.MergeSort());
        }
    }
}