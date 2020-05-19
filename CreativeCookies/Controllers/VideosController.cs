using CreativeCookies.Data;
using CreativeCookies.Domain;
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

        private List<string> availableFormats = new List<string>
            {
                "3gp","asf","avi","dv","dvd","flv","m2ts",
                "mkv","mov","mp4","mpg","ogg","smv", "svcd",
                "ts", "wmv", "vcd"
            };
        public VideosController(VideosContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Uploads the desired video to server, plus, stores the fileName in associated DataBase's table (Videos)
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> UploadVideo(IFormFile file)
        {
            var video = new Video()
            {
                Id = Guid.NewGuid(),
                Title = file.FileName // store the fileName with format.
            };

            // store the title in the Database
            _ctx.Add(video);

            if (!availableFormats.Contains(file.FileName.Split(".")[1].ToLower()))
            {
                return BadRequest("Only formats listed at https://pl.wikipedia.org/wiki/Formaty_plik%C3%B3w_wideo are supported.");
            }
            var path = @"A://CreativeCookiesStorage/";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var fileName = Path.GetFileName($"{video.Title.Split(".")[0].ToLower()}.{video.Title.Split(".")[1].ToLower()}");
            string fullPath = path + fileName;

            var fileStream = new FileStream(fullPath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            return CreatedAtAction("UploadVideo", "File Uploaded Succesfully, filePath: '"+fullPath+"'");
        }
    }
}
/*"System.IO.IOException: The filename, directory name, or volume label syntax is incorrect. : 'A:\CreativeCookiesStorage\premium|7afead92-796c-45f5-9a54-47db13b1114a.mp4'
*/