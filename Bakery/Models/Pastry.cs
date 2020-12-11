namespace Bakery.Models
{
  public class Pastry
  {
    public float Cost { get; set; }


    public Pastry(string cost)
    {
      Cost = cost;
    }