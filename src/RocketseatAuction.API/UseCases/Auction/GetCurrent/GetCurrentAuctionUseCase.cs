using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;
using System;
using System.Linq;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? GetCurrent()
        {
            var repository = new RocketseatAuctionDbContext();

            var currentDate = DateTime.Now;

            var currentAuction = repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(a => currentDate >= a.Starts && currentDate <= a.Ends);

            return currentAuction;
        }

        public IEnumerable<Auction> GetAll()
        {
            var repository = new RocketseatAuctionDbContext();

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .ToList();
        }
    }
}
