using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.Data;
using PurpleTask.Models;
using PurpleTask.ViewModels;

namespace PurpleTask.Controllers
{
    public class PricingController : Controller
    {

        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            IEnumerable<Pricing> pricings = await _context.Pricings./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<PricingCategory> pricingCategories = await _context.PricingCategories./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<OurPricing> ourPricings = await _context.OurPricings./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<LastPricingCategory> lastPricingCategories = await _context.LastPricingCategories./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<PricingImage> pricingImages = await _context.PricingImages./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<AdditionPricing> additionPricings = await _context.AdditionPricings./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();


            PricingVM pricing = new()
            {
                Pricings = pricings,
                PricingCategories = pricingCategories,
                OurPricings=ourPricings,
                PricingImages=pricingImages,
                LastPricingCategories=lastPricingCategories,
                AdditionPricings=additionPricings
            };

            return View(pricing);
        }
    }
}
