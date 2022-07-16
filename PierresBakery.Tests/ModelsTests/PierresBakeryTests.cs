using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
// using System.Collections.Generic;
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
    public void GetQuantity_ReturnQuantityOfBread_Integer()
    {
      int quantity = 2;

      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;

      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnQuantityOfPastry_Integer()
    {
      int quantity = 2;

      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;

      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantityOfBread_Integer()
    {
      int quantity = 2;
      Bread newBread = new Bread(quantity);
      int updatedQuantity = 5;
      newBread.Quantity = updatedQuantity;
      int result = newBread.Quantity;

      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantityOfPastry_Integer()
    {
      int quantity = 2;
      Pastry newPastry = new Pastry(quantity);
      int updatedQuantity = 5;
      newPastry.Quantity = updatedQuantity;
      int result = newPastry.Quantity;

      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void PastryCost_CostOfOnePastry_Integer()
    {
      int pastryQuantity = 1;
      double pastryCost = 2;

      Pastry pastryOrder = new Pastry(pastryQuantity);

      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

    public void PastryCost_CostOfTwoPastry_Integer()
    {
      int pastryQuantity = 2;
      double pastryCost = 4;

      Pastry pastryOrder = new Pastry(pastryQuantity);

      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }

    [TestMethod]
    public void BreadCost_CostOfOneBread_Integer()
    {
      int breadQuantity = 1;
      double breadCost = 5;

      Bread breadOrder = new Bread(breadQuantity);

      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

    public void BreadCost_CostOfTwoBread_Integer()
    {
      int breadQuantity = 2;
      double breadCost = 10;

      Bread breadOrder = new Bread(breadQuantity);

      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }

  }
  
}