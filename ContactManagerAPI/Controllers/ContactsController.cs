using Microsoft.AspNetCore.Mvc;
using ContactManagerAPI.Models;
using ContactManagerAPI.Services;

namespace ContactManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactsController(ContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/contacts
        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(_contactService.GetAllContacts());
        }

        // GET: api/contacts/{id}
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var contact = _contactService.GetContactById(id);
            if (contact == null)
                return NotFound();
            return Ok(contact);
        }

        // POST: api/contacts
        [HttpPost]
        public IActionResult CreateContact(Contact newContact)
        {
            var contact = _contactService.AddContact(newContact);
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }

        // PUT: api/contacts/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, Contact updatedContact)
        {
            var contact = _contactService.UpdateContact(id, updatedContact);
            if (contact == null)
                return NotFound();
            return NoContent();
        }

        // DELETE: api/contacts/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var deleted = _contactService.DeleteContact(id);
            if (!deleted)
                return NotFound();
            return NoContent();
        }
    }
}
