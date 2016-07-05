using NUnit.Framework;
using System;
using System.Collections.Generic;
using ClassLibraryLogicEuclid;

namespace ClassLibraryEuclidNunit
{
    [TestFixture]
    public class LogicEuclidNunitTests
    {
        private static IEnumerable<TestCaseData> InputValues()
        {
            yield return new TestCaseData(-155, 25);
            yield return new TestCaseData(155, 25);
            yield return new TestCaseData(-155, -25);
        }

        private static IEnumerable<TestCaseData> InputValuesWith1()
        {
            yield return new TestCaseData(1, 38);
            yield return new TestCaseData(47, 1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclidMethodTest_GCDof0and0_ReturnedException()
        {
            int a = 0;
            int b = 0;

            Euclid.EuclidMethod(a, b);
        }

        [TestCase(1, 96)]
        [TestCase(12, 1)]
        public void EuclidMethodTest_GCDOneOfNumberEqual1_Returned1(int a, int b)
        {

            int expected = 1;

            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [Test]
        public void EuclidMethodTest_GCDof0and96_Returned96()
        {
            int a = 0;
            int b = 96;

            int expected = 96;

            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [Test, TestCaseSource("InputValues")]
        public void EuclidMethod_TestGcdNegative155Positiv25_Returned5(int a, int b)
        {
            int expected = 5;

            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestCase(15, 18, 27, 69)]
        public void EuclidMethodTest_GCDofParamsInt_Returned3(params int[] values)
        {

            int expected = 3;

            int actual = Euclid.EuclidMethod(values);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void SteinMethodTest_GcDof0And0_ReturnedException()
        {
            int a = 0;
            int b = 0;

            Euclid.SteinMethod(a, b);
        }

        [Test]
        public void SteinMethodTest_GCDof0and15_Returned15()
        {
            int a = 0;
            int b = 15;

            int expected = 15;

            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [Test, TestCaseSource("InputValues")]
        public void SteinMethodTest_GCDNegative155Positiv25_Returned5(int a, int b)
        {
            int expected = 5;

            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [Test, TestCaseSource("InputValuesWith1")]
        public void SteinMethodTest_GCDOneOfNumberEqual1_Returned1(int a, int b)
        {

            int expected = 1;

            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestCase(15, 18, 27, 69)]
        public void SteinMethodTest_SteinGCDofParamsInt_Returned3(params int[] values)
        {

            int expected = 3;

            int actual = Euclid.SteinMethod(values);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

    }
}

