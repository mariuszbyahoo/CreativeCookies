using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class UsersInteractionSettingsController : ControllerBase
    {
        /// <summary>
        /// Differentiates, does commenting videos should be possible (and visible) for paid users
        /// </summary>
        /// <returns></returns>
        public IActionResult ToggleComments()
        {
            // HACK: TODO
            return Ok();
        }

        /// <summary>
        /// Differentiates, does rating a videos should be possible for paid users
        /// </summary>
        /// <returns></returns>
        public IActionResult ToggleVideoRating()
        {
            // HACK: TODO
            return Ok();
        }
    }
}
