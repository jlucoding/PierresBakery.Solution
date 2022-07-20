using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    //properties
    public int BreadQuantity {get; set;}
    private static double _Cost = 5;
    private double _ThirdOneFree;

    //constructor
    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
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
      for (int index = 0; index <= BreadQuantity; index++)
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