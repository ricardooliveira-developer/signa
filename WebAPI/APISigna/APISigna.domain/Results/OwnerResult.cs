using Newtonsoft.Json;


namespace APISigna.domain.Results
{
    public class OwnerResult
    {
        [JsonProperty("Id")]
        public int  Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
