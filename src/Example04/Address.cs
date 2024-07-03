namespace Example04;

public sealed record Address
{
    public Country Country { get; init; }
    
    public Geolocation Geolocation { get; init; }
}