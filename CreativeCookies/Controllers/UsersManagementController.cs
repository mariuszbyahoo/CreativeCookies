using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
    public class UsersManagementController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            // HACK: TODO
            return Ok();
        }

        [HttpPost("sendMail")]
        public IActionResult SendMailToUsers(IEnumerable<int> usersIds, string emailSubject, string emailContext)
        {
            // HACK: TODO

            // Czy nie lepiej będzie przekazywać obiekt MimeMessage i użyć metody "BuildMessage" - coś w tym stylu? 
            // Tzn tworzeniem maila zajmie się serwis zewnętrzny, natomiast wysyłaniem IMailService, żeby rozdzielić 
            // tworzenie maila na kilka części i wtedy będzie można używać tej metody w różnych częściach aplikacji

            // no i jak to rozdzielić żeby do metody trafiło kilka różnych typów danych? W HTTP body?
            return Ok();
        }

        [HttpPut("toggleAccess")]
        public IActionResult ToggleAccessForUser(int userId)
        {
            // HACK: TODO

            return Ok();
        }

        [HttpPut("toggleAccessGeographically")]
        public IActionResult ToggleAccessGeographically(string countryCode)
        {
            // HACK: TODO

            return Ok();
        }

    }
}
