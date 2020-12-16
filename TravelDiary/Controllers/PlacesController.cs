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
            // List<Place> allPlaces = Place.GetAll();
            // return View(allPlaces);
            return View();
        }
    }
}