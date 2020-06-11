using System;
using System.Collections.Generic;
using System.Text;
using ContactManager.Infrastructure;
using ContactManager.Models;

namespace UnitTestContactManager
{
    class DummyDataDBInitializer
    {
        public DummyDataDBInitializer()
        {
        }

        public void Seed(ContactManagerTestContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Contacts.AddRange(new ContactList.Contact
            {

                Company = "Test",
                Name = "Test TEst",
                PhoneNumber = "555-555-5848",
                Email = "Test@test.com"
            },
            new ContactList.Contact
            {

                Company = "Test2",
                Name = "Test2 TEst2",
                PhoneNumber = "555-555-5248",
                Email = "Test@test.test"
            }) ;

            context.SaveChanges();

        }
    }
}
