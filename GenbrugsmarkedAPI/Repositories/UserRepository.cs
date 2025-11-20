using Core.Modeller;
using MongoDB.Driver;
namespace GenbrugsmarkedAPI.Repositories;


public class UserRepository : IUserRepository

{
    private IMongoCollection<User> userCollection;
    
    public UserRepository()
    {
        // atlas database
        var password = "mongoman";
        var mongourl = $"mongodb+srv://mgmw2:{password}@miniprojekt.tnn6pzl.mongodb.net/";

        MongoClient client;
        try
        {
            client = new MongoClient(mongourl);
        }
        catch (Exception e)
        {
            Console.WriteLine("error connecting to database");
            throw;
        }

        var dbName = "Genbrug";
        var collectionName = "User";
        
        userCollection = client.GetDatabase(dbName).GetCollection<User>(collectionName);
    }
    
    public List<User> GetAll()
    {
        return userCollection.Find(FilterDefinition<User>.Empty).ToList();
    }
    
    public User? GetUserById(int id)
    {
        return userCollection.Find(u => u.UserID == id).FirstOrDefault();
    }
    
    public async Task<bool> Login(string email, string password)
    {
        var user = await userCollection.Find(u => u.Email == email).FirstOrDefaultAsync();
        if (user == null) return false;

        return password == user.Password;
    }
    
}