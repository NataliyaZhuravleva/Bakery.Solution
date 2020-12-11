using Bakery.Models;
using System;
using System.Collections.Generic;


public class Program
{
  public static void Main()
  { 
    double breadPrice=5;
    Bread newBread = new Bread (breadPrice, true);

    double pastryPrice=2;
    Pastry newPastry = new Pastry(pastryPrice, true);

    Console.WriteLine("Welcome to the Pierre's Bakery!");
    Console.WriteLine("Our offers for today: Bread for $5 and Pastry for $2");
    
    
  }
}
