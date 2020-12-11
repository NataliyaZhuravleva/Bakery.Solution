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
    Console.WriteLine("Our offers for today: Bread for $" + breadPrice + " and Pastry for $" + pastryPrice);

    // if (newBread._BreadDealMarker ==true)
    // {
    //   Console.WriteLine("We have deals for today!");  
    // }

  }
}
