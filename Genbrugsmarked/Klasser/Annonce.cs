namespace Core.Klasser;

public class Annonce
{
    public int AnnonceID { get; set; }
    public string Titel  { get; set; }
    public string Beskrivelse { get; set; }
    public double Pris { get; set; }
    public bool Status { get; set; }
    public DateTime OprettetDato { get; set; }
}