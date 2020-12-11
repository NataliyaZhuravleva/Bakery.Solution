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
      Bread newBread = new Bread(4.49);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Double()
    {
      double price = 4.49;
      Bread newBread = new Bread(price);

      double result = newBread.BreadPrice;

      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void SetBreadPrice_SetBreadPrice_Double()
    {
      double price = 4.49;
      Bread newBread = new Bread(price);
      
      double updatedPrice = 3.49;
      newBread.BreadPrice = updatedPrice;
      double result = newBread.BreadPrice;

      Assert.AreEqual(updatedPrice, result);
    }
    [TestMethod]
    public void CalculateBreadCost_ReturnBreadCost_Double()
    {
      double price = 4.49;
      Bread newBread = new Bread(price);
      int amount=3;
      
      double result = newBread.CalculateBreadCost(amount);

      Assert.AreEqual(amount*price, result);
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithDealMarker_Bread()
    {
      double price = 4.49;
      Bread newBread = new Bread(price, true);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}