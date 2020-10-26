using HR_CMS.Models;
using HR_CMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;

namespace HR_CMS.WebAPI.Controllers
{
    public class PositionController : ApiController
    {
        private PositionService CreatePositionService()
        {
            var createService = new PositionService();
            return createService;
        }
        public IHttpActionResult Get()
        {
            PositionService positionService = CreatePositionService();
            var positions = positionService.GetPositions();
            return Ok(positions);
        }
        public IHttpActionResult Post(PositionCreate position)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePositionService();
            if (!service.CreatePosition(position))
            {
                return InternalServerError();
            }
            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            PositionService positionService = CreatePositionService();
            var position = positionService.GetPositionById(id);
            return Ok(position);
        }
        public IHttpActionResult Put(PositionDetail position)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePositionService();
            if (!service.UpdatePosition(position))
            {
                return InternalServerError();
            }
            return Ok();
        }
    }
}
