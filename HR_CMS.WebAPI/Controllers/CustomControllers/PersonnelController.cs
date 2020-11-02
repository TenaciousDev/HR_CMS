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
    [RoutePrefix("api/Personnel")]
    public class PersonnelController : ApiController
    {
        private PersonnelService CreatePersonnelService()
        {
            var personnelService = new PersonnelService();
            return personnelService;
        }
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            PersonnelService personnelService = CreatePersonnelService();
            var allPersonnel = personnelService.GetPersonnel();
            return Ok(allPersonnel);
        }

        [Route("Personnel/{PersonnelId}")]
        [HttpGet]
        public IHttpActionResult GetById(int PersonnelId)
        {
            PersonnelService personnelService = CreatePersonnelService();
            var personnelById = personnelService.GetPersonnelById(PersonnelId);
            return Ok(personnelById);
        }
        
        [Route("AllActive")]
        [HttpGet]
        public IHttpActionResult GetByActive()
        {
          PersonnelService personnelService = CreatePersonnelService();
        var personnelById = personnelService.GetActivePersonnel();
        return Ok(personnelById);
        }
        
        [Route("AllInactive")]
        [HttpGet]
        public IHttpActionResult GetByInactive()
        {
          PersonnelService personnelService = CreatePersonnelService();
        var personnelById = personnelService.GetInactivePersonnel();
        return Ok(personnelById);
        }
        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Post(PersonnelCreate personnelById)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePersonnelService();
            if (!service.CreatePersonnel(personnelById))
                return InternalServerError();
            return Ok();
        }
        [Route("Edit")]
        [HttpPut]
        public IHttpActionResult PutUpdate(PersonnelDetail personnelId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePersonnelService();
            if (!service.UpdatePersonnel(personnelId))
                return InternalServerError();
            return Ok();
        }
        [Route("Archive")]
        [HttpPut]
        public IHttpActionResult PutArchive(PersonnelArchive personnelById)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePersonnelService();
            if (!service.ArchivePersonnel(personnelById))
                return InternalServerError();
            return Ok();
        }

    }
}
