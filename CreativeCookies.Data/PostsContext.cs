using CreativeCookies.Domain;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCookies.Data
{
    /// <summary>
    /// Performs CreateReadUpdateDelete operations on the associated DataBase
    /// </summary>
    public class PostsContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public PostsContext(DbContextOptions<PostsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Content = "First seeded Post's content",
                    Description = "First seeded Post's description",
                    PublicationDate = DateTime.Now,
                    Title = "First",
                    youtubeVideoUrl = "TGJiUNtOReI",
                    youtubeVideoTrailerUrl = "kmXUd6VLdj8"
                },
                new Post
                {
                    Content = "And this is second post",
                    Description = "The description of second post",
                    PublicationDate = DateTime.Now.Date,
                    Title = "Second",
                    youtubeVideoUrl = "TGJiUNtOReI",
                    youtubeVideoTrailerUrl = "kmXUd6VLdj8"
                },
                new Post
                {
                    Content = "And this is the third post",
                    Description = "It's description",
                    PublicationDate = DateTime.Now.AddDays(2.5),
                    Title = "Third",
                    youtubeVideoUrl = "TGJiUNtOReI",
                    youtubeVideoTrailerUrl = "kmXUd6VLdj8"
                }
            );
        }

        /// <summary>
        /// Create, add new Post & Save Changes
        /// </summary>
        /// <param name="newPost"></param>
        public void Add(Post newPost)
        {
            Posts.Add(newPost);
            SaveChanges();
        }

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<Post> Read(Guid ID)
        {
            var arr = await Posts.ToArrayAsync();
            return arr.Where(p => p.Id.Equals(ID)).FirstOrDefault();
        }

        /// <summary>
        /// Read all posts.
        /// </summary>
        /// <returns></returns>
        public async Task<Post[]> Read()
        {
            return await Posts.ToArrayAsync();
        }

        /// <summary>
        /// Update & Save Changes
        /// </summary>
        /// <param name="newPost"></param>
        public void Update(Post newPost)
        {
            Posts.Update(newPost);
            SaveChanges();
        }

        /// <summary>
        /// Delete & Save Changes
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task Delete(Guid ID)
        {
            var arr = await Posts.ToArrayAsync();
            Posts.Remove(arr
                .Where(p => p.Id.Equals(ID))
                .FirstOrDefault());
            SaveChanges();
        }

        //private Container _container;

        //public PostsContext(CosmosClient cosmosClient, string dbId, string containerId)
        //{
        //    _container = cosmosClient.GetContainer(dbId, containerId);
        //}

        ///// <summary>
        ///// Create & Save Changes
        ///// </summary>
        ///// <param name="newPost"></param>
        //public async Task Create(Post newPost)
        //{  
        //    await _container.CreateItemAsync<Post>(newPost, new PartitionKey(newPost.Id.ToString()));
        //}

        ///// <summary>
        ///// Read
        ///// </summary>
        ///// <param name="ID"></param>
        ///// <returns></returns>
        //public async Task<Post> Read(Guid ID)
        //{
        //    var id = ID.ToString();
        //    try
        //    {
        //        ItemResponse<Post> response = await this._container.ReadItemAsync<Post>(id, new PartitionKey(id));
        //        return response.Resource;
        //    }
        //    catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        //    {
        //        return null;
        //    }
        //}

        ///// <summary>
        ///// Read all posts.
        ///// We may see a quite different approach to talking with a DB than in traditional SQL
        ///// </summary>
        ///// <returns></returns>
        //public async Task<List<Post>> Read()
        //{
        //    var query = this._container.GetItemQueryIterator<Post>("Select * from posts");
        //    List<Post> results = new List<Post>();
        //    while (query.HasMoreResults)
        //    {
        //        var response = await query.ReadNextAsync();

        //        results.AddRange(response.ToList());
        //    }

        //    return results;
        //}

        ///// <summary>
        ///// Delete & Save Changes
        ///// </summary>
        ///// <param name="ID"></param>
        ///// <returns></returns>
        //public async Task Delete(Guid ID)
        //{
        //    var id = ID.ToString();
        //    await this._container.DeleteItemAsync<Post>(id, new PartitionKey(id));
        //}

        ///// <summary>
        ///// Update & Save Changes
        ///// </summary>
        ///// <param name="newPost"></param>
        //public async Task Update(Post newPost)
        //{
        //    var id = newPost.Id.ToString();
        //    await this._container.ReplaceItemAsync<Post>(newPost, id);
        //}
    }
}