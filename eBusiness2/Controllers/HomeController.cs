using System.Collections.Generic;
using System.Linq;
using eBusiness2.DAL;
using eBusiness2.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBusiness2.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
