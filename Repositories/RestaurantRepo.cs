using Common;
using ContextWithEntityFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class RestaurantRepo : ICrudable<Restaurant>
    {
        private DatabaseContext dbContext;
        public RestaurantRepo(DatabaseContext db)
        {
            dbContext = db;
        }

        public Restaurant Create(Restaurant obj)
        {
            dbContext.Restaurants.Add(obj);
            dbContext.SaveChanges();
            return obj;
        }

        public void Delete(int id)
        {
            Restaurant restaurant = Retrieve(id);
            dbContext.Restaurants.Remove(restaurant);
            dbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

        public Restaurant Retrieve(int id)
        {
            return dbContext.Restaurants.FirstOrDefault(u => u.RestaurantId == id);
        }

        public Restaurant Retrieve(string idString)
        {
            int id;
            if (int.TryParse(idString, out id))
                return Retrieve(id);
            return null;
        }

        public List<Restaurant> RetrieveAll()
        {
            return dbContext.Restaurants.ToList();
        }

        public void Update(Restaurant obj)
        {
            Restaurant restaurant = Retrieve(obj.RestaurantId);
            restaurant = obj;
            dbContext.SaveChanges();
        }
    }
}
