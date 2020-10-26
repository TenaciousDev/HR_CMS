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
    public class DeptController : ApiController
    {
        private DeptService CreateDeptService()
        {
            var createService = new DeptService();
            return createService;
        }
        public IHttpActionResult Get()
        {
            DeptService deptService = CreateDeptService();
            var depts = deptService.GetDepts();
            return Ok(depts);
        }
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
        public IHttpActionResult Get(int id)
        {
            DeptService deptService = CreateDeptService();
            var dept = deptService.GetDeptById(id);
            return Ok(dept);
        }
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
