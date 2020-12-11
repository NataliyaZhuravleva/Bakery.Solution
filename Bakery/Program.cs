using Bakery.Models;
using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  {
    //Assortiment and prices adjustments
    double breadPrice = 5;
    Bread newBread = new Bread(breadPrice, true);

    double pastryPrice = 2;
    Pastry newPastry = new Pastry(pastryPrice, true);

    //Interaction with user
    Console.WriteLine("Welcome to the Pierre's Bakery!");
    Console.WriteLine("Our pricelist: Bread for $" + breadPrice + " and Pastry for $" + pastryPrice);

    if (newBread.BreadDealMarker == true || newPastry.PastryDealMarker == true)
    {
      Console.Write("Our deals today:\n");
      if (newBread.BreadDealMarker == true)
      {
        Console.WriteLine("Buy 2 loafs of bread, get 1 loaf free.");
      }
      if (newPastry.PastryDealMarker == true)
      {
        Console.WriteLine("Buy 2 loafs of bread, get 1 loaf free.");
      }
    }

  }
}
