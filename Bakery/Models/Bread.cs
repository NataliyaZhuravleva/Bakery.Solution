namespace Bakery.Models
{
  public class Bread
  {
    public double BreadPrice { get; set; }
    private bool _BreadDealMarker;
    public Bread(double breadPrice)
    {
      BreadPrice = breadPrice;
    }
    public Bread(double breadPrice, bool breadDealMarker)
      : this(breadPrice)
    {
      _BreadDealMarker = breadDealMarker; //false - no deals, true - we have a deal
    }

    public double CalculateBreadCost(int amount)
    {
      return amount*BreadPrice;
    }
  }
}