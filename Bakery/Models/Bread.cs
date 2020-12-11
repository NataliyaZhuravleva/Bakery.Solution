namespace Bakery.Models
{
  public class Bread
  {
    public double Price { get; set; }

    public Bread(double price)
    {
      Price = price;
    }

    public double CalculateBreadCost(int amount)
    {
      return amount*Price;
    }
  }
}