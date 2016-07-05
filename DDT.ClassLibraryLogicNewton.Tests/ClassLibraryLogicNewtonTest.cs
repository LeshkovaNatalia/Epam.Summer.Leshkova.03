using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryLogicNewton;

namespace DDT.ClassLibraryLogicNewton.Tests
{
    [TestClass()]
    public class ClassLibraryLogicNewtonTest
    {
        public TestContext TestContext { get; set; }
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\InputValues.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.ClassLibraryLogicNewton.Tests\\InputValues.xml")]
        [TestMethod]
        public void TestMethodNewton()
        {
            int number = Convert.ToInt32(TestContext.DataRow["Number"]);
            int degree = Convert.ToInt32(TestContext.DataRow["Degree"]);
            double precision = Convert.ToDouble(TestContext.DataRow["Precision"]);

            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            bool expectedException = Convert.ToBoolean(TestContext.DataRow["ExpectException"]);

            try
            {
                double actual = Newton.MethodNewton(number, degree, precision);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                if (expectedException)
                    Assert.AreEqual(typeof(ArgumentException), ex.GetType());
                else
                {
                    throw ex;
                }
            }
        }
    }
}
