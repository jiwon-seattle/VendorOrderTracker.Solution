using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Bakery
  {
    private string _name;
    private int _price;
    private string _description;
    private static List<Bakery> _bakeryInstances = new List<Bakery> {
      new Bakery("matcha", 4, "Matcha combine the popular flavors of Japanese matcha tea"),
      new Bakery("mint", 6, "Refreshing mint buttercream atop vanila cake"),
      new Bakery("strawberry", 5, "Pink strawberry buttercream swirled onto butter cake with a colorful confetti"),
      new Bakery("velvet", 5, "A classic Southern buttermilk cake with a hint of cocoa. Topped off with a rich pile of cream cheese frosting and a dusting of red sparkle"),
      new Bakery("cherry", 7, "A soft pink cupcake filled with cherries and topped with maraschoino cherry buttercream"),
      new Bakery("birthday", 7, "Sweet vanilla buttercream atop our moist vanilla buttercake."),
      new Bakery("carrot", 5, "The Carrot Walnut is a spiced carrot cake with chunky walnuts throughout, topped with a thick swirl of rich cream")
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

    public int GetPrice()
    {
      return _price;
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