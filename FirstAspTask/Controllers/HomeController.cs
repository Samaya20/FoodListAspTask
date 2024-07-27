using FirstAspTask.Entities;
using FirstAspTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstAspTask.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var viewModel = GetFoodViewModel();
            return View(viewModel);
        }

        public IActionResult Foods()
        {
            var viewModel = GetFoodViewModel();
            return View(viewModel);
        }

        public IActionResult Drinks()
        {
            var viewModel = GetFoodViewModel();
            return View(viewModel);
        }

        public IActionResult FastFoods()
        {
            var viewModel = GetFoodViewModel();
            return View(viewModel);
        }

        public IActionResult HotMeals()
        {
            var viewModel = GetFoodViewModel();
            return View(viewModel);
        }

        private FoodViewModel GetFoodViewModel()
        {
            List<Drink> drinks = new List<Drink> 
            {
                new Drink
                {
                    Id = 1,
                    Name = "Coca Cola",
                    Price = 1.90m,
                    Category = "Drink",
                    IsAlcoholic = false
                },
                new Drink
                {
                    Id = 2,
                    Name = "Orange Juice",
                    Price=2.5m,
                    Category = "Drink",
                    IsAlcoholic = false,
                },
                new Drink
                {
                    Id = 3,
                    Name = "Tequila",
                    Price=20.95m,
                    Category = "Drink",
                    IsAlcoholic = true
                }
            };

            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id = 1,
                    Name = "Cheeseburger",
                    Price = 5.00m,
                    Category = "FastFood",
                    IsVegan = false
                },
                new FastFood
                {
                    Id = 2,
                    Name = "Veggie Wrap",
                    Price = 4.50m,
                    Category = "FastFood",
                    IsVegan = true
                }
            };

            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id = 1,
                    Name = "Spaghetti Bolognese",
                    Price = 8.00m,
                    Category = "HotMeal",
                    Cuisine = "Italian"
                },
                new HotMeal
                {
                    Id = 2,
                    Name = "Chicken Curry",
                    Price = 9.00m,
                    Category = "HotMeal",
                    Cuisine = "Indian"
                }
            };

            var allFoods = new List<Food>();
            allFoods.AddRange(drinks);
            allFoods.AddRange(fastFoods);
            allFoods.AddRange(hotMeals);

            return new FoodViewModel
            {
                Foods = allFoods,
                HotMeals = hotMeals,
                Drinks = drinks,
                FastFoods = fastFoods
            };
        }
    }
}