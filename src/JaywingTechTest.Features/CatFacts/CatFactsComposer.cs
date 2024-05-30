using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace JaywingTechTest.Features.CatFacts
{
    public class CatFactsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddHttpClient<ICatFactsService, CatFactsService>(client =>
            {
                client.BaseAddress = new Uri("https://cat-fact.herokuapp.com/");
            });
        }
    }
}
