using MongoDB.Driver;
using NutritionService.Models;

namespace NutritionService.Database;


/// <summary>
/// Represents a collection for storing meals in a MongoDB database.
/// </summary>
public class MealsCollection
{
    private readonly IMongoCollection<MealList> _meals;

    /// <summary>
    /// Initializes a new instance of the MealsCollection class.
    /// </summary>
    public MealsCollection()
    {
        // Connect to the MongoDB database
        var connectionString = "mongodb+srv://rasm92i3:<P@n1cb0y5>@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("NutritionServiceDB");

        // Initialize the collection for users
        _meals = database.GetCollection<MealList>("MealsCollection");
    }

    /// <summary>
    /// Adds a meals list to the collection.
    /// </summary>
    /// <param name="meals">The meals list to be added.</param>
    /// <returns>The added meals list.</returns>
    public MealList AddMealsList(MealList meals)
    {
        _meals.InsertOne(meals);
        
        return meals;
    }
}