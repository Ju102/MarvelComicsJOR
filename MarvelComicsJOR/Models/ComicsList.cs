using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelComicsJOR.Models
{
    public class ComicsList
    {
        [JsonProperty("items")]
        public List<Comic> Comics { get; set; }
    }
}
