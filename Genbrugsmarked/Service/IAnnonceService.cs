using Core.Klasser;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Genbrugsmarked.Service
{
    public interface IAnnonceService
    {
        Task<List<Annonce>> alleAnnoncer();
        Task NyAnnonce(Annonce annonce);
    }
}