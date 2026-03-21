namespace Serwis;

public class Mikrofon : Sprzet
{
    public Mikrofon(string nazwa, string status, double kara, String przetwornik, String pasmo) 
        : base(nazwa, status, kara)
    {
        this.Pasmo = pasmo;
        this.Przetwornik = przetwornik;

    }
    
    public String Przetwornik { get; set; }
    public String Pasmo { get; set; }
}