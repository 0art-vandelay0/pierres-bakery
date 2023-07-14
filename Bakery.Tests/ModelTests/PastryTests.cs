using System;
using System.Reflection.Metadata;
using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests.TestModels
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstuctor_CreatesAnInstanceOfAPastry_int()
        {
            int pastryQuantity = 1;
            Pastry newPastry = new Pastry(pastryQuantity);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void PastryConstructor_CreatesAnInstanceOfAPastryWithProperties_int()
        {
            int pastryQuantity = 4;
            Pastry newPastry = new Pastry(pastryQuantity);
            Assert.AreEqual(pastryQuantity, newPastry.PastryQuantity);
        }

        [TestMethod]
        public void PastryDiscount_ReturnsPastryDiscount_int()
        {
            int pastryQuantity = 4;
            Pastry newPastry = new Pastry(pastryQuantity);
            int pastryDiscount = newPastry.PastryDiscount();
            Assert.AreEqual(2, pastryDiscount);
        }

        [TestMethod]
        public void PastryDiscount_ReturnsPastryWithoutDiscount_int()
        {
            int pastryQuantity = 2;
            Pastry newPastry = new Pastry(pastryQuantity);
            int pastryDiscount = newPastry.PastryDiscount();
            Assert.AreEqual(0, pastryDiscount);
        }

        [TestMethod]
        public void PastryTotalPrice_ReturnsTotalPriceOfPastry_Int()
        {
            int pastryQuantity = 3;
            Pastry newPastry = new Pastry(pastryQuantity);
            int pastryTotalPrice = newPastry.PastryTotalPrice();
            Assert.AreEqual(6, pastryTotalPrice);
        }
    }
}