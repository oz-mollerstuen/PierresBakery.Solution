using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

  }
}