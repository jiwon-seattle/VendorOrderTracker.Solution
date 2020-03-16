using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Bakery
  {
    private string _name;
    private int _price;
    private string _description;
    private static List<Bakery> _bakeryInstances = new List<Bakery> {
      new Bakery("danish", 5, "Yummy"),
      new Bakery("muffin", 5, "Yummy"),
      new Bakery("cake", 10, "Yummy")
    };

    private int _id;
    private static int _auto_incremented_id =0;

    public Bakery(string name, int price, string description)
    {
      _name = name;
      _price = price;
      _description = description;
      _id = _auto_incremented_id ++;
    }
    public string GetName()
    {
      return _name;
    }

    public static List<Bakery> GetAll()
    {
      return _bakeryInstances;
    }

    public static Bakery Find(int searchId)
    {
      if (_bakeryInstances.Exists(bakery => bakery._id == searchId))
        return _bakeryInstances.Find(bakery => bakery._id == searchId);
      else
        return null;
    }

    public static Bakery FindByName(string itemName)
    {
      if (_bakeryInstances.Exists(bakery => bakery._name.Equals(itemName)))
        return _bakeryInstances.Find(bakery => bakery._name.Equals(itemName));
      else
        return null;
    }
      
  }
}