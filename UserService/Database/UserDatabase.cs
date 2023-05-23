using System.Collections.Generic;
using MongoDB.Driver;
using UserService.Models;

namespace UserService.Database;

public class UserDatabase
{
    private readonly IMongoCollection<User> _users;

    /// <summary>
    /// Initializes a new instance of the UserDatabase class.
    /// </summary>
    public UserDatabase()
    {
        // Connect to the MongoDB database
        var connectionString = "mongodb+srv://rasm92i3:<P@n1cb0y5>@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("FitNess");
        _users = database.GetCollection<User>("users");
    }

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    /// <returns>A list of User objects representing all users in the database.</returns>
    public List<User> GetUsers()
    {
        return _users.Find(user => true).ToList();
    }

    /// <summary>
    /// Retrieves a user by their ID.
    /// </summary>
    /// <param name="id">The ID of the user to retrieve.</param>
    /// <returns>The User object representing the user with the specified ID.</returns>
    public User GetUserById(string id)
    {
        return _users.Find<User>(user => user.Id == id).FirstOrDefault();
    }

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="user">The User object representing the user to create.</param>
    /// <returns>The User object representing the newly created user.</returns>
    public User CreateUser(User user)
    {
        _users.InsertOne(user);
        return user;
    }

    /// <summary>
    /// Updates an existing user.
    /// </summary>
    /// <param name="id">The ID of the user to update.</param>
    /// <param name="userIn">The User object representing the updated user.</param>
    public void UpdateUser(string id, User userIn)
    {
        _users.ReplaceOne(user => user.Id == id, userIn);
    }

    /// <summary>
    /// Deletes a user.
    /// </summary>
    /// <param name="userIn">The User object representing the user to delete.</param>
    public void DeleteUser(User userIn)
    {
        _users.DeleteOne(user => user.Id == userIn.Id);
    }

}