using Core.Klasser;
using System;
using System.Collections.Generic;

namespace GenbrugsmarkedAPI.Repositories
{
    public interface IAnnoncerRepository
    {
        List<Annonce> GetAll();
        void addAnnonce(Annonce annonce);
        void deleteAnnonce(Annonce annonce);
    }
}