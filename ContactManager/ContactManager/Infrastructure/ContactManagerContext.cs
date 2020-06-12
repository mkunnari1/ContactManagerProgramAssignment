using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Infrastructure
{
    public class ContactManagerContext : DbContext
    {
        public ContactManagerContext(DbContextOptions<ContactManagerContext> options)
            : base(options)
        {

        }

        public DbSet<ContactList.Contact> Contacts { get; set; }

    }
}
