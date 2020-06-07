using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult CreateContact()
        {
            return View();
        }

        public IActionResult EditContact(int Id)
        {
            return View();
            
        }
    }
}