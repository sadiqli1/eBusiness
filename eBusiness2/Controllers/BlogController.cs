using System.Collections.Generic;
using System.Linq;
using eBusiness2.DAL;
using eBusiness2.Models;
using eBusiness2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBusiness2.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b=>b.Comments).Include(t=>t.Tags).ToList();
            return View(blogs);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound ();
            BlogVM model = new BlogVM
            {
                Blog = _context.Blogs.Include(b => b.Comments).Include(t=>t.Tags).FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.OrderByDescending(b=>b.Date).Take(4).ToList()
            };
            if(model.Blog == null) return NotFound();
            return View(model);
        }
    }
}
