using CreativeCookies.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCookies.Data
{
    /// <summary>
    /// Used by AzureCosmosDb
    /// </summary>
    public interface IPostsContext
    {
        public Task Create(Post newPost);
        public Task<Post> Read(Guid ID);
        public Task<List<Post>> Read();
        public Task Update(Post newPost);
        public Task Delete(Guid ID);
    }
}
