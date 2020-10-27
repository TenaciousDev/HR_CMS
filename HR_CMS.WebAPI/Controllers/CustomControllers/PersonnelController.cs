using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HR_CMS.Models;
using HR_CMS.Services;

namespace HR_CMS.WebAPI.Controllers
{
    [Authorize]
    public class PersonnelController : ApiController
    {
        private PersonnelService CreatePersonnelService()
        {
            var personnelService = new PersonnelService();
            return personnelService;
        }
        [AcceptVerbs("GET")]
        
        public IHttpActionResult Get()
        {
            PersonnelService personnelService = CreatePersonnelService();
            var allPersonnel = personnelService.GetPersonnel();
            return Ok(allPersonnel);
        }
        [AcceptVerbs("GET")]
        public IHttpActionResult GetById(int id)
        {
            PersonnelService personnelService = CreatePersonnelService();
            var personnelById = personnelService.GetPersonnelById(id);
            return Ok(personnelById);
        }
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByActive()
        {
            PersonnelService personnelService = CreatePersonnelService();
            var personnelById = personnelService.GetActivePersonnel();
            return Ok(personnelById);
        }
        [AcceptVerbs("GET")]
        public IHttpActionResult GetByInactive()
        {
            PersonnelService personnelService = CreatePersonnelService();
            var personnelById = personnelService.GetInactivePersonnel();
            return Ok(personnelById);
        }
        public IHttpActionResult Post(PersonnelCreate personnelById)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePersonnelService();
            if (!service.CreatePersonnel(personnelById))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult PutUpdate(PersonnelDetail personnelId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePersonnelService();
            if (!service.UpdatePersonnel(personnelId))
                return InternalServerError();
            return Ok();
        }

        //public IHttpActionResult PutArchive(PersonnelArchive personnelById)
        //{
          //  if (!ModelState.IsValid)
            //    return BadRequest(ModelState);
            //var service = CreatePersonnelService();
            //if (!service.ArchivePersonnel(personnelById))
              //  return InternalServerError();
            //return Ok();
        //}
       
    }
}
