using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PJ_Webapp.Data;
using PJ_Webapp.Models.FoodOrder;

namespace PJ.Controllers;
public class OrderController : Controller
{
    private readonly ApplicationDBContext _db;

    public OrderController(ApplicationDBContext db)
    {
        _db = db;
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Menu1(FoodOrder obj)
    {
        _db.FoodOrders.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Stores");
    }
    public IActionResult Stores()
    {
        return View();
    }
    public IActionResult Menu1()
    {
        return View();
    }
    public IActionResult Menu2()
    {
        return View();
    }
    public IActionResult Menu3()
    {
        return View();
    }
    public IActionResult Menu4()
    {
        return View();
    }
    public IActionResult Menu5()
    {
        return View();
    }
    public IActionResult Menu6()
    {
        return View();
    }public IActionResult Menu7()
    {
        return View();
    }public IActionResult Menu8()
    {
        return View();
    }public IActionResult Menu9()
    {
        return View();
    }
}