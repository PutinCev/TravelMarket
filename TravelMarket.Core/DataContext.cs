using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core
{
    public class DataContext:DbContext
    {
        public DbSet<UserDto> Users { get; set; }   
        public DbSet<ServiceDto> Services { get; set; } 
        public DbSet<PartnerDto> Partners { get; set; } 
        public DbSet<OrderDto> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = localhost; Port = 5432; User Id = postgres; Password = sa; Database = TravelShop;";
            optionsBuilder.UseNpgsql(connectionString);
        }

    }
}
