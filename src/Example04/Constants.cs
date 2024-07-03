namespace Example04;

public static class Constants
{
    public static readonly (int Min, int Max) Latitude = new(-90, 90);
    public static readonly (int Min, int Max) Longitude = new(-180, 180);

    public static readonly string[] Countries =
    [
        "China",
        "Japan",
        "France",
        "Italy",
        "Spain",
        "Brazil"
    ];
}