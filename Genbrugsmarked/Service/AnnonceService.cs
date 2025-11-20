using System.Net.Http.Json;
using Core.Klasser;

namespace Genbrugsmarked.Service;

public class AnnonceService : IAnnonceService
{
    private readonly HttpClient _client;

    public AnnonceService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<Annonce>> alleAnnoncer()
    {
        return await _client.GetFromJsonAsync<List<Annonce>>("http://localhost:5127/api/Annoncer")
               ?? new List<Annonce>();
    }

    public async Task NyAnnonce(Annonce annonce)
    {
        await _client.PostAsJsonAsync("http://localhost:5127/api/Annoncer", annonce);
    }
}