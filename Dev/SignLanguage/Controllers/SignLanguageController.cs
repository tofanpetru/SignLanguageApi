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

        // GET: api/Flight/5
        [HttpGet("[controller]/{id}")]
        public ActionResult<SignLanguageWordDetailsDTO> GetSignLanguageResult(int id)
        {
            var signLanguage = _signLanguageManager.GetSignLanguageWordDetails(id);

            return signLanguage;
        }
    }
}
