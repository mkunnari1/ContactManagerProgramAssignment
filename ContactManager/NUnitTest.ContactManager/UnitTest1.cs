using NUnit.Framework;
using ContactManager.Models;
using ContactManager.Services;
using ContactManager.Controllers;
using ContactManager.Infrastructure;
using ContactManager.ViewModels;
using Moq;

namespace NUnitTest.ContactManager
{
    [TestFixture]
    public class ContactControllerTests
    {
        private readonly ContactManagerContext dbContext;
       
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void List_All_Contacts()
        {
            var listServiceMock = new Mock<ListService(dbContext) >;
            var contactController = new ContactController(listServiceMock);

            contactController.Index(null);
            Assert.Pass();
        }
    }
}