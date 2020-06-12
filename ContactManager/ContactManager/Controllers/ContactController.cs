using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using ContactManager.ViewModels;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    //Methods for Controllers are inside Services.ListService
    public class ContactController : Controller
    {
        private readonly ListService listService;

        public ContactController(ListService listService)
        {
            this.listService = listService;
        }

        //gets list of contacts from the db displays on page also manages search funtionality

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

        
        //Create new Contact store in DB Redirects to success view after.
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

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
        //Edit Contact, after edit is successful gives success message on view through TempData
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
        //Deletes Contact from DB and redirects to delete success view
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
        
        //Views for Successful Delete and Create
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