using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Models;
using System.Diagnostics;

namespace PortfolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public readonly PortfolioContext _context;

        public HomeController(ILogger<HomeController> logger, PortfolioContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Guid userId = Guid.Parse("a0ff38c2-5d7e-4e43-a54c-3e7f02d3d785");
            var video = _context.VideoEntities.Where(x=>x.UserId == userId).ToList();
            return View(video);
        }

        public IActionResult Experiments()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Project(Guid id)
        {
            var video = _context.VideoEntities.Where(x => x.Id == id).Include(x => x.Images).FirstOrDefault();
            return View(video);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
