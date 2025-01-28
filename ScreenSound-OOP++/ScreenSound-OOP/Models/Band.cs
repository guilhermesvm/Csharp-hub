namespace ScreenSound.Models;

internal class Band : IRateble
{
    public string Name { get; }
    public string? Summary { get; set; }
    public IEnumerable<Album> Albums => _albumList;

    public double Average
    {
        get
        {
            if (_ratingList.Count <= 0) return 0;  
            else return _ratingList.Average(a => a.Score);
        }
    }

    private List<Album> _albumList = new List<Album>();
    private List<Rating> _ratingList = new List<Rating>();

    public Band(string name)
    {
        this.Name = name;
    }
    
    public void AddAlbum(Album albumName)
    {
        _albumList.Add(albumName);
    }

    public void AddRating(params Rating[] ratings)
    {
        _ratingList.AddRange(ratings);
    }

    public void ShowBandsDiscography()
    {
        Console.WriteLine(Summary);
        Console.WriteLine($"Showing {Name} Discography: ");
        foreach(Album album in _albumList)
        {

            Console.WriteLine($"Album: {album.Name} - ({album.TotalDuration}) - Average rating: {album.Average}");
        }
        Console.WriteLine("");
    }
}