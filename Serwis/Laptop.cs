namespace Serwis;

public class Laptop : Sprzet
{
    public Laptop(string nazwa, string status, double kara, int ram, string procesor)
        : base(nazwa, status, kara)
    {
        this.Procesor = procesor;
        this.Ram = ram;
    }

    public int Ram { get; set; }
    public String Procesor  { get; set; }
    
}