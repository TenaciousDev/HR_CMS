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
    public class WorkInfoController : ApiController
    {
        private WorkInfoService CreateWorkInfoService()
        {
            
            var infoService = new WorkInfoService();
            return infoService;
        }
        public IHttpActionResult Post(WorkInfoCreate workinfo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateWorkInfoService();
            if (!service.CreateWorkInfo(workinfo))
                return InternalServerError();

            return Ok();
           
        }
        public IHttpActionResult Put (WorkInfoEdit workinfo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateWorkInfoService();

            if (!service.EditWorkInfo(workinfo))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfo(id);
            return Ok(info);
        }
        public IHttpActionResult GetDept(int id)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetDeptByPersonnelId(id);
            return Ok(info);
        }
        public IHttpActionResult GetPosition(int id)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPositionByPersonnelId(id);
            return Ok(info);
        }
        public IHttpActionResult Get()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfo();
            return Ok(info);
        }
        public IHttpActionResult GetByActive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByActive();
            return Ok(info);
        }
        public IHttpActionResult GetByInactive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByInactive();
            return Ok(info);
        }
        public IHttpActionResult GetPersonnelByDept(int id)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPersonnelByDeptId(id);
            return Ok(info);
        }
        public IHttpActionResult GetDirectors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllDirectors();
            return Ok(info);
        }
        public IHttpActionResult GetSupervisors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisors();
            return Ok(info);
        }

        public IHttpActionResult GetSupervisorsByDept(int id)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisorsByDept(id);
            return Ok(info);
        }

    }
}
