using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerOfTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckPowerOfTwoTest_expected_true()
        {
            int x = 32;
            bool expected = true;

            bool actual = PowerOfTwo.CheckPowerOfTwo(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTest_expected_false()
        {
            int x = 20;
            bool expected = false;

            bool actual = PowerOfTwo.CheckPowerOfTwo(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTestRecursive_expected_true()
        {
            int x = 32;
            bool expected = true;

            bool actual = PowerOfTwo.CheckPowerOfTwoRecursive(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTestRecursive_expected_false()
        {
            int x = 20;
            bool expected = false;

            bool actual = PowerOfTwo.CheckPowerOfTwoRecursive(x);

            Assert.AreEqual(expected, actual);
        }
    }
}