namespace Core.Klasser;

public class AnnonceService : IAnnonceService
{
    public List<Annonce> alleAnnoncer { get; set; } = new();

    public Task NyAnnonce(Annonce annonce)
    {
        alleAnnoncer.Add(annonce);
        return Task.CompletedTask;
    }
}