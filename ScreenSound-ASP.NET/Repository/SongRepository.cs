using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Models;

namespace ScreenSound_ASP.NET.Repository;

internal class SongRepository : Repository<Song>
{
    private readonly ScreenSoundContext _context;

    public SongRepository(ScreenSoundContext context)
    {
        _context = context;
    }

    public override IEnumerable<Song> GetAll()
    {
        return _context.Songs.ToList();
    }

    public override Song GetByName(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;
        return _context.Songs.FirstOrDefault(s => s.Name.Equals(name));

    }

    public override void Create(Song song)
    {
        _context.Songs.Add(song);
        _context.SaveChanges();
    }

    public override void Update(Song song)
    {
        _context.Songs.Update(song);
        _context.SaveChanges();
    }

    public override void Delete(Song song)
    {
        _context.Songs.Remove(song);
        _context.SaveChanges();
    }
}
