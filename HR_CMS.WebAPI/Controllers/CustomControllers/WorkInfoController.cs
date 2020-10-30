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
        public IHttpActionResult GetByPersonnelId(int personnelIdA)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByPersonnelId(personnelIdA);
            return Ok(info);
        }
        public IHttpActionResult GetDept(int personnelIdB)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetDeptByPersonnelId(personnelIdB);
            return Ok(info);
        }
        public IHttpActionResult GetPosition(int personnelIdC)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPositionByPersonnelId(personnelIdC);
            return Ok(info);
        }
        public IHttpActionResult GetPersonnelByDept(int deptIdA)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetPersonnelByDeptId(deptIdA);
            return Ok(info);
        }
        public IHttpActionResult GetAllSupervisorsByDept(int deptIdB)
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisorsByDept(deptIdB);
            return Ok(info);
        }

        //START OF GET ALL

        [Route("api/WorkInfo/GetAll")]
        public IHttpActionResult Get()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfo();
            return Ok(info);
        }

        [Route("api/WorkInfo/GetByActive")]
        public IHttpActionResult GetByActive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByActive();
            return Ok(info);
        }
        [Route("api/WorkInfo/GetByInactive")]
        public IHttpActionResult GetByInactive()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetWorkInfoByInactive();
            return Ok(info);
        }
        [Route("api/WorkInfo/GetAllDirectors")]
        public IHttpActionResult GetDirectors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllDirectors();
            return Ok(info);
        }
        [Route("api/WorkInfo/GetAllSupervisors")]
        public IHttpActionResult GetSupervisors()
        {
            WorkInfoService infoService = CreateWorkInfoService();
            var info = infoService.GetAllSupervisors();
            return Ok(info);
        }


    }
}
