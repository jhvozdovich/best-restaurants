using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurant.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly BestRestaurantContext _db;
    public RestaurantsController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Restaurant thisrestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == id);
      return View(thisrestaurant);
    }

  }
}
