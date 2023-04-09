﻿namespace PurpleTask.Models
{
    public class Team:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
