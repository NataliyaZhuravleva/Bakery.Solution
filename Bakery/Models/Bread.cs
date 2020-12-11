namespace Bakery.Models
{
  public class Bread
  {
    public double BreadPrice { get; set; }

    public Bread(double breadPrice)
    {
      BreadPrice = breadPrice;
    }

    public double CalculateBreadCost(int amount)
    {
      return amount*BreadPrice;
    }
  }
}