using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Sum(2, 2)==4);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Subtract(2, 2)==0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            int[] arr1 = new int[] { 0, 2, 10,-5};
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            int[] resArr = new int[] { 0, 4, 30, -20 };
            var calculator = new Calculator();
            for (int i = 0; i < arr1.Length; i++)
            {
                Assert.IsTrue(calculator.Multiply(arr1[i], arr2[i])==resArr[i]);
            }
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(10, 2)==5);
        }
    }
}