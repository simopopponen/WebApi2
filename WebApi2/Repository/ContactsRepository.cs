using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApi2.Contexts;
using WebApi2.Model;

namespace WebApi2.Repository
{
    public class ContactsRepository: IContactsRepository
    {
        private readonly ContactsContext _context;

        public ContactsRepository(ContactsContext context)
        {
            _context = context;
        }

        public List<Contact> FindAll()
        {
            var contacts = _context.Contacts.ToList();
            return contacts;
        }

        public Contact FindById(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == id);
            return contact;
        }

        public void Create(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
            else
            {
                //TODO
                Debug.WriteLine("#ContactRepository, No contact found for id " + id);
            }
        }
    }
}

