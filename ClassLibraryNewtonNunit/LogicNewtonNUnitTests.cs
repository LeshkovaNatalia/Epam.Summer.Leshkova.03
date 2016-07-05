using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLogicNewton;
using NUnit.Framework;

namespace ClassLibraryNewtonNunit
{
    [TestFixture]
    public class LogicNewtonNunitTest
    {
        [TestCase(0, 1)]
        [TestCase(1, 0)]
        [TestCase(-5, 2)]
        [TestCase(10, -2)]
        [ExpectedException(typeof(ArgumentException))]
        public void NewtonMethodTest_SqrtOfNumberOnTheDegree_ReturnedException(int number, int degree)
        {
            Newton.MethodNewton(number, degree, 0.00001);
        }

        [TestCase(10, 2, -0.05)]
        [TestCase(10, 2, 2)]
        [ExpectedException(typeof(ArgumentException))]
        public void NewtonMethodTest_SqrtOfNumberOnTheDegreeCheckPrecision_ReturnedException(int number, int degree, double precision)
        {
            Newton.MethodNewton(number, degree, precision);
        }

        [TestCase(4, 2, 0.00001)]
        public void NewtonMethodTest_SqrtOfNumberOnTheDegree_Returned2(int number, int degree, double precision)
        {
            int expected = 2;
            double actual = Newton.MethodNewton(number, degree, precision);
            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}

