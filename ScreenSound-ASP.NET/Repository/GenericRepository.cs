using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Models;

namespace ScreenSound_ASP.NET.Repository;

internal class GenericRepository<T> where T : class
{
    protected readonly ScreenSoundContext _context;

    public GenericRepository(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetBy(Func<T,bool> condition)
    {
        return _context.Set<T>().FirstOrDefault(condition);
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
