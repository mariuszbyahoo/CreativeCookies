using CreativeCookies.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<ActionResult> UploadVideo(IFormFile file)
        {
            var availableFormats = new List<string>
            {
                "3gp","asf","avi","dv","dvd","flv","m2ts",
                "mkv","mov","mp4","mpg","ogg","smv", "svcd",
                "ts", "wmv", "vcd"
            };
            if (!availableFormats.Contains(file.FileName.Split(".")[1].ToLower()))
            {
                return BadRequest("Only formats listed at https://pl.wikipedia.org/wiki/Formaty_plik%C3%B3w_wideo are supported.");
            }
            var path = @"A://CreativeCookiesStorage";
            // now implement the procedure, to store uploaded video on a hard drive.
            //return Ok($"{file.FileName} size: {file.Length} bytes");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            // ID of a file
            var uniqueFileName = Guid.NewGuid().ToString();
            var fileName = Path.GetFileName(file.FileName.Split(".")[0].ToLower() + "." + file.FileName.Split(".")[1].ToLower());
            path = path + @"/";
            string fullPath = path + fileName;



            var fileStream = new FileStream(fullPath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            return Ok($"Check the folder: {path}");
        }
    }
}