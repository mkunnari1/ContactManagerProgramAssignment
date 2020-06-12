using System.Linq;
using ContactManager.Models;
using ContactManager.ViewModels;
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
        //list all contacts
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
        //return list of contacts containing or matching search string
        public ContactList ListContacts(string searchContacts)
        {
           
            var list = new ContactList();
            foreach (var contact in dbContext.Contacts.Where(x => x.Company.Contains(searchContacts)
            || x.Name.Contains(searchContacts) || x.Email.Contains(searchContacts) || x.Id.ToString().Contains(searchContacts) ))
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

        //Functions to edit contact first delivers contact to the view for editing, second saves edits to DB
        public EditContact GetEdit(int id)
        {
            var contact = dbContext.Contacts.SingleOrDefault(x => x.Id == id);
            if (contact == null)
            {
                return new EditContact();
            }
            return new EditContact
            {
                Id = contact.Id,
                Company = contact.Company,
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber,
                Email = contact.Email
            };
        }

        public void Update(EditContact contactEdit)
        {
            var contact = dbContext.Contacts.SingleOrDefault(x => x.Id == contactEdit.Id);
                contact.Company = contactEdit.Company;
                contact.Name = contactEdit.Name;
                contact.PhoneNumber = contactEdit.PhoneNumber;
                contact.Email = contactEdit.Email;

                dbContext.SaveChanges();
        }

        //Functions to delete contact first delivers contact to the view for delete verification, second removes contact from DB
        public ContactList.Contact GetDelete(int id)
        {
            var contact = dbContext.Contacts.SingleOrDefault(x => x.Id == id);
            if (contact == null)
            {
                return new ContactList.Contact();
            }
            return new ContactList.Contact
            {
                Id = contact.Id,
                Company = contact.Company,
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber,
                Email = contact.Email
            };
        }

        public void Delete(ContactList.Contact contactDelete)
        {
            dbContext.Contacts.Remove(contactDelete);
            dbContext.SaveChanges();
        }
    }
}
