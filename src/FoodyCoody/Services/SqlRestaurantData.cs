using System.Collections.Generic;
using System.Linq;
using FoodyCoody.Entities;

namespace FoodyCoody.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private FoodyCoodyDbContext _context;

        public SqlRestaurantData(FoodyCoodyDbContext context)
        {
            _context = context;
        }

        public void Add(Restaurant restaurant)
        {
            _context.Add(restaurant);
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
