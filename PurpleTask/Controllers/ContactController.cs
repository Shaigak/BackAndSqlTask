using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.Data;
using PurpleTask.Models;
using PurpleTask.ViewModels;

namespace PurpleTask.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            IEnumerable<Contact> contacts = await _context.Contacts.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<ContactImage> contactImages = await _context.ContactImages.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<CreateContact> createContacts = await _context.CreateContacts.Where(m => !m.SoftDelete).ToListAsync();
            IEnumerable<ContactMembers> contactMembers = await _context.ContactMembers.Where(m => !m.SoftDelete).ToListAsync();


            ContactVM contactVM = new()
            {

                Contacts = contacts,
                ContactImages=contactImages,
                CreateContacts=createContacts,
                ContactMembers = contactMembers

            };


            return View(contactVM);
        }
    }
}
