using System.Xml.Serialization;

namespace ScreenSound.Models;

internal class Rating
{
    public int Score { get; }

    public Rating(int score)
    {
        if (score <= 0) score = 0;    
        if (score >= 10) score = 10;
        this.Score = score;
    }

    public static Rating Parse(string text)
    {
        int rating = int.Parse(text);
        return new Rating(rating);
    }
}