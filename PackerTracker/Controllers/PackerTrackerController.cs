using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;
using System;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class PackerTrackerController : Controller
  {
    [HttpGet("/packerTracker")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/packerTracker/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/packerTracker")]
    public ActionResult Create(string name, string purchased, string notPurchased)
    {
      SupplyClass mySupply = new SupplyClass(purchased, notPurchased);
      PackerTracker myPackerTracker = new PackerTracker(name, mySupply);
      return View("Index", myPackerTracker);
    }
  }
}
