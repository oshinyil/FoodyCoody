using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodyCoody.Models;

namespace FoodyCoody.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "KFC" },
                new Restaurant { Id = 2, Name = "McD" },
                new Restaurant { Id = 3, Name = "A&W" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
