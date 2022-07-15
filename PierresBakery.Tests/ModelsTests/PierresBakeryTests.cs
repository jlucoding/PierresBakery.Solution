using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantityOfBread_Double()
    {
      double quantity = 2;
      Bread newBread = new Bread(quantity);
      double result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantityOfPastry_Double()
    {
      double quantity = 2;
      Pastry newPastry = new Pastry(quantity);
      double result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantityOfBread_Double()
    {
      double quantity = 2;
      Bread newBread = new Bread(quantity);
      double updatedQuantity = 5;
      newBread.Quantity = updatedQuantity;
      double result = newBread.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantityOfPastry_Double()
    {
      double quantity = 2;
      Pastry newPastry = new Pastry(quantity);
      double updatedQuantity = 5;
      newPastry.Quantity = updatedQuantity;
      double result = newPastry.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }    


  }
  
}