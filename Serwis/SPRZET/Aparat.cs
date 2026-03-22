namespace Serwis;

public class Aparat : Sprzet
{
    public Aparat(string nazwa, double kara, string matryca, double rozdzielczosc)
        : base(nazwa, kara)
    {
        this.Matryca = matryca;
        this.Rozdzielczosc = rozdzielczosc;
    }
    
    public string Matryca { get; set; }
    public double Rozdzielczosc { get; set; }
    
}