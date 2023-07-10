﻿using JenkinsUnit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JenkinsUnit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
            
        }


        public IActionResult Index()
        {
            return View("Index");
        }
    }
}