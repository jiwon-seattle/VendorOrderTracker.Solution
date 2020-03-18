using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Bakery
  {
    private string _name;
    private int _price;
    private string _description;
    public static List<Bakery> _bakeryInstances = new List<Bakery> {
      new Bakery("matcha", 4, "<div id='matcha'><p>Price : $4 per each <br> Matcha cupcake combines the popular flavors of Japanese matcha tea</p> <img src='/img/green.png'></div>"),
      new Bakery("strawberry", 5, "<div id='strawberry'><p>Price : $5 per each <br> Pink strawberry buttercream swirled onto butter cake with a colorful confetti</p> <img src='/img/strawberry.png'></div>"),
      new Bakery("velvet", 5, "<div id='velvet'><p>Price : $5 per each <br> A classic Southern buttermilk cake with a hint of cocoa. Topped off with a rich pile of cream cheese frosting and a dusting of red sparkle</p> <img src='/img/velvet.png'></div>"),
      new Bakery("cherry", 7, "<div id='cherry'><p>Price : $7 per each <br> A soft pink cupcake filled with cherries and topped with maraschoino cherry buttercream</p> <img src='/img/cherry.png'></div>"),
      new Bakery("birthday", 7, "<div id='birthday'><p>Price : $7 per each <br> Sweet vanilla buttercream atop our moist vanilla buttercake</p> <img src='/img/birthday.png'></div>"),
      new Bakery("carrot", 5, "<div id='carrot'><p>Price : $5 per each <br> The Carrot Walnut is a spiced carrot cake with chunky walnuts throughout, topped with a thick swirl of rich cream</p> <img src='/img/carrot.png'></div>")
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

    public string GetDescription()
    {
      return _description;
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