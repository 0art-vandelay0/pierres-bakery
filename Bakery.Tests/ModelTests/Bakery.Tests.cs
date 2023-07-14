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
            Bread newBread = new Bread(breadPrice, breadQuantity);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void BreadDiscount_ReturnsBreadDiscount_Int()
        {
            int breadPrice = 5;
            int breadQuantity = 3;
            Bread newBread = new Bread(breadPrice, breadQuantity);
            int breadDiscount = newBread.BreadDiscount();
            Assert.AreEqual(5, breadDiscount);
        }

        [TestMethod]
        public void BreadDiscount_ReturnsBreadDiscountWithNoDiscount_Int()
        {
            int breadPrice = 5;
            int breadQuantity = 2;
            Bread newBread = new Bread(breadPrice, breadQuantity);
            int breadDiscount = newBread.BreadDiscount();
            Assert.AreEqual(0, breadDiscount);
        }

        [TestMethod]
        public void BreadTotalPrice_ReturnsTotalPriceOfBread_Int()
        {
            int breadPrice = 5;
            int breadQuantity = 3;
            Bread newBread = new Bread(breadPrice, breadQuantity);
            int breadTotalPrice = newBread.BreadTotalPrice();
            Assert.AreEqual(10, breadTotalPrice);
        }
    }
}