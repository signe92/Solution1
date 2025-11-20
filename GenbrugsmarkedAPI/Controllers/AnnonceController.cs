using Microsoft.AspNetCore.Mvc;
using GenbrugsmarkedAPI.Repositories;
using Core.Klasser;

namespace GenbrugsmarkedAPI.Controllers;
[ApiController]
[Route("api/Annoncer")]
public class AnnonceController : ControllerBase
{
   private IAnnoncerRepository annonceRepo;

   public AnnonceController(IAnnoncerRepository annonceRepo)
   {
      this.annonceRepo = annonceRepo;
   }

   [HttpGet]
   public List<Annonce> GetAll()
   {
      return annonceRepo.GetAll();
   }

   [HttpPost]
   public void AddAnnonce(Annonce annonce)
   {
      annonceRepo.addAnnonce(annonce);
   }

   [HttpDelete("{id}")]
   public IActionResult DeleteAnnonce(int id)
   {
      var annonce = annonceRepo.GetAll().FirstOrDefault(a => a.AnnonceID == id);
      if (annonce != null)
      {
         annonceRepo.deleteAnnonce(annonce);
         return Ok();
      }
      return NotFound();
   }


}