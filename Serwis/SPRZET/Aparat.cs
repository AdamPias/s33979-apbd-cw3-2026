namespace Serwis;

public class Aparat : Sprzet
{
    public Aparat(string nazwa, string status, double kara, string matryca, double rozdzielczosc)
        : base(nazwa, status, kara)
    {
        this.Matryca = matryca;
        this.Rozdzielczosc = rozdzielczosc;
    }
    
    public string Matryca { get; set; }
    public double Rozdzielczosc { get; set; }
    
}