namespace Bakery.Models
{
  public class Pastry
  {
    public double PastryPrice { get; set; }
    private bool _PastryDealMarker;

    public Pastry(double pastryPrice)
    {
      PastryPrice = pastryPrice;
    }

    public Pastry(double pastryPrice, bool _pastryDealMarker)
      : this(pastryPrice)
    {
      _PastryDealMarker = _pastryDealMarker; //false - no deals, true - we have a deal
    }

    public double CalculatePastryCost(int amount)
    {
      return amount * PastryPrice;
    }
  }
}