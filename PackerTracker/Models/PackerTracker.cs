using System.Collections.Generic;
using Supply.Models;

namespace PackerTracker.Models
{
  public class Camping
  {
    private string _name;
    private SupplyClass _supply;

    public Camping (string name, SupplyClass supply)
    {
      _name = name;
      _supply = supply;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetSupplyPurchased()
    {
      return _supply.GetPurchased();
    }

    public string GetSupplyNotPurchased()
    {
      return _supply.GetNotPurchased();
    }
  }
}
