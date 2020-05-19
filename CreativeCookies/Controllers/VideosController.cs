using CreativeCookies.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CreativeCookies.Controllers
{
    [Route("api/[controller]")]
    public class VideosController : ControllerBase
    {
        public VideosContext _ctx;

        public VideosController(VideosContext ctx)
        {
            _ctx = ctx;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult UploadVideo(IFormFile file)
        {
            return Ok($"{file.FileName} size: {file.Length} bytes");
        }
    }
}
