using PurpleTask.Models;

namespace PurpleTask.ViewModels
{
    public class PricingVM
    {

        public IEnumerable<Pricing> Pricings { get; set; }

        public IEnumerable<PricingCategory> PricingCategories { get; set; }

        public IEnumerable<OurPricing> OurPricings { get; set; }

        public IEnumerable<PricingImage> PricingImages { get; set; }

        public IEnumerable<LastPricingCategory> LastPricingCategories { get; set; }


        public IEnumerable<AdditionPricing> AdditionPricings { get; set; }
    }
}
