using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class VideoTradeController : ControllerBase
    {
        [HttpPut]
        public IActionResult TogglePaidSubscription()
        {
            // HACK: TODO 
            return Ok();
        }

        [HttpPut]
        public IActionResult ToggleTradeOfIndividualVideos()
        {
            // HACK: TODO
            return Ok();
        }

        [HttpPut]
        public IActionResult ToggleDonations()
        {
            // HACK: TODO
            return Ok();
        }

        [HttpPut]
        public IActionResult TogglePremiumSubscribentAccount()
        {
            // HACK: TODO
            return Ok();
        }
    }
}
