﻿using CreativeCookies.Data;
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
        public async Task<ActionResult<Post>> Get(Guid ID)
        {
            var requiredPost = await _ctx.Read(ID);
            return Ok(requiredPost);
        }

        [HttpPatch]
        [Route("{ID}")]
        public ActionResult<Post> Patch(Guid ID, [FromBody] Post post)
        {
            _ctx.Update(post);
            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult> Create (Post post)
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
            } catch(Exception ex)
            {
                throw ex;
            }

            return Ok(post);
        }

        [HttpDelete]
        [Route("{ID}")]
        public async Task<ActionResult> Delete (Guid ID)
        {
            await _ctx.Delete(ID);
            return NoContent();
        }
    }
}