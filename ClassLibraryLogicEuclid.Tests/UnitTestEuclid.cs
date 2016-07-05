using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryLogicEuclid.Tests
{
    [TestClass]
    public class UnitTestEuclid
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EuclidTestMethod_GCDof0and0_ReturnedException()
        {
            Euclid.EuclidMethod(0, 0);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof0and15_Returned15()
        {
            int a = 0;
            int b = 15;

            int expected = 15;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof67and0_Returned67()
        {
            int a = 67;
            int b = 0;

            int expected = 67;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof1and3_Returned1()
        {
            int a = 1;
            int b = 3;

            int expected = 1;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDofNegative4andNegative16_Returned4()
        {
            int a = -4;
            int b = -16;

            int expected = 4;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDofNegative11and3_Returned1()
        {
            int a = -11;
            int b = 3;

            int expected = 1;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof8AndNegative32_Returned8()
        {
            int a = 8;
            int b = -32;

            int expected = 8;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof18And15_Returned3()
        {
            int a = 18;
            int b = 15;

            int expected = 3;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDof28And35And42_Returned7()
        {
            int a = 28;
            int b = 35;
            int c = 42;

            int expected = 7;
            int actual = Euclid.EuclidMethod(a, b, c);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void EuclidTestMethod_GCDofParamesValues_Returned7()
        {
            int[] values = {28, 35, 42, 14};

            int expected = 7;
            int actual = Euclid.EuclidMethod(values);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SteinTestMethod_GCDof0and0_ReturnedException()
        {
            Euclid.SteinMethod(0, 0);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof0and47_Returned47()
        {
            int a = 0;
            int b = 47;

            int expected = 47;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof9and0_Returned9()
        {
            int a = 9;
            int b = 0;

            int expected = 9;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof1and13_Returned1()
        {
            int a = 1;
            int b = 13;

            int expected = 1;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof7and1_Returned1()
        {
            int a = 7;
            int b = 1;

            int expected = 1;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDofNegative5andNegative16_Returned1()
        {
            int a = -5;
            int b = -16;

            int expected = 1;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDofNegative11and3_Returned1()
        {
            int a = -11;
            int b = 3;

            int expected = 1;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof8AndNegative32_Returned8()
        {
            int a = 8;
            int b = -32;

            int expected = 8;
            int actual = Euclid.EuclidMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof18And15_Returned3()
        {
            int a = 18;
            int b = 15;

            int expected = 3;
            int actual = Euclid.SteinMethod(a, b);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDofParamesValues_Returned2()
        {
            int[] values = { 8, 32, 42, 14 };

            int expected = 2;
            int actual = Euclid.SteinMethod(values);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }

        [TestMethod]
        public void SteinTestMethod_GCDof28And35And42_Returned7()
        {
            int a = 28;
            int b = 35;
            int c = 42;

            int expected = 7;
            int actual = Euclid.SteinMethod(a, b, c);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
