using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.Data;
using PurpleTask.Models;
using PurpleTask.ViewModels;
using System.Diagnostics;

namespace PurpleTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public async Task<IActionResult>  Index()
        {

            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Product> products = await _context.Products.Include(m=>m.Images).Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Service> services = await _context.Services./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<RecentWork> recentWorks = await _context.RecentWorks./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<RecentWorkMenu> recentWorkMenus = await _context.RecentWorkMenus./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();

            
            HomeVM model = new()
            {
                Categories = categories,
                Products=products,
                Services = services,
                RecentWorks=recentWorks,
                RecentWorkMenus=recentWorkMenus,
              

               
            };

            return View(model);


        }
    }

}