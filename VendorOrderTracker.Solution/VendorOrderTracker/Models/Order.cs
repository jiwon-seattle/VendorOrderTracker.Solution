using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orders = new List<Order>{};
    private int _id;
    private static int _auto_incremented_id = 0;

    private Dictionary<string, int> Bakeries = new Dictionary<string, int> {{"Danish", 3}, {"Cake", 10}, {"Muffin", 5}};
    private string _date;

    public Order(string date)
    {
      _id = _auto_incremented_id ++;
      _orders.Add(this);
      _date = date;
    }
    // public static void Main()
    // {
    //   Bakeries.Add("Danish", 3);
    //   Bakeries.Add("Cake", 10);
    //   Bakeries.Add("Muffin", 5);
    // }

    public static List<Order> GetAll()
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