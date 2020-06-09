using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;
using ContactManager.ViewModels;
using Microsoft.EntityFrameworkCore;
using ContactManager.Infrastructure;

namespace ContactManager.Services
{
    public class ListService
    {
        private readonly ContactManagerContext dbContext;

        public ListService(ContactManagerContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ContactList ListContacts()
        {
            var list = new ContactList();
            foreach(var contact in dbContext.Contacts)
            {
                list.Contacts.Add(new ContactList.Contact
                {
                    Id = contact.Id,
                    Name = contact.Name,
                    Company = contact.Company,
                    Email = contact.Email,
                    PhoneNumber = contact.PhoneNumber
                });
            }
            return list;
        }

        public ListView viewList()
        {
            var model = new ListView();
            var column = new ListView.Column { Title = "Contact" };


            var card = new ListView.Card { Content = "Here is a contact card" };


            column.Cards.Add(card);
            model.Columns.Add(column);
            return model;
        }

        public void AddContact(NewContact viewModel)
        {
            dbContext.Contacts.Add(new ContactList.Contact
            {
                Company = viewModel.Company,
                Name = viewModel.Name,
                PhoneNumber = viewModel.PhoneNumber,
                Email = viewModel.Email

            });

            dbContext.SaveChanges();
        }
    }
}
