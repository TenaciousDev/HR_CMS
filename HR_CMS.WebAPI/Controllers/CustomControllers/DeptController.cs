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
    [RoutePrefix("api/Dept")]
    public class DeptController : ApiController
    {
        private DeptService CreateDeptService()
        {
            var createService = new DeptService();
            return createService;
        }
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            DeptService deptService = CreateDeptService();
            var depts = deptService.GetDepts();
            return Ok(depts);
        }

        [Route("Create")]
        [HttpPost]
        public IHttpActionResult Post(DeptCreate dept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreateDeptService();
            if (!service.CreateDept(dept))
            {
                return InternalServerError();
            }
            return Ok();
        }

        [Route("{DeptId}")]
        [HttpGet]
        public IHttpActionResult Get(int DeptId)
        {
            DeptService deptService = CreateDeptService();
            var dept = deptService.GetDeptById(DeptId);
            return Ok(dept);
        }

        [Route("Edit")]
        [HttpPut]
        public IHttpActionResult Put(DeptDetail dept)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreateDeptService();
            if (!service.UpdateDept(dept))
            {
                return InternalServerError();
            }
            return Ok();
        }
    }
}
