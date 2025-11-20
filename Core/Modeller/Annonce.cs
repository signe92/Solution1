using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Klasser;

public class Annonce
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    
    public ObjectId _id { get; set; }
    public int AnnonceID { get; set; }
    public string Titel  { get; set; }
    public string Beskrivelse { get; set; }
    public double Pris { get; set; }
    public bool Status { get; set; }
    public DateTime OprettetDato { get; set; } = DateTime.Now;
}