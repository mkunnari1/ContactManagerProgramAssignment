using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using ContactManager.ViewModels;
using Microsoft.EntityFrameworkCore;
using ContactManager.Services;
using ContactManager.Infrastructure;

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
        
        public IActionResult Index()
        {
            ContactList list = listService.ListContacts();

            return View(list);
        }

        [HttpGet]
        public IActionResult Index(string searchContact)
        {
            if(searchContact == null)
            {
                ContactList allContacts = listService.ListContacts();

                return View(allContacts);
            }
            ViewData["GetContacts"] = searchContact;
            ContactList list = listService.ListContacts(searchContact);

            return View(list);
        }

        //[HttpGet]
        //public IActionResult SearchContact(string searchTerm)
        //{
        //    SearchContactList list = listService.contactSearch(searchTerm);
        //    return View(list);
        //}
        ////takes you to form for creating new contact
        //[HttpGet]
        //public IActionResult CreateContact()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult CreateContact(NewContact viewModel)
        {
            if (ModelState.IsValid)
            {
                listService.AddContact(viewModel);
                return RedirectToAction(nameof(Success));
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult EditContact(int id)
        {
            EditContact viewModel = listService.GetEdit(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditContact(EditContact contactEdit)
        {
            listService.Update(contactEdit);
            TempData["Message"] = "Contact Update Successful";
            return RedirectToAction(nameof(EditContact), new { id = contactEdit.Id });
        }

       [HttpGet]
       public IActionResult DeleteContact(int id)
        {
            ContactList.Contact viewModel = listService.GetDelete(id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult DeleteContact(ContactList.Contact contactDelete)
        {
            listService.Delete(contactDelete);
            return RedirectToAction(nameof(DeleteSuccess));
        }

        public IActionResult DeleteSuccess()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}