namespace PurpleTask.Models
{
    public class Partner:BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<PartnerMember> PartnerMembers { get; set; }
    }
}
