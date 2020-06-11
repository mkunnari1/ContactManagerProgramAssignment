using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Infrastructure
{
    public class ContactManagerTestContext : DbContext
    {

        public ContactManagerTestContext(DbContextOptions<ContactManagerTestContext> options)
            : base(options)
        {

        }

        public DbSet<ContactList.Contact> Contacts { get; set; }
    }
}
