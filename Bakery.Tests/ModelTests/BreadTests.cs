using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2.99);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    {
      double price = 2.99;
      Bread newBread = new Bread(price);

      double result = newBread.Price;

      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      double price = 2.99;
      Bread newBread = new Bread(price);

      double updatedPrice = 1.99;
      newBread.Price = updatedPrice;
      double result = newBread.Price;

      Assert.AreEqual(updatedPrice, result);
    }
  }
}