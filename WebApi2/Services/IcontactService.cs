using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Model;

namespace WebApi2.Services
{
    public interface IContactService
    {
        List<Contact> FindAllContacts();
        List<Contact> FindContactsByFirstName(string firstName);
        void SaveContact(Contact contact);
        void EditContact(Contact contact);
        void DeleteContact(int id);
    }
}
