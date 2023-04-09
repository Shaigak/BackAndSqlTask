using Microsoft.EntityFrameworkCore;
using PurpleTask.Models;

namespace PurpleTask.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
       
      

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<RecentWork> RecentWorks { get; set; }


        public DbSet<RecentWorkMenu> RecentWorkMenus { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<Partner> Partners { get; set; }

        public DbSet<PartnerMember> PartnerMembers { get; set; }

        public DbSet<Statistica> Statisticas { get; set; }

        public DbSet<Creative> Creatives { get; set; }

        public DbSet<ChooseAbout> ChooseAbouts { get; set; }


        public DbSet<Future> Futures { get; set; }

        public DbSet<Pricing> Pricings { get; set; }

        public DbSet<PricingCategory> PricingCategories { get; set; }


        public DbSet<OurPricing> OurPricings { get; set; }

        public DbSet<PricingImage> PricingImages { get; set; }

        public DbSet<LastPricingCategory> LastPricingCategories { get; set; }

        public DbSet<AdditionPricing> AdditionPricings { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<ContactImage> ContactImages { get; set; }

        public DbSet<CreateContact> CreateContacts { get; set; }


        public DbSet<ContactMembers> ContactMembers { get; set; }
    }


}
