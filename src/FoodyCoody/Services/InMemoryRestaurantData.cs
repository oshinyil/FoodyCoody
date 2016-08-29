using FoodyCoody.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FoodyCoody.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        static List<Restaurant> _restaurants;

        static InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "KFC" },
                new Restaurant { Id = 2, Name = "McD" },
                new Restaurant { Id = 3, Name = "A&W" }
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
