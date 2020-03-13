using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private string _vendorName;
    private int _id;
    private static int _auto_incremented_id;
    private static List<Vendor> _vendorInstances = new List<Vendor> {};
    public List<Order> Orders {get; set;}

    public Vendor(string vendorName)
    {
      _vendorName = vendorName;
      _vendorInstances.Add(this);
      _id = _auto_incremented_id ++;
      Orders = new List<Order> {};
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

    // public static List<Order> GetOrderList()
    // {
    //   return _orders;
    // }
    public static Vendor Find(int searchId)
    {
      if(_vendorInstances.Exists(vendor => vendor._id == searchId))
        return _vendorInstances.Find(vendor => vendor._id == searchId);
      else
        return null;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
  
  
}