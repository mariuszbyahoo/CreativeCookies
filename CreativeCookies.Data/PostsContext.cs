﻿using CreativeCookies.Domain;
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
    public class PostsContext: DbContext
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
                    imageUrl = "assets/images/first.jpg",
                    videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
                },
                new Post
                {
                    Content = "And this is second post",
                    Description = "The description of second post",
                    PublicationDate = DateTime.Now.Date,
                    Title = "Second",
                    imageUrl = "assets/images/second.jpg",
                    videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
                },
                new Post
                {
                    Content = "And this is the third post",
                    Description = "It's description",
                    PublicationDate = DateTime.Now.AddDays(2.5),
                    Title = "Third",
                    imageUrl = "assets/images/third.jpg",
                    videoUrl = "https://www.youtube.com/embed/TGJiUNtOReI"
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
    }
}