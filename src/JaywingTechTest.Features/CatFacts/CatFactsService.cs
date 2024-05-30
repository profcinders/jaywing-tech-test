using System.Net.Http.Json;
using System.Text.Json;
using JaywingTechTest.Features.CatFacts.Models;
using Microsoft.Extensions.Logging;

namespace JaywingTechTest.Features.CatFacts
{
    public class CatFactsService(HttpClient httpClient, ILogger<CatFactsService> logger) : ICatFactsService, IDisposable
    {
        public async Task<Response<IEnumerable<CatFact>>> GetFacts()
        {
            try
            {
                var facts = await httpClient.GetFromJsonAsync<IEnumerable<CatFact>>("facts", new JsonSerializerOptions(JsonSerializerDefaults.Web));
                return new Response<IEnumerable<CatFact>>
                {
                    Success = true,
                    Value = facts?.Where(f => f != null) ?? []
                };
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to retrieve cat facts");
                return new Response<IEnumerable<CatFact>>
                {
                    Success = false,
                    Error = ex
                };
            }
        }

        public async Task<Response<CatFact>> GetFact()
        {
            var factsResponse = await GetFacts();
            return factsResponse.Success
                ? new Response<CatFact> { Success = true, Value = factsResponse.Value?.FirstOrDefault() }
                : new Response<CatFact> { Success = false, Error = factsResponse.Error };
        }

        public void Dispose() => httpClient?.Dispose();
    }
}
