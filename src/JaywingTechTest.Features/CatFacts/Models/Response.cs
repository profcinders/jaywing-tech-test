namespace JaywingTechTest.Features.CatFacts.Models
{
    public class Response<T>
    {
        public bool Success { get; set; }

        public T? Value { get; set; }

        public Exception? Error { get; set; }
    }
}
