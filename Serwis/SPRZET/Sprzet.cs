namespace Serwis;

public abstract class  Sprzet
{
    private static int idCounter;
    

    protected Sprzet(string nazwa, string status, double kara)
    {
        this.Nazwa = nazwa;
        this.Status = status;
        this.Kara = kara;
        this.Id = idCounter;
        idCounter++;
    }

    public int Id { get; private set; }

    public string Nazwa { get; set; }

    public string Status { get; set; }

    public double Kara { get; set; }

    public override string ToString()
    {
        return $"ID: {Id} | Nazwa: {Nazwa} | Status: {Status}";
    }
}