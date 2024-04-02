using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Comunication.Requests;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;
using RocketseatAuction.API.UseCases.Offers.GetOffers;

namespace RocketseatAuction.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class OfferController : RocketseatAuctionBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer(
            [FromRoute]int itemId, 
            [FromBody] RequestCreateOfferJson request,
            [FromServices] CreateOfferUseCase usecase)
        {
            var id = usecase.CreateOffer(itemId, request);

            return Created(string.Empty, id);
        }

        [HttpGet]
        public List<Offer> GetOffers([FromServices] GetOffersUseCase useCase)
        {
            return useCase.ExecuteGetAll();
        }
        
    }
}
