using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Intercom;

namespace Array_Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void oneList()
        {
            var oneList = new List<object> {1 };
            oneList = Program.Flatten(oneList);
            Assert.AreEqual(1, oneList[0]);
        }

        [TestMethod]
        public void unNested()
        {
            var control = new List<object> { 1, 2, 3, 4, 5 };                        
            var oneList = new List<object> { 1, 2, 3, 4, 5 };
            oneList = Program.Flatten(oneList);
            Assert.AreEqual(control[3], oneList[3]);
        }

        [TestMethod]
        public void nested()
        {
            var control = new List<object> { 1, 2, 3, 4, 5 };
            var oneList = new List<object> { 1, new List<object> { 2, new List<object> { 3 }, 4 }, 5 };
            oneList = Program.Flatten(oneList);
            Assert.AreEqual(control[4], oneList[4]);
        }
    }
}
