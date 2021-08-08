using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FivemUserController : ControllerBase
    {
        IFivemUserService _fivemUserService;

        public FivemUserController(IFivemUserService fivemUserService)
        {
            _fivemUserService = fivemUserService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fivemUserService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("getbyid")]
        //public IActionResult GetById(int identifier)
        //{
        //    var result = _fivemUserService.GetById(identifier);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("delete")]
        public IActionResult Delete(FivemUser fivemUser)
        {
            var result = _fivemUserService.Delete(fivemUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(FivemUser fivemUser)
        {
            var result = _fivemUserService.Update(fivemUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
