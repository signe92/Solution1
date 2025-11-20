using Core.Klasser;
using Core.Modeller;
using MongoDB.Driver;
namespace GenbrugsmarkedAPI.Repositories;

public class AnnoncerRepositoryMongoDB : IAnnoncerRepository
{
    private IMongoCollection<Annonce> annonceCollection;

    public AnnoncerRepositoryMongoDB()
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
        var collectionName = "Annoncer";
        
        annonceCollection = client.GetDatabase(dbName).GetCollection<Annonce>(collectionName);
    }

    public void addAnnonce(Annonce annonce)
    {
        var max = 0;
        if (annonceCollection.CountDocuments(Builders<Annonce>.Filter.Empty) > 0)
        {
            max = MaxId();
        }
        annonce.AnnonceID = max + 1;
        annonceCollection.InsertOne(annonce);
    }
    
    private int MaxId() => GetAll().Select(a => a.AnnonceID).Max();

    public void deleteAnnonce(Annonce annonce)
    {
        var deleteResult = annonceCollection.DeleteOne(Builders<Annonce>.Filter.Where(r => r.AnnonceID == annonce.AnnonceID));
    }

    public List<Annonce> GetAll()
    {
        var noFilter = Builders<Annonce>.Filter.Empty;
        return annonceCollection.Find(noFilter).ToList();
    }
}