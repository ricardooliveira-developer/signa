using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Results
{
    public class DogsResult
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Age")]
        public int Age { get; set; }

        [JsonProperty("OwnerId")]
        public int OwnerId { get; set; }
    }
}
