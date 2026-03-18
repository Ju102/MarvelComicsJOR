using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelComicsJOR.Models
{
    public class Comic
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Titulo { get; set; }

        [JsonProperty("detailUrl")]
        public string Url { get; set; }

        [JsonProperty("seriesName")]
        public string Serie { get; set; }

        [JsonProperty("yearPage")]
        public int Year { get; set; }
    }
}
