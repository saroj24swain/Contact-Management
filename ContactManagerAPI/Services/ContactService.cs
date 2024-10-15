using ContactManagerAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactManagerAPI.Services
{
    public class ContactService
    {
        private static List<Contact> _contacts = new List<Contact>();
        private static int _idCounter = 1;

        public List<Contact> GetAllContacts() => _contacts;

        public Contact GetContactById(int id) => _contacts.FirstOrDefault(c => c.Id == id);

        public Contact AddContact(Contact newContact)
        {
            newContact.Id = _idCounter++;
            _contacts.Add(newContact);
            return newContact;
        }

        public Contact UpdateContact(int id, Contact updatedContact)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contact.FirstName = updatedContact.FirstName;
                contact.LastName = updatedContact.LastName;
                contact.Email = updatedContact.Email;
            }
            return contact;
        }

        public bool DeleteContact(int id)
        {
            var contact = _contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                _contacts.Remove(contact);
                return true;
            }
            return false;
        }
    }
}
