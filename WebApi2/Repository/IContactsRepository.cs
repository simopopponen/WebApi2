using System.Collections.Generic;
using WebApi2.Model;

namespace WebApi2.Repository
{
    public interface IContactsRepository
    {
        List<Contact> FindAll();
        Contact FindById(int id);
        void Create(Contact contact);
        void Update(Contact contact);
        void Delete(int id);
    }
}
