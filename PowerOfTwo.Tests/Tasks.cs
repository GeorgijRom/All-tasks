using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Test
{
    [TestClass()]
    public class Tasks
    {
        [TestMethod()]
        public void CheckPowerOfTwoTest_expected_true()
        {
            int x = 32;
            bool expected = true;

            bool actual = TasksSolution.CheckPowerOfTwo(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTest_expected_false()
        {
            int x = 20;
            bool expected = false;

            bool actual = TasksSolution.CheckPowerOfTwo(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTestRecursive_expected_true()
        {
            int x = 32;
            bool expected = true;

            bool actual = TasksSolution.CheckPowerOfTwoRecursive(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckPowerOfTwoTestRecursive_expected_false()
        {
            int x = 20;
            bool expected = false;

            bool actual = TasksSolution.CheckPowerOfTwoRecursive(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void StringTurnOverTest_expected_tone()
        {
            string str = "enot";
            string expected = "tone";

            string actual = TasksSolution.StringTurnOver(str);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void StringTurnOverTest_expected_ikitone()
        {
            string str = "enotiki";
            string expected = "ikitone";

            string actual = TasksSolution.StringTurnOver(str);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FindPairTest_expected_One()
        {
            int[] array = new[] { 1, 2, 4, 5, 1, 3, 7 };
            int expected = 1;

            int actual = TasksSolution.FindPair(array);

            Assert.AreEqual(expected, actual);
        }

    }
}