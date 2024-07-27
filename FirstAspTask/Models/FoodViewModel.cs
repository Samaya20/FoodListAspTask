using FirstAspTask.Entities;
using System.Collections.Generic;

namespace FirstAspTask.Models
{
    public class FoodViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }
        public List<Food> Foods { get; set; }
    }
}
