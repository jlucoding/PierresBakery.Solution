// using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    //properties
    public int Quantity {get; set;}
    private static double _Price = 5;
    // private double _Buy2Get1Free;

    //constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
      _Price = Price;
      // _Buy2Get1Free;
    }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public double BreadCost()
    {
      double breadTotalCost = 0;
      for (int index = 1; index <= Quantity; index++)
      {
        breadTotalCost += _Price;
      }
      return breadTotalCost;
    }
  }
}