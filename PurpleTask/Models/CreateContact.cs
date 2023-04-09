namespace PurpleTask.Models
{
    public class CreateContact:BaseEntity
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? About { get; set; }
    }
}
