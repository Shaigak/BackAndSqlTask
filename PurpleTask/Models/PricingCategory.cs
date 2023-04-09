namespace PurpleTask.Models
{
    public class PricingCategory:BaseEntity
    {
        public string? Image { get; set; }
        public string? Position { get; set; }

        public string PricePerYear { get; set; }

        public string? Users { get; set; }

        public string? Space { get; set; }

        public string? About { get; set; }

        public string? AboutPrice { get; set; }

        public string? Addition { get; set; }
    }
}
