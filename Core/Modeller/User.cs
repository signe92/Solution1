using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Modeller;


public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    
    public ObjectId _id { get; set; }
    
    public int UserID { get; set; }
    
    public string Navn { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
}