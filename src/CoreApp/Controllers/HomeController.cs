﻿using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant
            {
                Id = 1, Name = "Modern House"
            };

            return new ObjectResult(model);
        }
    }
}