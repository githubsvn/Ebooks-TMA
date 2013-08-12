using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace MathTest
{
    [TestFixture]
    public class MathTest
    {
        protected int value1;

        protected int value2;

        [SetUp]
        public void Initialize()
        {
            value1 = 1;
            value2 = 7;
        }

        [Test]
        public void TestMathLib_Add()
        {
            double result = Math.MathLib.Add(value1, value2);
            Assert.AreEqual(result, 8d);
        }

        [Test]
        public void TestMathLib_Sub()
        {
            double result = Math.MathLib.Sub(value1, value2);
            Assert.AreEqual(result, -5d);
        }

        [Test]
        public void TestMathLib_Multiple()
        {
            double result = Math.MathLib.Multiply(value1, value2);
            Assert.AreEqual(result, 7d);
        }

        [Test]
        public void TestMathLib_Divide()
        {
            double result = Math.MathLib.Divide(value2, value1);
            Assert.AreEqual(result, 7d);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMathLib_DivideByZeroException()
        {
            double result = Math.MathLib.Divide(value2, 0);
            //Assert.Fail("Divide by Zero Exception");
        }

        [Test]
        [Ignore("Decide how to implement this function")]
        public void TestMathLib_SQRT()
        {
            //do some thing 
        }

    }
}
