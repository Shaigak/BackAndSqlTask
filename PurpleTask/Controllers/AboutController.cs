using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.Data;
using PurpleTask.Models;
using PurpleTask.ViewModels;

namespace PurpleTask.Controllers
{
    public class AboutController : Controller
    {


        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            IEnumerable<About> abouts = await _context.Abouts./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Team> teams = await _context.Teams./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<TeamMember> teamMembers = await _context.TeamMembers./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Partner> partners = await _context.Partners./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<PartnerMember> partnerMembers = await _context.PartnerMembers./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Statistica> statisticas = await _context.Statisticas./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Creative> creatives = await _context.Creatives./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<ChooseAbout> chooseAbouts = await _context.ChooseAbouts./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<Future> futures = await _context.Futures./*Include(m => m.Images).*/Where(m => !m.SoftDelete).ToListAsync();

            AboutVM about = new()
            {
                Abouts = abouts,
                Teams = teams,
                TeamMembers = teamMembers,
                Partners=partners,
                PartnerMembers=partnerMembers,
                Statisticas = statisticas,
                Creatives=creatives,
                ChooseAbouts=chooseAbouts,
                Futures=futures
            };


            return View(about);




        }
    }
}
