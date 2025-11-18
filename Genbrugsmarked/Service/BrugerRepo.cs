using Genbrugsmarked.Logic;

namespace Genbrugsmarked.Service;



public class BrugerRepo
{
    private  List<Bruger> mBrugere;

    public BrugerRepo()
    {
        mBrugere = [new Bruger { BrugerID = 1, Navn = "Sophie", Email = "Sophie@mail.dk", Password = "1234" }, 
            new Bruger {BrugerID = 2, Navn = "Magnus", Email = "Magnus@mail.com", Password = "1234"},
            new Bruger {BrugerID = 3, Navn = "Signe", Email = "Signe@mail.com", Password = "1234"},
            new Bruger {BrugerID = 4, Navn = "Frederik", Email = "Frederik@mail.dk", Password = "1234"}];
    }

    public Bruger? ValidLogin(string Email, string Password)
    {
        foreach (Bruger b in mBrugere)
            if (b.Email == Email && b.Password == Password)
            {
                return b;
            }
        return null;
    }
}