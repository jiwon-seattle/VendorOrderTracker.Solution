using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      // int vendorId = int.Parse(Request.Form["vendorId"]);
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      // int vendorId  = int.Parse(Convert.ToString(Request.Form["vendor.GetId()"]));
      // int orderId = int.Parse(Convert.ToString(Request.Form["orderId"]));
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> vendorOrder = new Dictionary<string, object>{};
      vendorOrder.Add("order", order);
      vendorOrder.Add("vendor", vendor);
      return View(vendorOrder);
    }

    // [HttpPost("/orders/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Order.ClearAll();
    //   return("DeleteAll");
    // }
  }
}