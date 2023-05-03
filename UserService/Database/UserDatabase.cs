using MongoDB.Driver;
using UserService.Models;

namespace UserService.Database;

public class UserDatabase
{
    private readonly IMongoCollection<User> _users;

    public UserDatabase()
    {
        var connectionString = "mongodb+srv://rasm92i3:<P@n1cb0y5>@cluster0.te79kwa.mongodb.net/?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("FitNess");
        _users = database.GetCollection<User>("users");
    }
    
    public List<User> GetUsers()
    {
        return _users.Find(user => true).ToList();
    }

    public User GetUserById(string id)
    {
        return _users.Find<User>(user => user.Id == id).FirstOrDefault();
    }

    public User CreateUser(User user)
    {
        _users.InsertOne(user);
        return user;
    }

    public void UpdateUser(string id, User userIn)
    {
        _users.ReplaceOne(user => user.Id == id, userIn);
    }

    public void DeleteUser(User userIn)
    {
        _users.DeleteOne(user => user.Id == userIn.Id);
    }
    
}