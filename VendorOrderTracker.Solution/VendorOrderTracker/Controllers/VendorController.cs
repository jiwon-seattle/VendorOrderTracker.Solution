using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      // string vendorName = Request.Form["vendorName"];
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> vendorOrder = new Dictionary<string, object>{};
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = selectedVendor.Orders;
      vendorOrder.Add("vendor", selectedVendor);
      vendorOrder.Add("orders",vendorOrders);
      return View(vendorOrder);
    }
    
    [HttpPost("/vendor/{vendorId}/orders")]
    public ActionResult Create()
    {
      int vendorId = int.Parse(Request.Form["vendorId"]);
      string orderDate = Request.Form["orderDate"];
      string bakery = Request.Form["bakery"];
      int quantities = int.Parse(Request.Form["quantities"]);
      
      Dictionary<string, object> model = new Dictionary<string, object>{};
      
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDate);
      newOrder.AddToOrder(bakery, quantities);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);

    }
  }
}