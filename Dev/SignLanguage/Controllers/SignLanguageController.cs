using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SignLanguage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignLanguageController : ControllerBase
    {
        private readonly ISignLanguageManager _signLanguageManager;

        public SignLanguageController(ISignLanguageManager signLanguageManager)
        {
            _signLanguageManager = signLanguageManager;
        }

        [HttpGet("{id}")]
        public ActionResult GetSignLanguage(int id)
        {
            try
            {
               return Ok(_signLanguageManager.Get(id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult GetAllSignLanguageWords()
        {
            try
            {
                return Ok(_signLanguageManager.GetAll());
            }
            catch
            {

                return BadRequest();
            }
        }
    }
}
