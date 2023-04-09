namespace PurpleTask.Models
{
    public class OurPricing:BaseEntity
    {

        public string? Position { get; set; }
        public string? Users { get; set; }
        public string? Space { get; set; }

        public string? About { get; set; }

        public string? Addition { get; set; }

        public int Price { get; set; }
    }
}
