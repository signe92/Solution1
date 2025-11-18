namespace Core.Klasser;

public interface IAnnonceService
{
 Task NyAnnonce(Annonce annonce);
 List<Annonce> alleAnnoncer { get; }
}