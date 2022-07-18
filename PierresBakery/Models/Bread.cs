using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    //properties
    public int Quantity {get; set;}
    private static double _Cost = 5;
    private double _ThirdOneFree;

    //constructor
    public Bread(int quantity)
    {
      Quantity = quantity;
      _Cost = Cost;
      _ThirdOneFree = 0;
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
        if (index == 0)
        {
          breadTotalCost += 0;
        } 
        else if (index % 3 == 0) 
        {
          breadTotalCost += _Cost * _ThirdOneFree;
        }
        else 
        {
          breadTotalCost += _Cost;
        }
      return breadTotalCost;
    }
  }
} 