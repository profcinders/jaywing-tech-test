using JaywingTechTest.Features.CatFacts.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.Blocks;
using PublishedModels = Umbraco.Cms.Web.Common.PublishedModels;

namespace JaywingTechTest.Features.CatFacts
{
    public class CatFactViewComponent(ICatFactsService catFactsService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BlockGridItem<PublishedModels.CatFact> block)
        {
            var factResponse = await catFactsService.GetFact();

            var model = new CatFactViewModel
            {
                Heading = block.Content.Heading,
                Success = factResponse.Success,
                Fact = factResponse.Success ? factResponse.Value?.Text : null,
                ErrorMessage = "We had some difficulties retrieving a fact. You could try again later?",
            };

            return View(model);
        }
    }
}
