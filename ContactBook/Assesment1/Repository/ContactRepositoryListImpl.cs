using System;
using Assesment1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1.Repository
{
    public class ContactRepositoryListImpl : IContactRepo
    {

        List<Contact> contactBook = new List<Contact>();
        public bool AddContacts(Contact contact)
        {
            bool isAdded = false;
            this.contactBook.Add(contact);
            isAdded = true;
            return isAdded;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return this.contactBook;
        }


        public bool UpdateContactByName(Contact contact)
        {
            bool isUpdated = false;
            string newMobileno = "9087654456";
            string newEmail = "amaljose@gmail.com";
            //foreach (var oldContact in contactBook)
            //{
            //    if(oldContact.ContactName.Equals(contact.ContactName)
            //    {
            //        oldContact.Email = contact.Email;
            //        oldContact.Email = contact.Email;
            //    }
            //}
            var contactToModify = contactBook.FirstOrDefault(x => x.ContactName.Equals(contact.ContactName));
            if (contactToModify != null)
            {
                contactToModify.MobileNumber = newMobileno;
                contactToModify.Email = newEmail;
                isUpdated = true;
            }
            return isUpdated;
        }

        public Contact GetContactByMob(string mobileNo)
        {
            return this.contactBook.FirstOrDefault(x => x.MobileNumber.Equals(mobileNo));
        }

        public Contact GetContactByName(string name)
        {
            return this.contactBook.FirstOrDefault(x => x.ContactName.Equals(name));
        }
    }
}
