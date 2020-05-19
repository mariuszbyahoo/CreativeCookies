using CreativeCookies.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCookies.Data
{
    public class VideosContext: DbContext
    {
        public DbSet<Video> Videos { get; set; }

        public VideosContext(DbContextOptions<VideosContext> options) : base(options)
        {
        }

        /// <summary>
        /// Create, add new Video & Save Changes
        /// </summary>
        /// <param name="newVideo"></param>
        public void Add(Video newVideo)
        {
            Videos.Add(newVideo);
            SaveChanges();
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<Video> Read(Guid ID)
        {
            var arr = await Videos.ToArrayAsync();
            return arr.Where(v => v.Id.Equals(ID)).FirstOrDefault();
        }

        /// <summary>
        /// Read all videos.
        /// </summary>
        /// <returns></returns>
        public async Task<Video[]> Read()
        {
            return await Videos.ToArrayAsync();
        }

        /// <summary>
        /// Update & Save Changes
        /// </summary>
        /// <param name="newVideo"></param>
        public void Update(Video newVideo)
        {
            Videos.Update(newVideo);
            SaveChanges();
        }

        /// <summary>
        /// Delete & Save Changes
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task Delete(Guid ID)
        {
            var arr = await Videos.ToArrayAsync();
            Videos.Remove(arr
                .Where(v => v.Id.Equals(ID))
                .FirstOrDefault());
            SaveChanges();
        }
    }
}
