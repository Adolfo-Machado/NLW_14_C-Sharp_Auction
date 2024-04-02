using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.UseCases.Offers.GetOffers
{
    public class GetOffersUseCase
    {
        private readonly IOfferRepository _repository;

        public GetOffersUseCase(IOfferRepository repository) => _repository = repository;        

        public List<Offer> ExecuteGetAll() => _repository.GetAllOffers();
    }
}
