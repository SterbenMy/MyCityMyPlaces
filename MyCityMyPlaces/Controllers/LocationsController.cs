using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCityMyPlaces.Data;
using MyCityMyPlaces.Models;

namespace MyCityMyPlaces.Controllers
{
    public class LocationsController:Controller
    {
        private readonly ILogger<LocationsController> _logger;
        private readonly ApplicationDbContext _context;
        public LocationsController(ILogger<LocationsController> logger)
        {
            _logger = logger;
        }
        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Locations()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}