using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using System.Collections.Generic;

namespace RocketseatAuction.API.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Projetos\RocketSeat\RocketseatAuction\leilaoDbNLW.db");

        }
    }
}
