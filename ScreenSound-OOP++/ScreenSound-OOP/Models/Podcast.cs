namespace ScreenSound.Models;

internal class Podcast
{
    public string Host { get; }
    public string Name { get; }
    public int totalEpisodes => _episodeList.Count;

    private List<Episode> _episodeList = new List<Episode>();

    public Podcast(string host, string name)
    {
        this.Host = host;
        this.Name = name;
    }

    public void AddEpisode(Episode episode)
    {
        _episodeList.Add(episode);
    }

    public void ShowPodcastDetails()
    {
        Console.WriteLine($"Podcast: {Name} | Host: {Host}");
        Console.WriteLine("Episodes Summary:");
        foreach (Episode episode in _episodeList.OrderBy(ep => ep.Order))
        {
            Console.WriteLine($"{episode.Summary}");

        }
        Console.WriteLine($"Total episodes: {totalEpisodes}\n");
    }
}