namespace Core.Klasser;

public class Annonce
{
    public int AnnonceID { get; set; }
    public string Titel  { get; set; }
    public string Beskrivelse { get; set; }
    public double Pris { get; set; }
    public bool Status { get; set; } //false = ikke købt, true = købt og reserveret
    public DateTime OprettetDato { get; set; }
}