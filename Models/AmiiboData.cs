namespace amiibo_getter.Models;

public class AmiiboData
{
    public string Indo { get; set; } = null!;
    public string Name { get; set; } = null!;
    public SeriesData Series { get; set; } = new();
    public string ReleaseDate { get; set; } = null!;
}
