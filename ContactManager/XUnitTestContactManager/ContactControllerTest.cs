using System;
using ContactManager.Services;
using ContactManager.Controllers;
using ContactManager.Infrastructure;
using ContactManager.Models;
using ContactManager.ViewModels;
using Xunit;
using Autofac.Extras.Moq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace UnitTestContactManager
{
    public class ContactControllerTest
    {
        //private ListService listService;
        //public ContactControllerTest(ListService listService)
        //{
        //    this.listService = listService;
        //}
        [Fact]
       public void Create_Successful()
        {
            ContactList.Contact contact = new ContactList.Contact() { Id = 1, Name = "Test", Company = "Test", PhoneNumber = "555-555-5555", Email = "Test@test.com" };
            
        }
    }
}
