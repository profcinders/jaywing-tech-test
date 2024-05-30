using System.Text.Json.Serialization;

namespace JaywingTechTest.Features.CatFacts.Models
{
    public class CatFact
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        public string Text { get; set; }
    }
}
