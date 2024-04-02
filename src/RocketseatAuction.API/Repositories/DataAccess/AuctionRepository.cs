using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Contracts;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly RocketseatAuctionDbContext _dbContext;
        public AuctionRepository(RocketseatAuctionDbContext dbContext) => _dbContext = dbContext;
        
        public Auction? GetCurrent()
        {
            var currentDate = DateTime.Now;

            return _dbContext
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(a => currentDate >= a.Starts && currentDate <= a.Ends);            
        }

        public IEnumerable<Auction> GetAll()
        {
            return _dbContext
                .Auctions
                .Include(auction => auction.Items)
                .ToList();
        }
    }
}
