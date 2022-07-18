// using System;

namespace PierresBakery.Models
{
  public class Pastry
  {  
    //properties
    public int Quantity {get; set;}
    private static double _Cost = 2;
    private double _ThirdOneHalfOff;
    
    //constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
      _Cost = Cost;
      _ThirdOneHalfOff = 0.5;
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
        if (index == 0)
        {
          pastryTotalCost += 0;
        } 
        else if (index % 3 == 0) 
        {
          pastryTotalCost += _Cost * _ThirdOneHalfOff;
        }
        else 
        {
          pastryTotalCost += _Cost;
        }
      return pastryTotalCost;
    }
  }
}