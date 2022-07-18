// using System;

namespace PierresBakery.Models
{
  public class Pastry
  {  
    //properties
    public int Quantity {get; set;}
    private static double _Cost = 2;
    // private double _Buy3For5;
    
    //constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
      _Cost = Cost;
      // _Buy3For5;
    }

    public static double Cost
    {
      get { return _Cost; }
      set { _Cost = value; }
    }

    public double PastryCost()
    {
      double pastryTotalCost = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        pastryTotalCost = Quantity * _Cost;
      }
      return pastryTotalCost;
    }
  }
}