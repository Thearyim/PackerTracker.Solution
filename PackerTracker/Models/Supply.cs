using System.Collections.Generic;

namespace Supply.Models
{
  public class CampingClass
  {
    private string _purchased;
    private string _notPurchased;

    public CampingClass(string purchased, string notPurchased)
    {
      _purchased = purchased;
      _notPurchased = notPurchased;
    }

    public string GetPurchased()
    {
      return _purchased;
    }

    public void SetPurchased(string newPurchased)
    {
      _purchased = newPurchased;
    }

    public string GetNotPurchased()
    {
      return _notPurchased;
    }

    public void SetNotPurchased(string newNotPurchased)
    {
      _notPurchased = newNotPurchased;
    }
  }
}
