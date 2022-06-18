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
        /// Differentiates, does commenting post should be possible (and visible) for paid users
        /// </summary>
        /// <returns></returns>
        public IActionResult ToggleComments()
        {
            // HACK: TODO
            return Ok();
        }

        /// <summary>
        /// Differentiates, does rating a post should be possible for paid users
        /// </summary>
        /// <returns></returns>
        public IActionResult TogglePostsRating()
        {
            // HACK: TODO
            return Ok();
        }
    }
}
