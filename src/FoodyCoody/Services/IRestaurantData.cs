using FoodyCoody.Entities;
using System.Collections.Generic;

namespace FoodyCoody.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        int Commit();
    }
}
