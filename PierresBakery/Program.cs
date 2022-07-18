using System;
using System.Collections.Generic;
using PierresBakery.Models;


namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Can I get you anything today? (yes/no)");
      string firstResponse = Console.ReadLine().ToLower();
      
      if (firstResponse != "yes" && firstResponse != "no")
      {
        Console.WriteLine("Please let me know if I can get you anything by saying yes or no. We have pastries and bread. Let's start over!");
        Environment.Exit(0);
      }
      else if (firstResponse == "no")
      {
        Console.WriteLine("Thanks for stopping by and have a good day!");
        Environment.Exit(0);
      }
      else
      {
        Console.WriteLine("Would you like pastries or bread? (pastries/bread)");
      }

      string secondResponse = Console.ReadLine().ToLower();
      if (secondResponse == "pastries" || secondResponse == "pastry")
      {
        Console.WriteLine("How many pastries would you like?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Pastry pastryOrder = new Pastry(pastryQuantity);
        Console.WriteLine("Your total for the pastries is $" + pastryOrder.PastryCost() + ".");
        Console.WriteLine("And how many loafs of bread would you like?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadQuantity);
        Console.WriteLine("Your total for the bread is $" + breadOrder.BreadCost() + ".");
        Console.WriteLine("Your order total comes out to $" + (breadOrder.BreadCost() + pastryOrder.PastryCost()) + ".");
      }
      else if (secondResponse == "bread")
      {
        Console.WriteLine("How many loafs of bread would you like?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadQuantity);
        Console.WriteLine("Your total for the bread is $" + breadOrder.BreadCost() + ".");
        Console.WriteLine("And how many pastries would you like?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Pastry pastryOrder = new Pastry(pastryQuantity);
        Console.WriteLine("Your total for the pastries is $" + pastryOrder.PastryCost() + ".");
        Console.WriteLine("Your order total comes out to $" + (breadOrder.BreadCost() + pastryOrder.PastryCost()) + ".");
      }
    }
  }
}