using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    //Defines base level Contact, Children classes should be made for specific circumstances
    public class ContactList
    {
       
        //List was Instantiated here as a fail safe so there's no way it could be forgotten
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public class Contact
        {
            public int Id { get; set; }
            public string Company { get; set; }
            public string Name { get; set; }
            [DisplayName("Phone Number")]
            public string PhoneNumber { get; set; }
            public string Email { get; set; }


        }
    }
    
}
