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
    public class FamilyController : Controller
    {
        private readonly ILogger<FamilyController> _logger;
        private readonly ApplicationDbContext _context;
        public FamilyController(ILogger<FamilyController> logger)
        {
            _logger = logger;
        }
        public FamilyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Family()
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