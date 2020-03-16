using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order>{};
    private int _id;
    private static int _auto_incremented_id = 0;

    private static Dictionary<Bakery, int> _bakery = new Dictionary<Bakery, int> {};
    private string _date;
    public Order(string date)
    {
      _id = _auto_incremented_id ++;
      _orders.Add(this);
      _date = date;
    }
    public void AddToOrder(string itemName, int quantities)
    {
      Bakery bakery = Bakery.FindByName(itemName); 
      _bakery.Add(bakery, quantities);
    }
    public List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
      _auto_incremented_id = 0;
    }
    public int GetId()
    {
      return _id;
    }

    public Dictionary<Bakery, int> GetBakery()
    {
      return _bakery;
    }

    public string GetDate()
    {
      return _date;
    }
    public static Order Find(int searchId)
    {
      if(_orders.Exists(order => order._id == searchId))
        return _orders.Find(order => order._id == searchId);
      else
        return null;
    }
  }
}