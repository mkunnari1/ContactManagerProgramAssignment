using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using ContactManager.ViewModels;
using Microsoft.EntityFrameworkCore;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    
    public class ContactController : Controller
    {
        private readonly ListService listService;

        public ContactController(ListService listService)
        {
            this.listService = listService;
        }
       
        //gets list of contacts from the db displays on page
        [HttpGet]
        public IActionResult Index()
        {
            ContactList list = listService.ListContacts();

            return View(list);
        }
        //takes you to form for creating new contact
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(NewContact viewModel)
        {
            listService.AddContact(viewModel);
            return RedirectToAction(nameof(Success));
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}