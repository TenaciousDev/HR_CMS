using HR_CMS.Models;
using HR_CMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HR_CMS.WebAPI.Controllers
{
    [Authorize]
    public class ContactController : ApiController
    {
        private ContactService CreateContactService()
        {
            var createService = new ContactService();
            return createService;
        }

        public IHttpActionResult Get()
        {
            ContactService contactService = CreateContactService();
            var notes = contactService.GetContacts();
            return Ok(notes);
        }

        public IHttpActionResult Post(ContactCreate contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateContactService();

            if (!service.CreateContact(contact))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            ContactService contactService = CreateContactService();
            var contact = contactService.GetContactById(id);
            return Ok(contact);
        }

        /*public IHttpActionResult GetAllActive()
        {
            ContactService contactService = CreateContactService();
            var contact = contactService.GetContactForAllActive();
            return Ok(contact);
        }

        public IHttpActionResult GetAllInactive()
        {
            ContactService contactService = CreateContactService();
            var contact = contactService.GetContactForAllInactive();
            return Ok(contact);
        }*/

        public IHttpActionResult Put(ContactDetail contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateContactService();

            if (!service.UpdateContact(contact))
                return InternalServerError();

            return Ok();
        }
    }
}
