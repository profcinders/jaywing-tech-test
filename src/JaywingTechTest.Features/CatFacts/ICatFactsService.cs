using JaywingTechTest.Features.CatFacts.Models;

namespace JaywingTechTest.Features.CatFacts
{
    public interface ICatFactsService
    {
        Task<Response<IEnumerable<CatFact>>> GetFacts();

        Task<Response<CatFact>> GetFact();
    }
}
