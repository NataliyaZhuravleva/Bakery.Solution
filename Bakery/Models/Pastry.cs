namespace Bakery.Models
{
  public class Pastry
  {
    public double PastryPrice { get; set;}


    public Pastry(double pastryPrice)
    {
      PastryPrice= pastryPrice;
    }
    public double CalculatePastryCost(int amount)
    {
      return amount*PastryPrice+1;
    }
  }
}