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
            Assert.AreEqual(pastryQuantity, newPastry.PastryQuantiity);
        }
    }
}