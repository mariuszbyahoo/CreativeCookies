using CreativeCookies.Data;
using CreativeCookies.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CreativeCookies.API.Controllers
{
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private PostsContext _ctx;

        public PostsController(PostsContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Returns all of the posts
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<Post[]>> GetAll()
        {
            return Ok(await _ctx.Read());
        }

        /// <summary>
        /// Returns specific post
        /// </summary>
        /// <param name="ID">ID of a post to return</param>
        /// <returns>200 HTTP Result with post which it was asked for</returns>
        [HttpGet]
        [Route("{ID}")]
        [Authorize(Roles = "paidUser, admin")]
        public async Task<ActionResult<Post>> Get(Guid ID)
        {
            var requiredPost = await _ctx.Read(ID);
            return Ok(requiredPost);
        }

        /// <summary>
        /// Modifies specific post
        /// </summary>
        /// <param name="post">New version of post</param>
        /// <returns>200 HTTP Result with updated post</returns>
        /// <exception cref="Exception">For development purposes</exception>
        [HttpPatch]
        [Route("{ID}")]
        [Authorize(Roles = "admin")]
        public ActionResult<Post> Patch([FromBody] Post post)
        {
            try
            {

                _ctx.Update(post);
                return Ok(post);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }

        /// <summary>
        /// Adds a new post
        /// </summary>
        /// <param name="post">Post to add</param>
        /// <returns>201 HTTP Result with an added post</returns>
        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Create(Post post)
        {
            // Manual Requests body to object binding caused by TS & C# dates incompatibility.
            try
            {
                string postAsString;
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    postAsString = await reader.ReadToEndAsync();
                }
                post = JsonConvert.DeserializeObject<Post>(postAsString);

                // according to TypeScript Date and C# DateTime incompatibility, have to set the creationDate on the server-side

                post.PublicationDate = DateTime.Now;
                _ctx.Add(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return CreatedAtAction(nameof(Create),post);
        }

        /// <summary>
        /// Deletes specific post
        /// </summary>
        /// <param name="ID">ID of a post to delete</param>
        /// <returns>204 HTTP Result</returns>
        [HttpDelete]
        [Route("{ID}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Delete(Guid ID)
        {

            await _ctx.Delete(ID);
            return NoContent();

        }
    }
}
