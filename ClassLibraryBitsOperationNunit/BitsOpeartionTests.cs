using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBitsOperation;
using NUnit.Framework;

namespace ClassLibraryBitsOperationNunit
{
    [TestFixture]
    public class BitsOperationTests
    {
        [TestCase(7, 4, 18, 15)]
        [TestCase(7, 4, 37, 64)]
        [TestCase(7, 4, 7, 8)]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumberMethodTest_Insert4In7_ReturnedException(int fNumber, int sNumber, int iPos, int jPos)
        {
            BitsOperation.InsertNumber(fNumber, sNumber, iPos, jPos);
        }

        [TestCase(7, 4, 8, 15)]
        public void InsertNumberMethodTest_Insert4In7_Returned519(int fNumber, int sNumber, int iPos, int jPos)
        {
            int expected = 519;

            int actual = BitsOperation.InsertNumber(fNumber, sNumber, iPos, jPos);

            Assert.AreEqual(expected, actual, "{0} != {1}", expected, actual);
        }
    }
}
