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
    public class DonateImageController : ControllerBase
    {
        IDonateImageService _donateImageService;

        public DonateImageController(IDonateImageService donateImageService)
        {
            _donateImageService = donateImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _donateImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _donateImageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbydonateid")]
        public IActionResult GetImagesById([FromForm(Name = ("DonateId"))] int donateId)
        {
            var result = _donateImageService.GetImagesByDonateId(donateId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] DonateImage donateImage)
        {
            var result = _donateImageService.Add(file, donateImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var donateImage = _donateImageService.GetById(Id).Data;
            var result = _donateImageService.Delete(donateImage);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var donateImage = _donateImageService.GetById(Id).Data;
            var result = _donateImageService.Update(file, donateImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
