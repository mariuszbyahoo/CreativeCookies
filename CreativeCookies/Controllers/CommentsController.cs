using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCommentsForVideo(int videoId)
        {
            // HACK: TODO
            return Ok();
        }

        [HttpPost]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Add()
        {
            string obj = "Tę zmienną zamień z ID komentarza";
            // HACK: TODO
            return CreatedAtAction(nameof(Add), obj);
        }

        [HttpPost]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Update()
        {
            // HACK: TODO
            return Ok();
        }

        [HttpDelete]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Delete(int commentId)
        {
            // HACK: TODO
            return Ok();
        }
    }
}
