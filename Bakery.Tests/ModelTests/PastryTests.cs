using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2.99);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Double()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price);

      double result = newPastry.Price;

      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void SetPastryPrice_SetPastryPrice_Double()
    {
      double price = 2.99;
      Pastry newPastry = new Pastry(price);

      double updatedPrice = 1.99;
      newPastry.Price=updatedPrice;
      double result = newPastry.Price;

      Assert.AreEqual(updatedPrice, result);
    }
  }
}