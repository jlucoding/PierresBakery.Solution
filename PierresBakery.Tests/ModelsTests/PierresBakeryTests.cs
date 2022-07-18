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
      int quantity = 1;
      double cost = 2;

      Pastry order = new Pastry(quantity);

      Assert.AreEqual(cost, order.PastryCost());
    }

    public void PastryCost_CostOfTwoPastry_Integer()
    {
      int quantity = 2;
      double cost = 4;

      Pastry order = new Pastry(quantity);

      Assert.AreEqual(cost, order.PastryCost());
    }

    [TestMethod]
    public void BreadCost_CostOfOneBread_Integer()
    {
      int quantity = 1;
      double cost = 5;

      Bread order = new Bread(quantity);

      Assert.AreEqual(cost, order.BreadCost());
    }

    public void BreadCost_CostOfTwoBread_Integer()
    {
      int quantity = 2;
      double cost = 10;

      Bread order = new Bread(quantity);

      Assert.AreEqual(cost, order.BreadCost());
    }

    public void PastryCost_CostOfNoPastry_Integer()
    {
      int quantity = 0;
      double cost = 0;

      Pastry order = new Pastry(quantity);

      Assert.AreEqual(cost, order.PastryCost());
    }

    [TestMethod]
    public void BreadCost_CostOfNoBread_Integer()
    {
      int quantity = 0;
      double cost = 0;

      Bread order = new Bread(quantity);

      Assert.AreEqual(cost, order.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CostOfThreeBread_Integer()
    {
      int quantity = 3;
      double cost = 10;

      Bread order = new Bread(quantity);

      Assert.AreEqual(cost, order.BreadCost());
    }

    [TestMethod]
    public void PastryCost_CostOfThreePastry_Integer()
    {
      int quantity = 3;
      double cost = 5;

      Pastry order = new Pastry(quantity);

      Assert.AreEqual(cost, order.PastryCost());
    }

    [TestMethod]
    public void BreadCost_CostOfFourBread_Integer()
    {
      int quantity = 4;
      double cost = 15;

      Bread order = new Bread(quantity);

      Assert.AreEqual(cost, order.BreadCost());
    }

    [TestMethod]
    public void PastryCost_CostOfFourPastry_Integer()
    {
      int quantity = 4;
      double cost = 7;

      Pastry order = new Pastry(quantity);

      Assert.AreEqual(cost, order.PastryCost());
    }

  }
}