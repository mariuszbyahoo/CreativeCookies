using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class CashFlowController : ControllerBase
    {
        /// <summary>
        /// Toggles the existence of paidSubscription
        /// </summary>
        /// <returns>200 HTTP Ok Resposne</returns>
        [HttpPut]
        public IActionResult TogglePaidSubscription()
        {
            // HACK: TODO 
            return Ok();
        }

        /// <summary>
        /// Toggles an option to buy single video
        /// </summary>
        /// <returns>200 HTTP Ok Response</returns>
        [HttpPut]
        public IActionResult ToggleTradeOfIndividualVideos()
        {
            // HACK: TODO
            return Ok();
        }

        /// <summary>
        /// Toggles an option to send non refundable donations to the user
        /// </summary>
        /// <returns>200 HTTP Ok Response</returns>
        [HttpPut]
        public IActionResult ToggleDonations()
        {
            // HACK: TODO
            return Ok();
        }

        /// <summary>
        /// Toggles an option to use Premium Subscribent account (2nd lvl of subscribents)
        /// </summary>
        /// <returns>200 HTTP Ok Response</returns>
        [HttpPut]
        public IActionResult TogglePremiumSubscribentAccount()
        {
            // HACK: TODO
            return Ok();
        }
    }
}
