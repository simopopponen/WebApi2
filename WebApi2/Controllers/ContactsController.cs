using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Model;
using WebApi2.Services;
using System.Diagnostics;
using Microsoft.AspNetCore.Cors;

namespace WebApi2.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        //private static ContactService _contactService = new ContactService();
        private readonly IContactService _contactService;

        public ContactsController (IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET api/contacts
        [HttpGet]
        public List<Contact> Get()
        {
            return _contactService.FindAllContacts();
        }

        // GET api/contacts/id
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _contactService.FindById(id);
        }

        // POST api/contacts
        [HttpPost]
        public void Post([FromBody] Contact contact)
        {
            //Debug.WriteLine(contact);

            _contactService.SaveContact(contact);
         }

        // PUT api/contacts/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Contact contact)
        {
            _contactService.EditContact(contact);
        }

        // DELETE api/contacts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactService.DeleteContact(id);
                
        }
    }
}
