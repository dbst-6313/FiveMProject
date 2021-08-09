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
    public class DonateController : ControllerBase
    {
        IDonateService _donateService;

        public DonateController(IDonateService donateService)
        {
            _donateService = donateService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _donateService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _donateService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Donate donate)
        {
            var result = _donateService.Add(donate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Donate donate)
        {
            var result = _donateService.Delete(donate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Donate donate)
        {
            var result = _donateService.Update(donate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }

}
