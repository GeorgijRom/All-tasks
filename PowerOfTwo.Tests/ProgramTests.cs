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
        public void CheckPowerOfTwoTest()
        {
            int x = 32;
            bool expected = true;

            bool actual = PowerOfTwo.CheckPowerOfTwo(x);

            Assert.AreEqual(expected, actual);
        }
    }
}