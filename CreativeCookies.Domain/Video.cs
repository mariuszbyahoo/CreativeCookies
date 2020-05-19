using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreativeCookies.Domain
{
    public class Video
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}
