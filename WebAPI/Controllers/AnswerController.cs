using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : Controller
    {
        IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _answerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getanswerdetails")]
        public IActionResult GetAnswerDetails()
        {
            var result = _answerService.GetAnswerDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getactiveanswers")]
        public IActionResult GetActiveAnswers()
        {
            var result = _answerService.GetAcceptedAnswers();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getdeniedanswers")]
        public IActionResult GetDeniedAnswers()
        {
            var result = _answerService.GetDeniedAnswers();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getanswerdetailsbyid")]
        public IActionResult GetAnswerDetailsById(int id)
        {
            var result = _answerService.GetAnswerDetailsByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _answerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("deletebyid")]
        public IActionResult DeleteById(int userId)
        {
            var entity = _answerService.GetById(userId);
            var result = _answerService.Delete(entity.Data);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Answer answer)
        {
            var result = _answerService.Add(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("changestatedenied")]
        public IActionResult changeStateDenied(int id)
        {
            var result = _answerService.changeStateDenied(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("changestateaccepted")]
        public IActionResult changeStateAccepted(int id)
        {
            var result = _answerService.changeStateAccept(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Answer answer)
        {
            var result = _answerService.Delete(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Answer answer)
        {
            var result = _answerService.Update(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
