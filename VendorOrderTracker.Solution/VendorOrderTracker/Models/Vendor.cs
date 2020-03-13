using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private string _vendorName;
    private int _id;
    private int _auto_incremented_id;
    private static List<Vendor> _vendorInstances = new List<Vendor> {};
    private List<Order> _orders;

    public Vendor(string vendorName)
    {
      _vendorName = vendorName;
      _vendorInstances.Add(this);
      _id = _auto_incremented_id ++;
      _orders = new List<Order> {};
    }

    public static List<Vendor> GetAll()
    {
      return _vendorInstances;
    }

    public string GetName()
    {
      return _vendorName;
    }
    public int GetId()
    {
      return _id;
    }

    public static Vendor Find(int searchId)
    {
      return _vendorInstances[searchId];
    }

    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }
  }
  
  
}