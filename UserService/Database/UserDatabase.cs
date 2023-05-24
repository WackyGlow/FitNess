using System.Collections.Generic;
using MongoDB.Driver;
using UserService.Models;

namespace UserService.Database;

public class UserDatabase
{
    private readonly IMongoCollection<User> _users;

    /// <summary>
    /// Initializes a new instance of the UserDatabase class.
    /// Connects to the MongoDB database and initializes the collection for users.
    /// </summary>
    public UserDatabase()
    {
        // Connect to the MongoDB database
        //var connectionString = "mongodb+srv://rasm92i3:" + Uri.EscapeDataString("12344321") +
        //    "@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority&authMechanism=SCRAM-SHA-256";
        var connectionString = "mongodb+srv://rasm92i3:flaskebong420@cluster0.te79kwa.mongodb.net/";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("UserServiceDB");

        // Initialize the collection for users
        _users = database.GetCollection<User>("UserCollection");
    }

    /// <summary>
    /// Retrieves all users from the database.
    /// </summary>
    /// <returns>
    /// Returns a list of User objects representing all the users in the database.
    /// </returns>
    public List<User> GetUsers()
    {
        // Retrieve all users from the database
        var users = _users.Find(user => true).ToList();

        // Return the list of users
        return users;
    }

    /// <summary>
    /// Retrieves a user from the database by their ID.
    /// </summary>
    /// <param name="id">The ID of the user to retrieve.</param>
    /// <returns>
    /// Returns a User object representing the user with the specified ID, or null if the user is not found.
    /// </returns>
    public User GetUserById(int id)
    {
        // Retrieve the user from the database by their ID
        var user = _users.Find<User>(user => user.Id == id).FirstOrDefault();

        // Return the user, or null if not found
        return user;
    }

    /// <summary>
    /// Creates a new user in the database.
    /// </summary>
    /// <param name="user">The User object representing the user to create.</param>
    /// <returns>
    /// Returns the created User object.
    /// </returns>
    public User CreateUser(User user)
    {
        // Insert the user into the database
        _users.InsertOne(user);

        // Return the created user
        return user;
    }

    /// <summary>
    /// Updates an existing user in the database.
    /// </summary>
    /// <param name="id">The ID of the user to update.</param>
    /// <param name="userIn">The User object representing the updated user data.</param>
    public void UpdateUser(int id, User userIn)
    {
        // Update the user in the database based on the provided ID
        _users.ReplaceOne(user => user.Id == id, userIn);
    }

    /// <summary>
    /// Deletes a user from the database.
    /// </summary>
    /// <param name="userIn">The User object representing the user to delete.</param>
    public void DeleteUser(User userIn)
    {
        // Delete the user from the database based on the user's ID
        _users.DeleteOne(user => user.Id == userIn.Id);
    }

}