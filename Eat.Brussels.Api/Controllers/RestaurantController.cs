using ContextWithEntityFramework;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Eat.Brussels.Api.Controllers
{
    public class RestaurantController : ApiController
    {
        private DatabaseContext databaseContext = new DatabaseContext();

        Restaurant[] restaurants = new Restaurant[]
        {
            new Restaurant
            {
                Name = "Colpan",
                PhoneNumber = "1234",
                StreetNumber = "1",
                Street = "Rue des palais",
                City = "Bruxelles",
                PostalCode = "1000",
            },
            new Restaurant
            {
                Name = "Gino",
                PhoneNumber = "12354",
                StreetNumber = "5",
                Street = "Rue italia",
                City = "Bruxelles",
                PostalCode = "1050",
            }
        };
        //http://localhost:56109/api/Restaurant/GetAllRestaurants
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            //RestaurantRepo repo = new RestaurantRepo(databaseContext);
            //List<Restaurant> restos = repo.RetrieveAll();
            //return restos;

            return restaurants;
        }

        //Essai 1 : 
        //public IEnumerable<Restaurant> GetAllRestaurants(string query)
        //{
        //    //Gérer les erreurs de la query
        //    CookTypeRepo repoCookType = new CookTypeRepo(databaseContext);
        //    RestaurantRepo repoRestaurant = new RestaurantRepo(databaseContext);
        //    List<CookType> types = repoCookType.RetrieveByTitle(query);
        //    List<Restaurant> restos;
        //    if (types == null)
        //    {
        //        restos = repoRestaurant.RetrieveByName(query);
        //    }
        //    else
        //    {
        //        //restos = .ToList();
        //    }
        //    return restos;
        //}
    }
}
