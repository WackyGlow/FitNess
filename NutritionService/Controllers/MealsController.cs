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
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private MealsCollection _mealsCollection = new MealsCollection();
            
        [HttpPost]
        public MealList AddMealList([FromBody] MealList meals)
        {
            meals.DateOnly = DateOnly.FromDateTime(DateTime.Now);
           return _mealsCollection.AddMealsList(meals);
        }
    }
}
