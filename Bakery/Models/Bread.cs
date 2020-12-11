namespace Bakery.Models
{
  public class Bread
  {
    public double BreadPrice { get; set; }
    public bool BreadDealMarker { get; }
    public Bread(double breadPrice)
    {
      BreadPrice = breadPrice;
    }
    public Bread(double breadPrice, bool breadDealMarker)
      : this(breadPrice)
    {
      BreadDealMarker = breadDealMarker; //false - no deals, true - we have a deal
    }

    public double CalculateBreadCost(int amount)
    {
      if (BreadDealMarker == false || amount < 3)
      {
        return amount * BreadPrice;
      }
      else
      {
        return (amount - amount / 3) * BreadPrice;
      }
    }


  }
}