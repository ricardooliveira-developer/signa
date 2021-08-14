using Newtonsoft.Json;

namespace APISigna.domain.Results
{
    public class CatsResults
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
