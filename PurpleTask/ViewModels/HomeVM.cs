using PurpleTask.Models;

namespace PurpleTask.ViewModels
{
    public class HomeVM
    {

        public  IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Service> Services { get; set; }


        public IEnumerable<RecentWork> RecentWorks { get; set; }

        public IEnumerable<RecentWorkMenu> RecentWorkMenus { get; set; }

    }
}
