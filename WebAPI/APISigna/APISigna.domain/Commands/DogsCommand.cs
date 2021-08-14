using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Commands
{
    public class DogsCommand
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }
    }
}
