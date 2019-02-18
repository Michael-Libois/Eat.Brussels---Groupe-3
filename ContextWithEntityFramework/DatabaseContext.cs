using Models;
using System;
using System.Data.Entity;

namespace ContextWithEntityFramework
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext():base("Name=")
        //{

        //}
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<CookType> CookTypes { get; set; }
        public virtual DbSet<RestaurantCookType> RestaurantCookTypes { get; set; }
        //public DbSet<City> Cities { get; set; }
        //public DbSet<Country> Countries { get; set; }

    }
}
