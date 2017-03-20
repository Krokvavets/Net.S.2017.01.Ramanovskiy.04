using System;
using System.Net;
using NUnit.Framework;
using Task4;

//using NUnit.Framework;

namespace Task4.Test
{
    //[TestFixture]
    public class NUnit_Task4_Test
    {
        //[Test]
        [TestCase(25, 2)]
        [TestCase(4, 2)]
        [TestCase(27, 3)]
        [TestCase(16, 4)]
        public void Test_NewtonianMethod_Method(double A, int n, double eps=0.0001)
        {
            Assert.AreEqual((int)Task4.NewtonianMethod(A,n,eps),Math.Pow(A,(double)1/n));
        }
    }
}