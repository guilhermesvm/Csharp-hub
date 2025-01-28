namespace ScreenSound.Models;
internal class Episode
{
    public int Duration { get; }
    public int Order { get; }
    public string Title { get; }
    public string Summary => $"#{Order} - {Title} ({Duration}min) - {string.Join(", ", _guests)}";

    private List<string> _guests = new List<string>();
            
    public Episode(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }
   
    public void AddGuests(string guest)
    {
        _guests.Add(guest);

    }
}