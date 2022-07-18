using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    //properties
    public int Quantity {get; set;}
    private static double _Cost = 5;
    // private double _Buy2Get1Free;

    //constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
      _Cost = Cost;
      // _Buy2Get1Free;
    }

    public static double Cost
    {
      get { return _Cost; }
      set { _Cost = value; }
    }

    public double BreadCost()
    {
      double breadTotalCost = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        breadTotalCost = Quantity * _Cost;
      }
      return breadTotalCost;
    }
  }
} 