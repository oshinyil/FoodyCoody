using FoodyCoody.Entities;
using System.ComponentModel.DataAnnotations;

namespace FoodyCoody.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
