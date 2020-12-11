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
      if (_PastryDealMarker == false || amount < 3)
      {
        return amount * PastryPrice;
      }
      else
      {
        return (amount/3)*(PastryPrice-1)+(amount-amount/3)*PastryPrice;
      }
    }
  }
}