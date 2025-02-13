using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Models;

namespace ScreenSound_ASP.NET.Repository;

internal abstract class Repository<T> where T : class
{
    protected readonly ScreenSoundContext _context;

    protected Repository(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public void Create(T obj)
    {
        _context.Set<T>().Add(obj);
        _context.SaveChanges();
    }
    public void Update(T obj)
    {
        _context.Set<T>().Update(obj);
        _context.SaveChanges();
    }
    public void Delete(T obj)
    {
        _context.Set<T>().Remove(obj);
        _context.SaveChanges();
    }
}
