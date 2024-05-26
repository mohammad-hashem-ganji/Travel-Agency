using Microsoft.AspNetCore.Mvc;
using TravelAgency.Models;

namespace TravelAgency.Controllers
{
    public class CityController : Controller
    {
        public IActionResult InsertCity() => View();
        public IActionResult InsertConfirmCity(string name)
        {
            using(DB_TravelAgency_5030 db = new() )
            {
                Models.City city = new() { Name = name };
                db.Add(city);
                db.SaveChanges();
            }
            return RedirectToAction("InsertCity", "City");
        }
        public IActionResult ShowListOfCities()
        {
            using(DB_TravelAgency_5030 db = new())
            {
                List<Models.City> cities = db.Cities.ToList();
                
                ViewData["cities"] = cities;
            }
            return View();
        }
        public IActionResult DeleteCity(int id)
        {
            using(DB_TravelAgency_5030 db = new())
            {
                Models.City city = db.Find<Models.City>(id);
                db.Remove(city);
                db.SaveChanges();
            }
            return RedirectToAction("ShowListOfCity", "City");
        }
        public IActionResult DeleteMany(List<int> ids)
        {
            using(Models.DB_TravelAgency_5030 db = new())
            {
                List<Models.City> cities = db.Cities.Where(x => ids.Contains(x.Id)).ToList();
                db.RemoveRange(cities);
                db.SaveChanges();
            }
            return RedirectToAction("ShowListOfCities", "City");
        }
        public IActionResult Edit(int id)
        {
            using(DB_TravelAgency_5030 db = new())
            {
                City city = db.Find<City>(id);
                ViewData["city"] = city;
            }
            return View();
        }

    }
}
