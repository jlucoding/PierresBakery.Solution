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
      string firstResponse = Console.ReadLine();
      if (firstResponse != "yes" && firstResponse != "no")
      {
        Console.WriteLine("Please let me know if I can get you anything by saying yes or no. We have pastries and breads.");
      }
      else if (firstResponse == "no")
      {
        Console.WriteLine("Thanks for stopping by and have a good day!");
      }
      else
      {
        Console.WriteLine("How many pastries would you like and how many breads would you like?");
      }
    }
  }
}