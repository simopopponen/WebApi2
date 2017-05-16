using System.Collections.Generic;
using WebApi2.Model;
using WebApi2.Repository;

namespace WebApi2.Services
{
    public class ContactService: IContactService
    {

        // public List<Contact> _contacts;

        /*public ContactService()
        {
            _contacts = new List<Contact>();
            _contacts.Add(new Contact(1,"Simo", "Pöppönen", "0401234567", "Kotipellonkatu 9","53850","Lappeenranta"));
            _contacts.Add(new Contact(2, "Anssi", "Kukkonen", "0501234567", "Poronkatu 10-12", "53850", "Lappeenranta"));
        }

        public List<Contact> FindContactsByFirstName(string firstName)
        {
            return _contacts.FindAll(contact => contact.FirstName.Equals(firstName));
        }

        public List<Contact> FindAllContacts()
        {
            return _contacts;
        }

        public Contact FindContactsById(int id)
        {
            return _contacts.FirstOrDefault(contact => contact.Id == id);
        }

        public void SaveContact(Contact contact)
        {
            //if (contact != null)
            //{
                _contacts.Add(new Contact(GetId(), contact.FirstName, contact.LastName, contact.Phone, contact.StreetAddress, contact.PostalCode, contact.City));
            //}
        }

        private int GetId()
        {
            var lastSaved = _contacts.OrderByDescending(contact => contact.Id).FirstOrDefault();

            //
            return lastSaved?.Id +1 ?? 1;
        }

        public void DeleteContact(int id)
        {
            var entity = _contacts.First(contact => contact.Id == id);
            if (entity != null)
            {
                _contacts.Remove(entity);
            }
        }

        public void EditContact(Contact contact)
        {
            DeleteContact(contact.Id);
            SaveContact(contact);
        }*/

        private readonly IContactsRepository _contactsrepository;

        public ContactService(IContactsRepository contactsRepository)
        {
            _contactsrepository = contactsRepository;
        }
        
        public List<Contact> FindAllContacts()
        {
            return _contactsrepository.FindAll();
        }

        public Contact FindById(int id)
        {
            return _contactsrepository.FindById(id);
        }

        public void SaveContact(Contact contact)
        {
            _contactsrepository.Create(contact);
        }
        public void EditContact(Contact contact)
        {
            _contactsrepository.Update(contact);
        }
        public void DeleteContact(int id)
        {
            _contactsrepository.Delete(id);
        }

    }
}
