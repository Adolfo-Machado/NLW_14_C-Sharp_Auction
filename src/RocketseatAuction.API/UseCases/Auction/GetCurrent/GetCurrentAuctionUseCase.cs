using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;


namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

        public Auction? ExecuteCurrent() => _repository.GetCurrent();
        
        public IEnumerable<Auction> ExecuteAll() => _repository.GetAll();
    }
}