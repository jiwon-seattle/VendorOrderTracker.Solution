using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private List<Order> _orders = new List<Order>{};
    private int _id = 0;
    private int _auto_incremented_id;

    private static Dictionary<string, int> Bakeries = new Dictionary<string, int> {};
    private string _date;

    public Order(string date)
    {
      _id = _auto_incremented_id ++;
      _orders.Add(this);
      _date = date;
    }
    public static void Main()
    {
      Bakeries.Add("Danish", 3);
      Bakeries.Add("Cake", 10);
      Bakeries.Add("Muffin", 5);
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _order.Clear();
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
      return _orders[searchId];
    }
  }
}