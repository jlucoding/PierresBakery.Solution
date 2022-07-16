// using System;

namespace PierresBakery.Models
{
  public class Pastry
  {  
    //properties
    public int Quantity {get; set;}
    private static double _Price = 2;
    // private double _Buy3For5;
    
    //constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
      _Price = Price;
      // _Buy3For5;
    }

    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public double PastryCost()
    {
      double pastryTotalCost = 0;
      for (int index = 1; index <= Quantity; index++)
      {
        pastryTotalCost += _Price;
      }
      return pastryTotalCost;
    }
  }
}