using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCityMyPlaces.Data;

namespace MyCityMyPlaces.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
    }
}