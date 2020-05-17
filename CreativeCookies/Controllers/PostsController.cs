using CreativeCookies.Data;
using CreativeCookies.Domain;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Linq.Expressions;
using IdentityModel;
using Microsoft.Azure.Cosmos.Linq;

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

        [HttpGet]
        public async Task<ActionResult<Post[]>> GetAll()
        {
            return Ok(await _ctx.Read());
        }

        [HttpGet]
        [Route("{ID}")]
        [Authorize(Roles = "paidUser, admin")]
        public async Task<ActionResult<Post>> Get(Guid ID)
        {
            var requiredPost = await _ctx.Read(ID);
            return Ok(requiredPost);
        }

        [HttpPatch]
        [Route("{ID}")]
        [Authorize(Roles = "admin")]
        public ActionResult<Post> Patch(Guid ID, [FromBody] Post post)
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

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> Create(Post post)
        {
            // Manual Requests body to object binding caused by TS & C# dates incompatibility.
            try
            {
                string postObject;
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    postObject = await reader.ReadToEndAsync();
                }
                post = JsonConvert.DeserializeObject<Post>(postObject);

                // according to TypeScript Date and C# DateTime incompatibility, have to set the creationDate on the server-side

                post.PublicationDate = DateTime.Now;
                _ctx.Add(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(post);
        }

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
