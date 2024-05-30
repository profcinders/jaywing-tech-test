namespace JaywingTechTest.Features.CatFacts.Models
{
    public class CatFactViewModel
    {
        public string? Heading { get; init; }

        public bool Success { get; init; }

        public string? Fact { get; init; }

        public string ErrorMessage { get; init; }
    }
}
