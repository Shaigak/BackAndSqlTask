namespace PurpleTask.Models
{
    public class PartnerMember:BaseEntity
    {
        public string? Image { get; set; }

        public int PartnerId { get; set; }

        public Partner Partner { get; set; }
    }
}
