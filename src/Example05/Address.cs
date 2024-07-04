namespace Example05;

public sealed record Address
{
    public Country Country { get; init; }
    
    public Geolocation Geolocation { get; init; }
}