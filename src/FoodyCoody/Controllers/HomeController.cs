using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodyCoody.Models;
using FoodyCoody.Services;

namespace FoodyCoody.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurant;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurant = restaurantData;
        }
        public ViewResult Index()
        {
            var model = _restaurant.GetAll();
            return View(model);
        }
    }
}
