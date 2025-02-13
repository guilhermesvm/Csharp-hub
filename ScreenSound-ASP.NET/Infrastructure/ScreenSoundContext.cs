using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound_ASP.NET.Models;

namespace ScreenSound_ASP.NET.Infrastructure;

internal class ScreenSoundContext : DbContext
{
    private readonly string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Connect Timeout=0;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    public DbSet<Artist> Artists { get; set; }
  
    public DbSet<Song> Songs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(ConnectionString);
    }

    //Old
    public SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}

