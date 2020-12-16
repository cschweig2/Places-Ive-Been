using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}