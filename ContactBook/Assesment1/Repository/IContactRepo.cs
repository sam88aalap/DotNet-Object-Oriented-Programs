using System;
using Assesment1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1.Repository
{
    public interface IContactRepo
    {
        bool AddContacts(Contact contact);

        IEnumerable<Contact> GetContacts();
        bool UpdateContactByName(Contact contact);
        Contact GetContactByMob(string mobileNo);

        Contact GetContactByName(string name);

    }
}
