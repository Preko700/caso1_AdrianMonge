using caso1_AdrianMonge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace caso1_AdrianMonge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UniversidadABCContext _context;

        public HomeController(ILogger<HomeController> logger, UniversidadABCContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Asignaturas()
        {
            var asignaturas = _context.Asignaturas.ToList();
            return View(asignaturas);
        }
    }
}
