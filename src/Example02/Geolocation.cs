namespace Example02;

public sealed record Geolocation
{
    public double Longitude { get; private init; }
    public double Latitude { get; private init; }

    public static Geolocation Create(double longitude, double latitude)
    {
        return new Geolocation
        {
            Longitude = longitude,
            Latitude = latitude
        };
    }
}
