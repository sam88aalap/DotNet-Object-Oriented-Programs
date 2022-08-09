using Assesment1.Models;
using Assesment1.Repository;
using System;
using System.Collections.Generic;

namespace Assesment1
{
    class Program
    {

        static void Main(string[] args)
        {
            IContactRepo contactRepo = new ContactRepositoryListImpl();
            //1.create contacts
            Contact contact1 = new Contact() { ContactName = "Tony", MobileNumber = "9545678909", Email = "tonystark@gmail.com" };
            Contact contact2 = new Contact() { ContactName = "Steve", MobileNumber = "8787659823", Email = "steverogers@gmail.com" };
            Contact contact3 = new Contact() { ContactName = "Banners", MobileNumber = "9987567754", Email = "brucebanners@gmail.com" };
            Contact contact4 = new Contact() { ContactName = "Natasha", MobileNumber = "9870651434", Email = "natasharominof@gmail.com" };
            Contact contact5 = new Contact() { ContactName = "Barton", MobileNumber = "8905678734", Email = "clintbarton@gmail.com" };

            //2.Add Contacts to Contact list
            contactRepo.AddContacts(contact1);
            contactRepo.AddContacts(contact2);
            contactRepo.AddContacts(contact3);
            contactRepo.AddContacts(contact4);
            contactRepo.AddContacts(contact5);

            //3.DisplayContact
            DisplayContacts(contactRepo);


            //4.Get Contact by Id
            DisplayContactByMobile(contactRepo);


            //5.Get Contact by Name
            DisplayContactByName(contactRepo);

            //6.Update Contact
            UpdateContactByName(contactRepo);
        }

        private static void DisplayContactByName(IContactRepo contactRepo)
        {
            string name = "Tony";
            var contact = contactRepo.GetContactByName(name);
            if (contact == null)
            {
                Console.WriteLine($"Contact with {name}  does not exists");
            }
            else
            {
                Console.WriteLine($"Contact By Name: {name}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name: {contact.ContactName}\tMobile Number: {contact.MobileNumber}\tEmail: {contact.Email}");
                Console.WriteLine();
            }

        }

        private static void DisplayContactByMobile(IContactRepo contactRepo)
        {
            string mobileNumber = "9870651434";
            var contact = contactRepo.GetContactByMob(mobileNumber);
            if (contact == null)
            {
                Console.WriteLine($"Contact with {mobileNumber} number does not exists");
            }
            else
            {
                Console.WriteLine($"Contact By Mobile Number: {mobileNumber}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Name:{contact.ContactName}\tMobile Number{contact.MobileNumber}\tEmail:{contact.Email}");
                Console.WriteLine();
            }

        }

        private static void UpdateContactByName(IContactRepo contactRepo)
        {
            string updateByName = "Natasha";
            var updateContact = contactRepo.GetContactByName(updateByName);
            bool isUpdated = contactRepo.UpdateContactByName(updateContact);
            if (isUpdated == true)
            {
                Console.WriteLine($"The Contact info of {updateByName} is Updated Successfully");
                foreach (var contact in contactRepo.GetContacts())
                {
                    Console.WriteLine($"{contact.ContactName}\t{contact.MobileNumber}\t{contact.Email}");
                }
            }
            else
            {
                Console.WriteLine("Contact Not Updated");
            }
        }

        private static void DisplayContacts(IContactRepo contactRepo)
        {
            Console.WriteLine("Contact Information");
            Console.WriteLine("----------------------");
            Console.WriteLine("Name\tMobileNumber\tEmail");
            foreach (var contact in contactRepo.GetContacts())
            {
                Console.WriteLine($"{contact.ContactName}\t{contact.MobileNumber}\t{contact.Email}");
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }
    }
}
