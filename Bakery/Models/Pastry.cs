namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public Pastry()
    {
      Price = 2;
    }

    public int DeterminePastryPrice(int pastryNumber)
    {
      return pastryNumber * Price;
    }

    public int DetermineSalePrice(int pastryNumber)
    {
      return 0;
    }    
  }
}