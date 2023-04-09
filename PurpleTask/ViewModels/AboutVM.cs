using PurpleTask.Models;

namespace PurpleTask.ViewModels
{
    public class AboutVM
    {

        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<Team> Teams { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }

        public IEnumerable<Partner> Partners { get; set; }

        public IEnumerable<PartnerMember> PartnerMembers { get; set; }

        public IEnumerable<Statistica> Statisticas { get; set; }

        public IEnumerable<Creative> Creatives { get; set; }

        public IEnumerable<ChooseAbout> ChooseAbouts { get; set; }

        public IEnumerable<Future> Futures { get; set; }
    }
}
