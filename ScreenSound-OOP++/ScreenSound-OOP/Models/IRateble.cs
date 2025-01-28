namespace ScreenSound.Models;

internal interface IRateble
{
    double Average { get; }
    void AddRating(params Rating[] rating);
}
