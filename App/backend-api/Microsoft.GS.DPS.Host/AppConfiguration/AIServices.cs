using System.Text.Json.Serialization;

namespace Microsoft.GS.DPSHost.AppConfiguration
{
    public class AIServices
    {
        [JsonPropertyName("GPT-5.2")]
        public ServiceConfig GPT_5_2 { get; set; }

        public ServiceConfig TextEmbedding { get; set; }

        public class ServiceConfig
        {
            public string Endpoint { get; set; }
            public string Key { get; set; }
            public string ModelName { get; set; }
        }
    }
}
