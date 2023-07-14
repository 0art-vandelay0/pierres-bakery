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
    }
}