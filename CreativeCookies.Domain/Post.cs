using Newtonsoft.Json;
using System;

namespace CreativeCookies.Domain
{
    public class Post
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "publicationDate")]
        public DateTime PublicationDate { get; set; }

        [JsonProperty(PropertyName = "youtubeVideoUrl")]
        public string youtubeVideoUrl { get; set; }

        [JsonProperty(PropertyName = "youtubeVideoTrailerUrl")]
        public string youtubeVideoTrailerUrl { get; set; }

        // sample premium video ID : TGJiUNtOReI
        // sample trailer video ID : kmXUd6VLdj8 
    }

    public enum VideoAccess
    {
        Trailer = 0,
        Premium = 1
    }
}
