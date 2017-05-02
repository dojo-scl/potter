using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Potter;

namespace PotterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDiscountBetween2EqualTitles()
        {
            var titles = new List<string>
            {
                "A", "A"
            };                
            var discount = Program.GetDiscount(titles);
            Assert.AreEqual(0, discount);
        }
        [TestMethod]
        public void GetDiscountBetween2DifferentTitles()
        {
            var titles = new List<string>
            {
                "A", "B"
            };
            var discount = Program.GetDiscount(titles);
            Assert.AreEqual(0.05, discount);
        }
        [TestMethod]
        public void GetDiscountBetween2Different1EqualTitles()
        {
            var titles = new List<string>
            {
                "B", "B", "C"
            };
            var discount = Program.GetDiscount(titles);
            Assert.AreEqual(0.05, discount);
        }

        [TestMethod]
        public void DeleteEquals()
        {
            var titles = new List<string>
            {
                "B", "B", "C"
            };
            var titlesFixed = new List<string>
            {
               "B", "C"
            };
            var cleanList = Program.RemoveRepeated(titles);
            Assert.AreEqual(2, cleanList.Count);
        }

    }

}

