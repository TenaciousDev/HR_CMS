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
    [RoutePrefix("api/WorkInfo")]
    public class WorkInfoController : ApiController
    {
        private WorkInfoService CreateWorkInfoService()
        {
            
            var infoService = new WorkInfoService();
            return infoService;
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Post(WorkInfoCreate workinfo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateWorkInfoService();
            if (!service.CreateWorkInfo(workinfo))
                return InternalServerError();

            return Ok();
        }

        [Route("Edit")]
        [HttpPut]
        public IHttpActionResult Put (WorkInfoEdit workinfo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateWorkInfoService();

            if (!service.EditWorkInfo(workinfo))
                return InternalServerError();

            return Ok();
        }

        [Route("Info/{PersonnelId}")]
        [HttpGet]
        public IHttpActionResult GetByPersonnelId(int PersonnelId)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByPersonnelId(PersonnelId);
            return Ok(info);
        }

        [Route("Dept/{PersonnelId}")]
        [HttpGet]
        public IHttpActionResult GetDept(int PersonnelId)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetDeptByPersonnelId(PersonnelId);
            return Ok(info);
        }

        [Route("Position/{PersonnelId}")]
        [HttpGet]
        public IHttpActionResult GetPosition(int PersonnelId)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPositionByPersonnelId(PersonnelId);
            return Ok(info);
        }

        [Route("Personnel/{DeptId}")]
        [HttpGet]
        public IHttpActionResult GetPersonnelByDept(int DeptId)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPersonnelByDeptId(DeptId);
            return Ok(info);
        }

        //START OF GET ALL
        
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfo();
            return Ok(info);
        }

        [Route("AllSupervisors/{DeptId}")]
        [HttpGet]
        public IHttpActionResult GetAllSupervisorsByDept(int DeptId)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisorsByDept(DeptId);
            return Ok(info);
        }

        [Route("AllActive")]
        [HttpGet]
        public IHttpActionResult GetByActive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByActive();
            return Ok(info);
        }

        [Route("AllInactive")]
        [HttpGet]
        public IHttpActionResult GetByInactive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByInactive();
            return Ok(info);
        }

        [Route("AllDirectors")]
        [HttpGet]
        public IHttpActionResult GetDirectors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllDirectors();
            return Ok(info);
        }

        [Route("AllSupervisors")]
        [HttpGet]
        public IHttpActionResult GetSupervisors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisors();
            return Ok(info);
        }
        [Route("AllExecutives")]
        [HttpGet]
        public IHttpActionResult GetExecutives()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllExecutives();
            return Ok(info);
        }


    }
}
