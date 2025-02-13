using Microsoft.Data.SqlClient;
using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Infrastructure;

namespace ScreenSound_ASP.NET.ADONET;

internal class ArtistRepositoryADONET
{
    private readonly ScreenSoundContext _databaseConnection;

    public ArtistRepositoryADONET()
    {
        _databaseConnection = new ScreenSoundContext();
    }
    public IEnumerable<Artist> GetArtists()
    {
        List<Artist> artists = new List<Artist>();

        using var connection = _databaseConnection.GetConnection();
        connection.Open();
        string query = "SELECT * FROM Artists";

        SqlCommand cmd = new SqlCommand(query, connection);

        using SqlDataReader dataReader = cmd.ExecuteReader();
        while (dataReader.Read())
        {
            string artistName = Convert.ToString(dataReader["Name"])!;
            string artistBio = Convert.ToString(dataReader["Bio"])!;
            int artistId = Convert.ToInt32(dataReader["Id"]);

            Artist artist = new Artist(artistName, artistBio) { Id = artistId };
            artists.Add(artist);
        }
        return artists;
    }

    public void AddArtist(Artist artist)
    {
        using var connection = _databaseConnection.GetConnection();
        connection.Open();
        string query = "INSERT INTO Artists(Name, Bio, ProfilePicture)" +
            "VALUES (@name, @bio, @profilePicture)";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@name", artist.Name);
        cmd.Parameters.AddWithValue("@bio", artist.Bio);
        cmd.Parameters.AddWithValue("@profilePicture", artist.ProfilePicture);

        cmd.ExecuteNonQuery();
    }

    public void UpdateArtist(Artist artist)
    {
        using var connection = _databaseConnection.GetConnection();
        connection.Open();
        string query = "UPDATE Artists SET Name = @name, Bio = @bio, " +
            "ProfilePicture = @profilePicture WHERE Id = @id";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@name", artist.Name);
        cmd.Parameters.AddWithValue("@bio", artist.Bio);
        cmd.Parameters.AddWithValue("@profilePicture", artist.ProfilePicture);
        cmd.Parameters.AddWithValue("@id", artist.Id);

        cmd.ExecuteNonQuery();
    }

    public void DeleteArtist(Artist artist)
    {
        using var connection = _databaseConnection.GetConnection();
        connection.Open();
        string query = "DELETE FROM Artists WHERE Id = @id";

        SqlCommand cmd = new SqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", artist.Id);

        cmd.ExecuteNonQuery();
    }
}
