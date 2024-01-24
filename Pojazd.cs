public class Pojazd
{

    public string Marka { get; set; } = string.Empty;
    public string Rodzaj { get; set; } = string.Empty;
    public string NrRej { get; set; } = string.Empty;
    public string DataWjazdu { get; set; } = string.Empty;
    public string Miejsce { get; set; } = string.Empty;
    public string GodzinaWjazdu { get; set; } = string.Empty;
    public string CzasPostoju { get; set; } = string.Empty;
    public string GodzinaWyjazdu { get; set; } = string.Empty;
    public string Zaplata { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}

public class DanePojazdow
{
    public List<string> Osobowe { get; set; } = new List<string>();
    public List<string> Ciezarowe { get; set; } = new List<string>();
    public List<Pojazd> Pojazdy { get; set; }
}
