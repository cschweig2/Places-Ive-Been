using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Controllers
{
    public class PlacesController: Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string cityName, string imageUrl)
        {
            Place newPlace = new Place(cityName, imageUrl);
            return RedirectToAction("Index", newPlace);
        }
    }
}