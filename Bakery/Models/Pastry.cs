namespace Bakery.Models
{
  public class Pastry
  {
    public double PastryPrice { get; set; }
    public bool PastryDealMarker { get; }

    public Pastry(double pastryPrice)
    {
      PastryPrice = pastryPrice;
    }

    public Pastry(double pastryPrice, bool pastryDealMarker)
      : this(pastryPrice)
    {
      PastryDealMarker = pastryDealMarker; //false - no deals, true - we have a deal
    }

    public double CalculatePastryCost(int amount)
    {
      if (PastryDealMarker == false || amount < 3)
      {
        return amount * PastryPrice;
      }
      else
      {
        return (amount / 3) * (PastryPrice - 1) + (amount - amount / 3) * PastryPrice;
      }
    }
  }
}