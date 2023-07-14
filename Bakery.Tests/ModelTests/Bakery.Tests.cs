using System;
using System.Collections.Generic;
using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests.ModelTests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBreadWithProperties_Bread()
        {
            int breadPrice = 5;
            int breadQuantity = 1;
            int breadTotal = 3;
            Bread newBread = new Bread(breadPrice, breadQuantity, breadTotal);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadDiscount_ReturnsBreadDiscount_Int()
        {
            int breadPrice = 5;
            int breadQuantity = 3;
            int breadTotal = 3;
            Bread newBread = new Bread(breadPrice, breadQuantity, breadTotal);
            int breadDiscount = newBread.BreadDiscount();
            Assert.AreEqual(5, breadDiscount);
        }

        [TestMethod]
        public void BreadDiscount_ReturnsBreadDiscountWithNoDiscount_Int()
        {
            int breadPrice = 5;
            int breadQuantity = 2;
            int breadTotal = 2;
            Bread newBread = new Bread(breadPrice, breadQuantity, breadTotal);
            int breadDiscount = newBread.BreadDiscount();
            Assert.AreEqual(0, breadDiscount);
        }
    }
}