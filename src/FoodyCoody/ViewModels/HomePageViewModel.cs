using FoodyCoody.Entities;
using System.Collections.Generic;

namespace FoodyCoody.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
