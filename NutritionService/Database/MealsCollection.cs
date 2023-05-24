using MongoDB.Driver;
using NutritionService.Models;

namespace NutritionService.Database;

public class MealsCollection
{
    private readonly IMongoCollection<MealList> _meals;

    public MealsCollection()
    {
        // Connect to the MongoDB database
        var connectionString = "mongodb+srv://rasm92i3:<P@n1cb0y5>@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("NutritionServiceDB");

        // Initialize the collection for users
        _meals = database.GetCollection<MealList>("MealsCollection");
    }
    
    public MealList AddMealsList(MealList meals)
    {
        _meals.InsertOne(meals);
        
        return meals;
    }
}