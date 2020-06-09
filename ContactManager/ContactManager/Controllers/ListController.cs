using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactManager.ViewModels;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    public class ListController : Controller
    {
        private readonly ListService listService;

        public ListController(ListService listService)
        {
            this.listService = listService;
        }
        public IActionResult Index()
        {
            ListView model = listService.viewList();

            return View(model);
        }

       
    }
}