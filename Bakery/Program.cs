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

    //Announcements for user
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

    //Interaction with user
    Console.WriteLine("Would you like to buy something today? ['Y' for yes, 'Enter' for no]");
    string ifBuyer = Console.ReadLine();
    if (ifBuyer.ToLower() == "y")
    {
      Console.WriteLine("How many loafs of bread would you like to buy today? (answer must be more or equal zero)");
      int breadAmount = int.Parse(Console.ReadLine());
      //Console.WriteLine(breadAmount);

      Console.WriteLine("How many pastries would you like to buy? (answer must be more or equal zero)");
      int pastryAmount = int.Parse(Console.ReadLine());
      //Console.WriteLine(pastryAmount);
      if (breadAmount >= 0 && pastryAmount >= 0)
      {
        double result = CalculateTotalCost(breadAmount, pastryAmount, newBread, newPastry);
        Console.WriteLine("It will cost you $" +result);
      }
    }
  }
  static double CalculateTotalCost(int breadAmount, int pastryAmount, Bread newBread, Pastry newPastry)
  {
    return newBread.CalculateBreadCost(breadAmount) + newPastry.CalculatePastryCost(pastryAmount);
  }

}
