using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Models;

namespace ScreenSound_ASP.NET.Repository;

internal class ArtistRepository : Repository<Artist>
{
    public ArtistRepository(ScreenSoundContext context) : base(context) { }

    public Artist GetByName(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;
        return _context.Artists.FirstOrDefault(a => a.Name.Equals(name));
    }
}
