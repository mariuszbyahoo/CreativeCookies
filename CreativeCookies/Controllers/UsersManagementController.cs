using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "admin")]
    public class UsersManagementController : ControllerBase
    {
        /// <summary>
        /// Returns an IEnumerable of all registered users in app
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            // HACK: TODO
            return Ok();
        }

        /// <summary>
        /// Sends an e-mail to selected users.
        /// </summary>
        /// <param name="usersIds">Adressees</param>
        /// <param name="emailSubject">Subject of an e-mail</param>
        /// <param name="emailContent">Content of an e-mail</param>
        /// <returns></returns>
        [HttpPost("sendMail")]
        public IActionResult SendMailToUsers(IEnumerable<int> usersIds, string emailSubject, string emailContent)
        {
            // HACK: TODO

            // Czy nie lepiej będzie przekazywać obiekt MimeMessage i użyć metody "BuildMessage" - coś w tym stylu? 
            // Tzn tworzeniem maila zajmie się serwis zewnętrzny, natomiast wysyłaniem IMailService, żeby rozdzielić 
            // tworzenie maila na kilka części i wtedy będzie można używać tej metody w różnych częściach aplikacji

            // no i jak to rozdzielić żeby do metody trafiło kilka różnych typów danych? W HTTP body?
            return Ok();
        }

        /// <summary>
        /// Toggles an access to the app for a specific user
        /// </summary>
        /// <param name="userId">ID of an user to toggle an access for</param>
        /// <returns></returns>
        [HttpPut("toggleAccess")]
        public IActionResult ToggleAccessForUser(int userId)
        {
            // HACK: TODO

            return Ok();
        }

        /// <summary>
        /// Toggles an access to the app geographically, i.e. for all users from a specific country
        /// </summary>
        /// <param name="countryCode">Code of an country to toggle an access for</param>
        /// <returns></returns>
        [HttpPut("toggleAccessGeographically")]
        public IActionResult ToggleAccessGeographically(string countryCode)
        {
            // HACK: TODO

            return Ok();
        }

    }
}
