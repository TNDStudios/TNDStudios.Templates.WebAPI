using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /// <summary>
    /// Contacts
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Query the available stored contacts
        /// </summary>
        /// <returns>An array of contacts</returns>
        [HttpGet]
        [Route("Query")]
        public IEnumerable<ContactVM> QueryContacts()
        {
            return new List<ContactVM>() { };
        }

        /// <summary>
        /// Save a contact
        /// </summary>
        /// <param name="contact">The contact model to be saved</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            return Ok(new ContactVM() { });
        }

        [HttpPatch]
        public IActionResult Merge(Contact contact)
        {
            return Ok(new ContactVM() { });
        }

    }
}