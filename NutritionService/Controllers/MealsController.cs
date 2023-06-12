using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutritionService.Database;
using NutritionService.Models;

namespace NutritionService.Controllers
{
    /// <summary>
    /// Controller for managing meals.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private MealsCollection _mealsCollection = new MealsCollection();

        /// <summary>
        /// Adds a meal list to the collection.
        /// </summary>
        /// <param name="meals">The meal list to add.</param>
        /// <returns>The added meal list.</returns>
        [HttpPost]
        public async Task<MealList> AddMealList([FromBody] MealList meals)
        {
            meals.DateOnly = DateOnly.FromDateTime(DateTime.Now);
           return _mealsCollection.AddMealsList(meals);
        }
    }
}
