using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        /// <summary>
        /// Serves for retrieving all commentaries for a specified video
        /// </summary>
        /// <param name="postId">Post for which comments are being retrieved</param>
        /// <returns>200 HTTP Result with IEnumerable of comments</returns>
        [HttpGet]
        public IActionResult GetCommentsForPost(int postId)
        {
            // HACK: TODO
            return Ok(/* IEnumerable with comments here */);
        }

        /// <summary>
        /// Adds new Comment
        /// </summary>
        /// <returns>201 HTTP Result with a newly added comment</returns>
        [HttpPost]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Add(/* Add comment here */)
        {
            string obj = "Tę zmienną zamień z obiektem Comment z body requestu";
            // HACK: TODO
            return CreatedAtAction(nameof(Add), obj);
        }

        /// <summary>
        /// Modifies an existing comment
        /// </summary>
        /// <returns>200 HTTP Result</returns>
        [HttpPatch]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Update(/* Add updated comment here */)
        {
            // HACK: TODO
            return Ok(/* Add updated comment here */);
        }

        /// <summary>
        /// Deletes an existing comment
        /// </summary>
        /// <param name="commentId">Comment to delete</param>
        /// <returns>204 NoContent HTTP Response</returns>
        [HttpDelete]
        [Authorize(Roles = "paidUser, admin")]
        public IActionResult Delete(int commentId)
        {
            // HACK: TODO
            return NoContent();
        }
    }
}
