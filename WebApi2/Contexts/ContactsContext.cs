using Microsoft.EntityFrameworkCore;
using WebApi2.Model;

namespace WebApi2.Contexts
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options) { }
        public ContactsContext() { }
        public DbSet<Contact> Contacts { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");

        }
    }
}
