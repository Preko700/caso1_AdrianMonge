using Microsoft.AspNetCore.Mvc;
using caso1_AdrianMonge.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace caso1_AdrianMonge.Controllers
{
    public class AsignaturasController : Controller
    {
        private readonly UniversidadABCContext _context;

        public AsignaturasController(UniversidadABCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inventarios = _context.Asignaturas.ToList();
            return View(inventarios);
        }
    }
}


