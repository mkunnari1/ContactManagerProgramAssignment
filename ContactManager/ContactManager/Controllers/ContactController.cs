using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {

       

        
        public IActionResult Index()
        {
            var list = new ContactList();
            var contact = new ContactList.Contact();
            contact.Name = "Barry Bluejeans";

            list.Contacts.Add(contact);

            return View(list);
        }

 
    }
}