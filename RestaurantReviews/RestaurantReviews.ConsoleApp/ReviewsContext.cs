using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.ConsoleApp
{
    public class ReviewsContext : DbContext
    {
        public DbSet<List<Restaurant>> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=../../../persons.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
