using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Results
{
    public class PadraoResult
    {
        [JsonProperty("feedback")]
        public string FeedBack { get; set; }
    }
}
