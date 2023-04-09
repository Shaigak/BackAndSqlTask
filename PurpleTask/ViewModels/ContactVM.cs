using PurpleTask.Models;

namespace PurpleTask.ViewModels
{
    public class ContactVM
    {

        public IEnumerable<Contact> Contacts { get; set; }

        public IEnumerable<ContactImage> ContactImages{ get; set; }

        public IEnumerable<CreateContact> CreateContacts { get; set; }

        public IEnumerable<ContactMembers> ContactMembers { get; set; }

    }
}
